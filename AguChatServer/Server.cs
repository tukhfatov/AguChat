using System.Net;
using System.Net.Sockets;

namespace AguChatServer
{
    public class Server
    {
        public IPAddress ipAddress;
        public int port;

        // network layer
        public TcpListener tcpListener; 

        public Server(IPAddress ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;
        }

        public void InitListener()
        {
            tcpListener = new TcpListener(ipAddress, port);
            tcpListener.Start();
        }

       


    }
}
