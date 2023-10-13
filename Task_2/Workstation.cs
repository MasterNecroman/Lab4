using System;

namespace Task_2
{
    public class Workstation : Computer, IConnectable
    {
        public int NumberOfScreens { get; set; }

        public Workstation(string ipAddress, double power, string operatingSystem, int numberOfScreens)
            : base(ipAddress, power, operatingSystem)
        {
            NumberOfScreens = numberOfScreens;
        }

        public void Connect(Computer computer)
        {
            Console.WriteLine($"Connected to a computer with IP address {computer.IPAddress}");
        }

        public void Disconnect(Computer computer)
        {
            Console.WriteLine($"Disconnected from a computer with IP address {computer.IPAddress}");
        }

        public void SendData(Computer computer, string data)
        {
            Console.WriteLine($"Sent data to a computer with IP address {computer.IPAddress}: {data}");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine($"Received data: {data}");
        }
    }
}