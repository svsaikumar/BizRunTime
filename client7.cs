using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class client7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is client");
            //server setup
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            client.Connect(ip);

            string sendData = "";
            do
            {
                Console.Write("data to send:");
                sendData = Console.ReadLine();
                client.Send(Encoding.UTF8.GetBytes(sendData));

            } while (sendData.Length > 0);
            client.Close();
            Console.ReadKey();
        }
    }
}
