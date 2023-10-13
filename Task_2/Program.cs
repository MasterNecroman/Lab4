using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("192.168.1.1", 2000, "Windows Server", 100);
            Router router = new Router("192.168.1.2", 500, "RouterOS", 24);
            Workstation workstation = new Workstation("192.168.1.3", 1000, "Windows 10", 2);

            Console.WriteLine($"Server MaxConnections: {server.MaxConnections}");
            Console.WriteLine($"Router NumberOfPorts: {router.NumberOfPorts}");
            Console.WriteLine($"Workstation NumberOfScreens: {workstation.NumberOfScreens}");

            server.Connect(workstation);
            router.Connect(server);
            workstation.Connect(router);

          
            string[] data = new string[]
            {
                "Data 1 from server to workstation",
                "Data 2 from server to workstation",
                "Data 1 from router to server",
                "Data 2 from router to server",
                "Data 1 from workstation to router",
                "Data 2 from workstation to router"
            };

            SimulateDataTransmission(data, 0, server, router, workstation);

            Console.WriteLine($"\nServer OS: {server.OperatingSystem}");
            Console.WriteLine($"Router OS: {router.OperatingSystem}");
            Console.WriteLine($"Workstation OS: {workstation.OperatingSystem}");

            server.Disconnect(workstation);
            router.Disconnect(server);
            workstation.Disconnect(router);

            Console.ReadLine();
        }

        static void SimulateDataTransmission(string[] data, int index, Server server, Router router, Workstation workstation)
        {
            if (index >= data.Length)
                return;

            string fromDevice = data[index];
            string toDevice = data[index + 1];

            Console.WriteLine($"\nSimulating data transmission: {fromDevice}");
            server.SendData(workstation, fromDevice);
            router.SendData(server, fromDevice);
            workstation.SendData(router, fromDevice);

            SimulateDataTransmission(data, index + 2, server, router, workstation);
        }
    }
}
