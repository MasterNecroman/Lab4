namespace Task_2
{
    public class Computer
    {
        public string IPAddress { get; set; }
        public double Power { get; set; }
        public string OperatingSystem { get; set; }

        public Computer(string ipAddress, double power, string operatingSystem)
        {
            IPAddress = ipAddress;
            Power = power;
            OperatingSystem = operatingSystem;
        }
    }
}