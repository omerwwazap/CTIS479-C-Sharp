using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace MultiTClient_Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Multi Thread Client Program";

            IPAddress ip_address = IPAddress.Parse("127.0.0.1"); //Default
            int port = 8080; //Default

            string ipAdd = string.Empty;
            try
            {
                Console.Write("Enter Your IP address or leave blank for 127.0.0.1 (Port is  8080): ");
                ipAdd = Console.ReadLine();

                if (ipAdd == "")
                {
                    Console.WriteLine("Invalid IP address entered. Using default IP :]");
                }
                else
                {
                    ip_address = IPAddress.Parse(ipAdd);
                }


            }//try
            catch (FormatException)
            {
                //Console.WriteLine("Invalid IP address entered. Using default IP of: " + ip_address.ToString());
            }
            try
            {
                //Console.WriteLine("Attempting to connect to server at IP address: {0} port: {1}", ip_address.ToString(), port);

                TcpClient client = new TcpClient(ip_address.ToString(), port);

                Console.WriteLine("Connection successful :]");

                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());

                string s = String.Empty;
                while (!s.Equals("Exit") || !s.Equals("exit"))
                {
                    Console.Write("Enter something to send: ");
                    s = Console.ReadLine();
                    Console.WriteLine();
                    writer.WriteLine(s);
                    writer.Flush();
                    if (!s.Equals("Exit") || !s.Equals("exit"))
                    {
                        String server_string = reader.ReadLine();
                        Console.WriteLine(server_string);
                    }
                }
                reader.Close();
                writer.Close();
                client.Close();
            }//rty
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }//Main
    }
}