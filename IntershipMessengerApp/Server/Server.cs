using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Server
{
    class Server
    {
        TcpListener _listener;
        List<Client> _clients;

        int _currentClientId;

        public ServerConfigurations Config
        {
            get; private set;
        }
        
        public Server()
        {
            Config = new ServerConfigurations();
            _clients = new List<Client>();
        }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, Config.Port);
            _listener.Start();

            while (true)
            {
                var tcpClient = _listener.AcceptTcpClient();
                var newClient = new Client(tcpClient);
                HandleClient(newClient);
            }


        }

        void HandleClient(Client newClient)
        {


            _clients.Add(newClient);



            newClient.ClientId = ++_currentClientId;

            var sendThread = new Thread(newClient.StartSend);
            sendThread.Start();




            newClient.SendMessage(new Messages
            {
                ClientId = 0,
                MessageText = $"CLIENTID={newClient.ClientId}",
            });

            foreach (var client in _clients)
            {
                if (client == newClient)
                    continue;

                newClient.SendMessage(new Messages
                {
                    ClientId = 0,
                    MessageText = $"CLIENTID={client.ClientId};NICKNAME={client.Nickname}",
                });

            }


            newClient.MessageReceived += OnMessageReceived;

            var receiveThread = new Thread(newClient.StartReceive);
            receiveThread.Start();
           

        }

        void OnMessageReceived(Client client, Messages message)
        {
            if (!client.NicknameReceived)
            {
                client.Nickname = message.MessageText;
                client.NicknameReceived = true;
                Broadcast(new Messages
                {
                    ClientId = 0,
                    MessageText = $"NEWCLIENTID={client.ClientId};NICKNAME={client.Nickname};"
                });


                return;

            }

            Broadcast(message);



        }

        void Broadcast(Messages message)
        {
            foreach (var client in _clients)
            {
                client.SendMessage(message);
            }
        }


        public void Stop()
        {
        }
        /*
        TcpListener _listener;
        List<Client> _clients;

        int _curtentClientId;

        int port { get; set; }
        List<User> users { get; set; }
        public ServerConfigurations Config
        {
            get; private set;
        }

        public Server()
        {
            Config = new ServerConfigurations();
            _clients = new List<Client>();
        }

        public void Send()
        {
            _listener = new TcpListener(IPAddress.Any, Config.Port);
            _listener.Start();
            while (true)
            {
                var tcpClient = _listener.AcceptTcpClient();
                var newClient = new TcpClient(tcpClient);
                HandleClient(newClient);
            }

        }

        private void HandleClient(TcpClient newClient)
        {
            _clients.Add(newClient);


            newClient.ClientId = ++_curtentClientId;

            newClient.SendMessage(new Messages
            {
                ClientId = 0;
            Messages = $"CLIENTID = {newClient.Cli}"
            }

            var sendThread = new Thread(newClient.StartSend);
            sendThread.Start();
            var reciveThread = new Thread(newClient.StartREcive);
            reciveThread.Start();

            throw new NotImplementedException();
        }

        public void Stop()
        {
        }

        void ConnectUser(User newUser) { }
        void DisconectUser(User removeUser) { }
        */

    }
}
