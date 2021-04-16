using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MultiTServer_Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TcpListener listener = null;
            int port = 8080;
            try
            {
                //Unlike our Single Threaded Server IPAddress.Any will listen to all Netwotk Interfaces and their Ip address
                //Ex. Wifi Module is 192.168.1.2 and Ethernet Interface is 172.0.0.1 
                //IPAddress.Any will listen to both
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
                Console.WriteLine("Multi Threaded Server Has Started... :]");
                while (true)
                {
                    Console.WriteLine("Waiting for client connections... :]");
                    TcpClient client = listener.AcceptTcpClient();

                    Console.WriteLine("Whoa a new client connection :]");

                    //Start a new Thread for every new client connection
                    Thread t = new Thread(ProcessClientRequests);

                    t.Start(client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (listener != null)
                {
                    listener.Stop();
                }
            }
        }//Main()

        private static void ProcessClientRequests(object argument)
        {
            //Same Code Taken From Single Threaded Server Program
            TcpClient client = (TcpClient)argument;
            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                string s = String.Empty;
                while (!(s = reader.ReadLine()).Equals("Exit") || s.Equals("exit") || (s == null))
                {
                    Console.WriteLine("From client -> " + s);
                    writer.WriteLine("From server -> " + s);
                    Console.WriteLine("Client connected with IP {0}", client.Client.LocalEndPoint); //Show Connected IP
                    writer.Flush();
                }
                reader.Close();
                writer.Close();
                client.Close();
                Console.WriteLine("Client connection terminated :[");
            }//rty
            // Have only one execption unlike the Single Threaded Server Program becasue we dont have any IP inputs here
            catch (IOException)
            {
                Console.WriteLine("Problem with client communication :[");
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }//ProcessClientRequests()
    }
}