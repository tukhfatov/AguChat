using System.Net.Sockets;

namespace AguChatServer
{
    public class ClientHandler
    {

        private TcpClient _tcpClient;


        // write and read messages
        public NetworkStream networkStream;
        public StreamReader reader;
        public StreamWriter writer;
        private int clientNumber;


        public ClientHandler(TcpClient tcpClient, int clientNumber) 
        {
            _tcpClient = tcpClient;
            this.clientNumber = clientNumber;
        }

        public void Init()
        {
            Thread t = new Thread(Start);
            t.Start();
        }


        public void Start()
        {
            Console.WriteLine(_tcpClient.Connected);
            networkStream = _tcpClient.GetStream();

            reader = new StreamReader(networkStream);
            writer = new StreamWriter(networkStream);

            while (true)
            {
                if (_tcpClient.Connected)
                {

                    string messageFromClient = reader.ReadLine();

                    Console.WriteLine($"Client {clientNumber}: " + messageFromClient);

                    Console.WriteLine($"Please type message for client {clientNumber}:");

                    string messageToClient = Console.ReadLine();

                    writer.WriteLine(messageToClient);
                    writer.Flush();
                }
            }
        }
    }
}
