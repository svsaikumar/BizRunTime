using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace servers
{
    class server
    {
        static bool flag = true;
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
                server s = new server();

                Task t1 = new Task(() => s.RecieveFromClient(socketForClient, buffer));
                t1.Start();
                Task t2 = new Task(() => s.SendToClient(clients));
                if (flag)
                    t2.Start();
            }
        }
        public void RecieveFromClient(Socket socket, byte[] buffer)
        {
            string str = "";
            int length;
            do
            {
                length = socket.Receive(buffer);
                flag = true;
                byte[] br = new byte[length];
                Array.Copy(buffer, br, length);
                str = Encoding.ASCII.GetString(br);
                Console.WriteLine("From Client: " + str);
            } while (length > 0);
        }
        public void SendToClient(Dictionary<int, Socket> clients)
        {
            flag = false;
            while (true)
            {
                loop1:
                string s1 = Console.ReadLine();
                string s2 = s1;
                if (s2.Length > 0)
                {
                    loop2:
                    Console.Write("enter client number:");
                    int number = Convert.ToInt16(Console.ReadLine());
                    if (number == 0)
                    {

                        foreach (KeyValuePair<int, Socket> kv in clients)
                        {
                            Socket socket = kv.Value;
                            byte[] send = Encoding.ASCII.GetBytes(s2);
                            socket.Send(send);
                        }
                        goto loop1;
                    }
                    else if (number > clients.Count)
                    {

                        Console.WriteLine("out of range.please enter correct range:");
                        goto loop2;
                    }
                    else if ((number) <= clients.Count && number != 0)
                    {

                        var element = clients.ElementAt(number - 1);
                        Socket socket = element.Value;
                        byte[] send = Encoding.ASCII.GetBytes(s1);
                        socket.Send(send);
                    }
                }
            }

        }
    }
}