namespace Task_3
{
    class Road
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int NumberOfLanes { get; set; }
        public int CurrentTrafficLevel { get; set; }

        public Road(double length, double width, int numberOfLanes, int currentTrafficLevel)
        {
            Length = length;
            Width = width;
            NumberOfLanes = numberOfLanes;
            CurrentTrafficLevel = currentTrafficLevel;
        }
    }
}