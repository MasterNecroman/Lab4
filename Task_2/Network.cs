using System;
using System.Collections.Generic;

namespace Task_2
{
    public class Network
    {
        private List<Computer> computers = new List<Computer>();

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
            Console.WriteLine($"Computer with IP address {computer.IPAddress} added to the network.");
        }

        public void RemoveComputer(Computer computer)
        {
            computers.Remove(computer);
            Console.WriteLine($"Computer with IP address {computer.IPAddress} removed from the network.");
        }

        public void ConnectComputers(Computer computer1, Computer computer2)
        {
            Console.WriteLine($"Connected {computer1.IPAddress} to {computer2.IPAddress}.");
        }

        public void DisconnectComputers(Computer computer1, Computer computer2)
        {
            Console.WriteLine($"Disconnected {computer1.IPAddress} from {computer2.IPAddress}.");
        }

        public void SendData(Computer sender, Computer receiver, string data)
        {
            Console.WriteLine($"Data sent from {sender.IPAddress} to {receiver.IPAddress}: {data}");
        }

        public void ReceiveData(Computer receiver, string data)
        {
            Console.WriteLine($"Data received by {receiver.IPAddress}: {data}");
        }
    }
}