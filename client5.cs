using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class client5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is client");
            //server setup
            Socket master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            master.Connect(ip);

            string sendData = "";
            do
            {
                Console.Write("data to send:");
                sendData = Console.ReadLine();
                master.Send(Encoding.UTF8.GetBytes(sendData));//sends data to connected socket

            } while (sendData.Length > 0);
            master.Close();
            Console.ReadKey();
        }
    }
}
