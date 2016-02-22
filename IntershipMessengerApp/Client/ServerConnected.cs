using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class ServerConnected
    {
        TcpClient _tcpClient;
        public List<User> userList { get; set; }
        Queue<Message> _messageQueue;
        byte[] _messageLenght;
        User me;

        public event Action<Message> MessageReceived;
        public event Action<User> NewUserConnected;
        public event Action<User> UserDisconnected;

        public ServerConnected()
        {
            userList = new List<User>();
            me = new User();
        }


        public void Connnect(string IP, int Port, String Nickname)
        {
            _tcpClient = new TcpClient(IP, Port);
            
            _messageQueue = new Queue<Message>();

            _messageLenght = new byte[sizeof(int)];


            var startThread = new Thread(this.StartSender);
            startThread.Start();
            this.MessageReceived += OnMessageReceived;
            this.NewUserConnected += OnNewUserConnected;
            this.UserDisconnected += OnUserDisconnected;

            var sendThread = new Thread(this.SendSender);
            sendThread.Start();


        }
        

        private void SendSender()//Sender
        {
            while(true)
            {
                if (_messageQueue.Count == 0)
                    continue;

                var message = _messageQueue.Dequeue();
                var stream = _tcpClient.GetStream();
                var data = message.GetBytes();

                var dataLength = BitConverter.GetBytes(data.Length);

                stream.Write(dataLength, 0, dataLength.Length);
                stream.Write(data, 0, data.Length);
            }
            

        }

        private void StartSender()//Receiver
        {
            var stream = _tcpClient.GetStream();
            stream.Read(_messageLenght, 0, _messageLenght.Length);

            var data = new byte[BitConverter.ToInt32(_messageLenght, 0)];
            stream.Read(data, 0, data.Length);

            var message = new Message();
            message.ReadBytes(data);

            if (MessageReceived != null)
            {
                var thread = new Thread(() => MessageReceived(message));
                thread.Start();
            }
        }

        private void OnMessageReceived( Message message)
        {

            if(me.ClientId == 0)
            {
                string idString = MiddleString(message.MessageText, "CLIENTID=", ";");

                int intID;
                bool parsed = Int32.TryParse(idString, out intID);

                if (parsed && intID != 0)
                    me.ClientId = intID;
                else
                    Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", idString);
            }
            else
            {
                string newClientIDString = MiddleString(message.MessageText, "NEWCLIENTID=", ";");

                int newClientID;
                bool parsed = Int32.TryParse(newClientIDString, out newClientID);

                if (parsed && newClientID != 0)
                {
                    string newClientNick= MiddleString(message.MessageText, "NICKNAME=", ";");

                    User newUser = new User();
                    newUser.ClientId = newClientID;
                    newUser.Nickname = newClientNick;
                    NewUserConnected(newUser);
                }
                else
                    Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", message.MessageText);
            }
        }

        public string MiddleString(string inString, string startsWith,string endsWith)
        {
            int first = inString.IndexOf(startsWith);
            int last = inString.IndexOf(endsWith,first);

            if (first == 0 && last == 0)
                return "";

            return inString.Substring(first + startsWith.Length, last - first);
        }

        public void SendMessage(Message message)
        {
            _messageQueue.Enqueue(message);
        }
        
        void OnNewUserConnected (User user)
        {
            userList.Add(user);
        }
        void OnUserDisconnected (User user)
        {
            userList.Remove(user);
        }
    }
}
