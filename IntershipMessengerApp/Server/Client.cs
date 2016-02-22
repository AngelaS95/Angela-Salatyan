using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Client
    {
        TcpClient _tcpClient;
        Queue<Messages> _messageQueue;
        byte[] _messageLenght;


        public event Action<Client, Messages> MessageReceived;


        public TcpClient TcpClient
        {
            get
            {
                return _tcpClient;
            }
        }

        public int ClientId { get; set; }
        public string Nickname { get; set; }

        public bool NicknameReceived
        {
            get; set;
        }


        public Client(TcpClient tcpClient)
        {
            _tcpClient = tcpClient;
            _messageQueue = new Queue<Messages>();

            _messageLenght = new byte[sizeof(int)];

        }



        public void StartReceive()
        {
            while (true)
            {
                var stream = _tcpClient.GetStream();
                stream.Read(_messageLenght, 0, _messageLenght.Length);

                var data = new byte[BitConverter.ToInt32(_messageLenght, 0)];
                stream.Read(data, 0, data.Length);

                var message = new Messages();
                message.ReadBytes(data);

                if (MessageReceived != null)
                {
                    var thread = new Thread(() => MessageReceived(this, message));
                    thread.Start();
                }







            }


        }



        public void StartSend()
        {
            while (true)
            {
                if (_messageQueue.Count == 0)
                    continue;

                var message = _messageQueue.Dequeue();
                var stream = _tcpClient.GetStream();


                var data = message.GetBytes();

                var dataLenght = BitConverter.GetBytes(data.Length);

                stream.Write(dataLenght, 0, dataLenght.Length);
                stream.Write(data, 0, data.Length);



            }



        }

        public void SendMessage(Messages message)
        {


            this._messageQueue.Enqueue(message);
        }

        public Messages ReceiveMessage()
        {
            throw new NotImplementedException();
        }
        /*
        tcpclient _tcpclient;
        queue<messages> _messagequeue;
        byte[] _messagelenght;


        public event action<client, messages> messagereceived;


        public tcpclient tcpclient
        {
            get
            {
                return _tcpclient;
            }
        }

        public int clientid { get; set; }
        public string nickname { get; set; }

        public bool nicknamereceived
        {
            get; set;
        }


        public client(tcpclient tcpclient)
        {
            _tcpclient = tcpclient;
            _messagequeue = new queue<messages>();

            _messagelenght = new byte[sizeof(int)];

        }



        public void startreceive()
        {
            while (true)
            {
                var stream = _tcpclient.getstream();
                stream.read(_messagelenght, 0, _messagelenght.length);

                var data = new byte[bitconverter.toint32(_messagelenght, 0)];
                stream.read(data, 0, data.length);

                var message = new messages();
                message.readbytes(data);

                if (messagereceived != null)
                {
                    var thread = new thread(() => messagereceived(this, message));
                    thread.start();
                }
                
            }


        }



        public void startsend()
        {
            while (true)
            {
                if (_messagequeue.count == 0)
                    continue;

                var message = _messagequeue.dequeue();
                var stream = _tcpclient.getstream();


                var data = message.getbytes();

                var datalenght = bitconverter.getbytes(data.length);

                stream.write(datalenght, 0, datalenght.length);
                stream.write(data, 0, data.length);



            }



        }

        public void sendmessage(messages message)
        {


            this._messagequeue.enqueue(message);
        }

        public messages receivemessage()
        {
            throw new notimplementedexception();
        }

        public void connection()
        {
            //tcpclient _listener = new tcpclient();
            networkstream mystream = _tcpclient.getstream();//_listener.getstream();
           // binaryreader r = new binaryreader(nws); //принятие
            //binarywriter w = new binarywriter(nws); //отправка
                                                    // тут что - то ваше
        }

        public void sendmessage()
        {
            _messagequeue += messagereceived();
        }
        /*
        TcpClient _tcpClient;
        Queue<Messages> _messageQueue;
        public TcpClient tcpClient;

        public int clientId { get; set; }
        public TcpClient TcpClient
        {
            get
            {
                return _tcpClient;
            }

        }
        public Client(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            //TcpClient = tcpClient;
            _messageQueue = new Queue<Messages>();
        }

        public void SendMessage(Messages message)
        {
            this._messageQueue.Enqueue(message);
        }

        public TcpClient TcpClient1
        {
            get
            {
                return _tcpClient;
            }

            set
            {
                _tcpClient = value;
            }
        }

        void StartRecive()
        {
            //var stream = _tcpClient.GetStream();
            //var message = new Messages();
            //var bytes = stream.Read

            // Encoding.UTF8.

            // stream.Read
        }

        void StartSend()
        {
            while (true)
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
        */
    }
}
