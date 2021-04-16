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
            Console.Title = "Client Program";
            string ipAdd = string.Empty;
            TcpClient client = new TcpClient();

            IPAddress ip_address_def = IPAddress.Parse("127.0.0.1"); //Default
            int port = 8080; //Default
            try
            {
                Console.Write("Enter Your IP address or leave blank for 127.0.0.1 (Port is  8080): ");
                ipAdd = Console.ReadLine();

                if (ipAdd == "")
                {
                    Console.WriteLine("Choosen Defult IP addres :]");
                    client = new TcpClient(ip_address_def.ToString(), port);
                }
                else
                {
                    Console.WriteLine("Choosen IP addres" + ipAdd);
                    client = new TcpClient(ipAdd, port);
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
