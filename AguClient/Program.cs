// See https://aka.ms/new-console-template for more information
using AguClient;
using System.Net;

Console.WriteLine("AGU Client");

Console.WriteLine("Atyndy jaz:");
Console.Title = Console.ReadLine();

Client client = new Client(IPAddress.Parse("127.0.0.1"), 3000);

client.InitConnection();

client.InitData();


while (true)
{
    string message = Console.ReadLine();

    client.writer.WriteLine(message);
    client.writer.Flush();

    string messageFromServer = client.reader.ReadLine();

    Console.WriteLine("Server: "+ messageFromServer);
}

client.writer.Close();
client.reader.Close();
client.client.Close();


