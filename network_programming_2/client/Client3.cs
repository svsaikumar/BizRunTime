using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    class Client3
    {
        static void Main(string[] args)
        {
            TcpClient socketForServer;
            bool status = true;
            try
            {
                socketForServer = new TcpClient("localhost", 8100);
                Console.WriteLine("Connected to Server");
            }
            catch
            {
                Console.WriteLine("Failed to Connect to server{0}:999", "localhost");
                return;
            }
            NetworkStream networkStream = socketForServer.GetStream();
            StreamReader streamreader = new StreamReader(networkStream);
            StreamWriter streamwriter = new StreamWriter(networkStream);
            try
            {
                string clientmessage = "";
                string servermessage = "";
                while (status)
                {
                    Console.Write("Client:");
                    clientmessage = Console.ReadLine();
                   
                    
                    streamwriter.WriteLine(clientmessage);
                    streamwriter.Flush();
                    servermessage = streamreader.ReadLine();
                    Console.WriteLine("Server:" + servermessage);
                 
                }
            }
            catch
            {
                Console.WriteLine("Exception reading from the server");
            }
            streamreader.Close();
            networkStream.Close();
            streamwriter.Close();
        }
    }
}
