using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ConsoleChat
{
    public class Client
    {
        private string ClientName;
        private string ServerIPAddress;
        private string ServerConnectionPort;
        private TcpClient ConnectionClient;

        public Client(TcpClient clientConfiguration)
        {
            this.ConnectionClient = clientConfiguration;
            Console.WriteLine(ConnectionClient.Client.LocalEndPoint.ToString());
            this.ServerIPAddress = ConnectionClient.Client.LocalEndPoint.ToString().Substring(0,ConnectionClient.Client.LocalEndPoint.ToString().IndexOf(":"));
            this.ServerConnectionPort = ConnectionClient.Client.LocalEndPoint.ToString().Substring(ConnectionClient.Client.LocalEndPoint.ToString().IndexOf(":")+1);
        }

        public void Initialize()
        {
            Console.WriteLine($"Connected to {ServerIPAddress} on port {ServerConnectionPort}. ");
            
           
            while (true)
            {
                //Listen();
                ListenLocal();
            }

        }

        public void Read(string message)
        {
            Console.WriteLine(message);
        }

        public async void Listen()
        {
            //ConnectionClient = await Host.AcceptTcpClientAsync();
            using (var sr = new StreamReader(ConnectionClient.GetStream()))
            {
                var message = await sr.ReadLineAsync();
                Read(message);
            }
        }

        public void ListenLocal()
        {
            var message = Console.ReadLine();
            Send(message);
        }

        public async void Send(string message)
        {
            ConnectionClient = new TcpClient("localhost", 8080);
            using (var sw = new StreamWriter(ConnectionClient.GetStream()))
            {
                await sw.WriteLineAsync(message);
            }
            //Console.WriteLine(message);
            /*
            using (var sw = new StreamWriter(Client.GetStream()))
            {
                sw.WriteLine(message);
            }*/
        }
    }
}
