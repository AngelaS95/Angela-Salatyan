using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntershipMessengerServer
{
    public class Messages
    {
        User sender { get; set; }
        string messageText { get; set; }
        DateTime timeStump { get; set; }
    }
}
