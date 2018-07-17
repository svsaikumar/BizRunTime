﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace client
{
    class client1
    {
        static Socket socket;
        static void Main(string[] args)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            try
            {
                socket.Connect(iPEndPoint);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to connect to server.! \r\n");
                Main(args);
            }
            Console.Write("Enter message : ");
            string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);

            socket.Send(data);
            Console.WriteLine("Message sent...\r\n");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            socket.Close();
        }
    }
}
