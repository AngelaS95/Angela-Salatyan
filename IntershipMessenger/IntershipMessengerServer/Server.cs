using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace IntershipMessengerServer
{
    class Server
    {

        TcpListener _listener;
        List<Client> _clients;

        int port { get; set; }
        List<User> users { get; set; }
        public ServerConfiguration Config
        {
            get; private set;
        }

        public Server()
        {
            Config = new ServerConfiguration();
            _clients = new List<Client>();
        }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, Config.Port);
            _listener.Start();
            while (true)
            {
                var tcpClient = _listener.AcceptTcpClient();
                public var newClient = new TcpClient(tcpClient);
                HandleClient(newClient);
            }
            
        }

        private void HandleClient(TcpClient newClient)
        {
            _clients.Add(newClient);
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

    }
}
