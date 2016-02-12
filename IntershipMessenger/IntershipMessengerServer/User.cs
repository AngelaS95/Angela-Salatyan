using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IntershipMessengerServer
{
    public class User
    {
        string displayName { get; set; }
        int id { get; set; }
        int port { get; set; }
        IPAddress ID { get; set; }

        void Send(Messages myMessage) { }
    }
}
