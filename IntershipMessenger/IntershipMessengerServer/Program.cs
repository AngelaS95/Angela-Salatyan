﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntershipMessengerServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            if (args != null && args.Length>0)
            {
                server.Config.Port = Convert.ToInt32(args[0]);//firdt arg is port
                if(args.Length > 1 )
                {
                    server.Config.MaxClient = Convert.ToInt32(args[1]);//second arg is max client
                }
            }
            server.Start();

            Console.ReadLine();
        }
    }
}