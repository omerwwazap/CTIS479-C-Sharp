using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace NormalServer_Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TcpListener listener = null;
            string ipAdd = string.Empty;
            try
            {
                Console.Write("Enter Your IP address or leave blank for 127.0.0.1 (Port is 8000): ");
                ipAdd = Console.ReadLine();

                if (ipAdd == "")
                {
                    Console.WriteLine("Choosen Defult IP addres :]");
                    listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                    listener.Start();
                }
                else
                {
                    Console.WriteLine("Choosen IP addres" + ipAdd);
                    listener = new TcpListener(IPAddress.Parse(ipAdd), 8080);
                    listener.Start();
                }

                Console.WriteLine("EchoServer started...");

                while (true)
                {
                    Console.WriteLine("Waiting for client connections... :]");

                    TcpClient client = listener.AcceptTcpClient();

                    Console.WriteLine("Accepted new client connection... :]");

                    StreamReader reader = new StreamReader(client.GetStream());
                    StreamWriter writer = new StreamWriter(client.GetStream());

                    string s = string.Empty;
                    while (!(s = reader.ReadLine()).Equals("Exit") || s.Equals("exit") || (s == null))
                    {
                        Console.WriteLine("From client -> " + s);
                        writer.WriteLine("From server -> " + s);
                        writer.Flush();
                    }
                    reader.Close();
                    writer.Close();
                    client.Close();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Not an IP address closing the server... :(");
                //Console.WriteLine(e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Not an IP address closing the server... :(");
                //Console.WriteLine(e);
            }
            catch (IOException e)
            {
                Console.WriteLine("Client Connection has been interrupted, closing the server");
                //Console.WriteLine(e);
            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                }
            }
        }
    }
}