using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntershipMessengerServer
{
    class Server
    {
        int port { get; set; }
        List<User> users { get; set; }

        void Start() { }
        void Stop() { }
        void ConnectUser(User newUser) { }
        void DisconectUser(User removeUser) { }

    }
}
