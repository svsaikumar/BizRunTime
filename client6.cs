using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class client6
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
                master.Send(Encoding.UTF8.GetBytes(sendData));

                //get piggydata
                byte[] piggydata = new byte[4];
                master.Receive(piggydata);

                Console.WriteLine("out piggy data:" + Encoding.UTF8.GetString(piggydata));

            } while (sendData.Length > 0);
            master.Close();
            Console.ReadKey();
        }
    }
}
