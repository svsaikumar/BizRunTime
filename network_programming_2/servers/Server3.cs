using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace servers
{
    class Server3
    {
        public static void Main()
        {
            bool status = true;
            string servermessage = "";
            string clientmessage = "";
            try
            {   
                TcpListener tcpListener = new TcpListener(8100);


                tcpListener.Start();
                Console.WriteLine("Server Started");


                Socket socketForClient = tcpListener.AcceptSocket();
                Console.WriteLine("Client Connected");


                NetworkStream networkStream = new NetworkStream(socketForClient);
                StreamWriter streamwriter = new StreamWriter(networkStream);
                StreamReader streamreader = new StreamReader(networkStream);


                while (status)
                {
                    if (socketForClient.Connected)
                    {
                        servermessage = streamreader.ReadLine();
                        Console.WriteLine("Client:" + servermessage);
                        Console.Write("Server:");
                        clientmessage = Console.ReadLine();
                        streamwriter.WriteLine(clientmessage);
                        streamwriter.Flush();
                    }
                }
                streamreader.Close();
                networkStream.Close();
                streamwriter.Close();
                socketForClient.Close();
                Console.WriteLine("Exiting");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
