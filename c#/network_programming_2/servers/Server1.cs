using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace servers
{
    class Server1
    {
        static void Main(string[] args)
        {
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            serverSocket.Bind(ip);
            serverSocket.Listen(0);
            Socket socketForClient = serverSocket.Accept();

            byte[] Buffer = new byte[socketForClient.SendBufferSize];

            int size;
            do
            {
                size = socketForClient.Receive(Buffer);
                byte[] data = new byte[size];
                Array.Copy(Buffer, data, size);
                Console.WriteLine(Encoding.UTF8.GetString(data));
            } while (size > 0);
            Console.WriteLine("client Disconnected");
            Console.ReadKey();
        }
    }
}
