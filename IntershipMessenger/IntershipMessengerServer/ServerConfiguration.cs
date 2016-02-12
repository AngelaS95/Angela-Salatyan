using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntershipMessengerServer
{
    class ServerConfiguration
    {
        public int Port { get; set; }
        public int MaxClient { get; set; }
        public ServerConfiguration()
        {
            this.Port = 1300;
            this.MaxClient = 10;
        }
    }
}
