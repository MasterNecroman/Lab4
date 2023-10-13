using System;

namespace Task_2
{
    public class Server : Computer, IConnectable
    {
        
        public int MaxConnections { get; set; }

        public Server(string ipAddress, double power, string operatingSystem, int maxConnections)
            : base(ipAddress, power, operatingSystem)
        {
            MaxConnections = maxConnections;
        }

        public void Connect(Computer computer)
        {
            Console.WriteLine($"Connected {computer.IPAddress} to server {IPAddress}");
        }

        public void Disconnect(Computer computer)
        {
            Console.WriteLine($"Disconnected {computer.IPAddress} from server {IPAddress}");
        }

        public void SendData(Computer computer, string data)
        {
            Console.WriteLine($"Data sent from server {IPAddress} to computer {computer.IPAddress}: {data}");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine($"Data received on server {IPAddress}: {data}");
        }
    }
}