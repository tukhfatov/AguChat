using AguChatServer;
using System.Net;
using System.Net.Sockets;

Console.WriteLine("AGU Server");

Console.Title = "AGU Server";

Server server = new Server(IPAddress.Parse("127.0.0.1"), 3000);


Console.WriteLine("INIT Listener");
server.InitListener();

int clientNumber = 1;

while (true)
{
    Console.WriteLine("Wating client");
    TcpClient client = server.tcpListener.AcceptTcpClient();

    ClientHandler ch = new ClientHandler(client, clientNumber);
    ch.Init(); // jana potok

    Console.WriteLine($"Client {clientNumber} connected");
    clientNumber++;
}










