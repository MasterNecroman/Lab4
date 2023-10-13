namespace Task_2
{
    public interface IConnectable
    {
        void Connect(Computer computer);
        void Disconnect(Computer computer);
        void SendData(Computer computer, string data);
        void ReceiveData(string data);
    }
}