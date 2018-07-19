using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class Server2
    {
        static void Main(string[] args)
        {
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            serverSocket.Bind(ip);
            serverSocket.Listen(10);
            Socket socketForClient = serverSocket.Accept();

           
            int size;
            do
            {
                byte[] Buffer = new byte[socketForClient.SendBufferSize];
                size = socketForClient.Receive(Buffer);
                byte[] data = new byte[size];
                Array.Copy(Buffer, data, size);
                Console.WriteLine(Encoding.UTF8.GetString(data));

                Console.Write("enter text-1:");
                string text = Console.ReadLine();
                socketForClient.Send(Encoding.UTF8.GetBytes(text));
                if (text.Length > 0)
                {
                    //do
                    //{
                        socketForClient.Send(Encoding.UTF8.GetBytes(text));
                        Console.Write("enter text-2:");
                        text = Console.ReadLine();
                    //} while (text.Length > 0);
                }
            } while (size > 0);
           
            Console.WriteLine("client Disconnected");
            Console.ReadKey();
        }
    }
}
