using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace servers
{
    class server1
    {
        static bool flag = true;
        static string str = "";
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            socket.Bind(iPEnd);
            socket.Listen(10);
            Console.WriteLine("server");
            Dictionary<int, Socket> clients = new Dictionary<int, Socket>();
            int count = 0;

            while (true)
            {
                count++;
                Socket socketForClient = socket.Accept();
                byte[] buffer = new byte[socketForClient.SendBufferSize];
                clients.Add(count, socketForClient);
                server1 s = new server1();

                Task t1 = new Task(() => s.RecieveFromClient(socketForClient, buffer,clients,(count-1)));
                t1.Start();              
            }
        }
        public void RecieveFromClient(Socket socket, byte[] buffer, Dictionary<int, Socket> clients, int count)
        {
            
            int length;
           
            string text = "MESSAGE";
            do
            {
                length = socket.Receive(buffer);
                flag = true;
                byte[] br = new byte[length];
                Array.Copy(buffer, br, length);
                str = Encoding.ASCII.GetString(br);
                Console.WriteLine("From Client: " + str);
                if (str.Contains("TO:ALL"))
                {                   
                    int start = str.IndexOf(text) +text.Length;
                    string tosend = str.Substring(start-1);
                    foreach (KeyValuePair<int, Socket> kv in clients)
                    {
                        Socket socket1 = kv.Value;
                        byte[] send = Encoding.ASCII.GetBytes(tosend);
                        socket1.Send(send);
                    }
                }
                if (str.Contains("TO:EXCEPT ME"))
                {                 
                    int start = str.IndexOf(text) + text.Length;
                    string tosend = str.Substring(start-1);
                    foreach (KeyValuePair<int, Socket> kv in clients)
                    {
                        if(count != kv.Key)
                        {
                            Socket socket1 = kv.Value;
                            byte[] send = Encoding.ASCII.GetBytes(tosend);
                            socket1.Send(send);
                        }                                           
                    }
                }

                if (str.Contains("TO:SELF"))
                {
                    int start = str.IndexOf(text) + text.Length;
                    string tosend = str.Substring(start-1);
                    foreach (KeyValuePair<int, Socket> kv in clients)
                    {
                        if (count == kv.Key)
                        {
                            Socket socket1 = kv.Value;
                            byte[] send = Encoding.ASCII.GetBytes(tosend);
                            socket1.Send(send);
                        }                       
                    }
                }
            } while (length > 0);
        }
       
    }
}