using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace client
{
    class Client1
    {
        static void Main(string[] args)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            clientSocket.Connect(ip);

            

            string DataToSend = "";
            do
            {
                Console.Write("Data to send:");
                DataToSend = Console.ReadLine();
                clientSocket.Send(Encoding.ASCII.GetBytes(DataToSend));
            } while (DataToSend.Length > 0);
            clientSocket.Close();
            Console.ReadKey();
        }
    }
}
