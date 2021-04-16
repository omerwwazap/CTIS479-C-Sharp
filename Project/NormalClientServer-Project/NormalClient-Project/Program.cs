using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace NormalClient_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            string ipAdd = string.Empty;
            TcpClient client = new TcpClient();
            try
            {
                Console.Write("Enter Your IP address or leave blank for 127.0.0.1 (Port is  8000): ");
                ipAdd = Console.ReadLine();

                if (ipAdd == "")
                {
                    Console.WriteLine("Choosen Defult IP addres :]");
                    client = new TcpClient("127.0.0.1", 8080);
                }
                else
                {
                    Console.WriteLine("Choosen IP addres" + ipAdd);
                    client = new TcpClient(ipAdd, 8080);

                }

                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());

                string s = string.Empty;
                while (!s.Equals("Exit") || !s.Equals("exit"))
                {
                    Console.Write("Enter something to send: ");
                    s = Console.ReadLine();
                    Console.WriteLine();
                    writer.WriteLine(s);
                    writer.Flush();
                    string server_string = reader.ReadLine();
                    Console.WriteLine(server_string);
                }
                reader.Close();
                writer.Close();
                client.Close();
            }//try
            catch (FormatException e)
            {
                Console.WriteLine("Not an IP address closing the server.. :[");
                //Console.WriteLine(e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Not an IP address closing the server :[");
                //Console.WriteLine(e);
            }
            catch (IOException e)
            {
                Console.WriteLine("Client Connection has been interrupted, closing the server :[");
                //Console.WriteLine(e);
            }
        }//Main
    }
}
