using System;

namespace Task_2
{
    public class Router : Computer, IConnectable
    {
        public int NumberOfPorts { get; set; }

        public Router(string ipAddress, double power, string operatingSystem, int numberOfPorts)
            : base(ipAddress, power, operatingSystem)
        {
            NumberOfPorts = numberOfPorts;
        }

        public void Connect(Computer computer)
        {
            Console.WriteLine($"Connected to the computer with IP address {computer.IPAddress}");
        }

        public void Disconnect(Computer computer)
        {
            Console.WriteLine($"Disconnected from the computer with IP address {computer.IPAddress}");
        }

        public void SendData(Computer computer, string data)
        {
            Console.WriteLine($"Sent data to the computer with IP address {computer.IPAddress}: {data}");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine($"Received data: {data}");
        }

        public void RouteData(string data)
        {
            Console.WriteLine($"Routing data: {data}");
        }
    }
}