using System.Net;
using System.Net.Sockets;

namespace AguClient
{
    public class Client
    {

        public IPAddress IpAddress;
        public int Port;

        public TcpClient client;

        public NetworkStream networkStream;
        public StreamReader reader;
        public StreamWriter writer;

        public Client(IPAddress ipAddress, int port)
        {
            IpAddress = ipAddress;
            Port = port;
        }

        public void InitConnection()
        {
            client = new TcpClient(IpAddress.ToString(), Port);
        }

        public void InitData()
        {
            networkStream = client.GetStream();

            reader = new StreamReader(networkStream);
            writer = new StreamWriter(networkStream);
        }
    }
}
