using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntershipMessengerServer;
using System.Net.Sockets;

namespace IntershipMessengerClient
{
    class Client
    {
        TcpClient _tcpClient;

        public Client(TcpClient tcpClient)
        {
            _tcpClient = tcpClient;
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
            
        }
    }
}
