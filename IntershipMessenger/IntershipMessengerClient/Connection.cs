using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IntershipMessengerClient
{
    class Connection
    {
        bool messageResived { get; set; }

        void Connect(IPAddress ip, int port) { }
        void Disconnect() { }
        void SendMessage(string myMessage) { }

    }
}
