using System.Net.Sockets;

namespace ConsoleChat
{
    public class ClientConfiguartion : IConfigurable
    {
        public string ServerIPAddress = "127.0.0.1";
        public int ServerConnectionPort = 8080;

        public void ClientConfiguration()
        {
            this.ServerIPAddress = "127.0.0.1";
            this.ServerConnectionPort = 8080;
        }

        public dynamic Initialize()
        {
            return new TcpClient(this.ServerIPAddress, this.ServerConnectionPort);
        }

        public IConfigurable Load()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}