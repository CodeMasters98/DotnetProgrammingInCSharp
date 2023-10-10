namespace MultiTreadInCSharp
{
    #region Events
    class EventPublisher
    {
        public event Action<int> MyEvent;

        public void RaiseEvent(int data)
        {
            MyEvent?.Invoke(data);
        }
    }
    #endregion

    class Program
    {
        #region delegate
        delegate void MyCallback(int value);

        static void ExecuteCallback(MyCallback callback, int data)
        {
            callback(data);
        }

        static void MyCallbackFunction(int value)
        {
            Console.WriteLine($"Callback received: {value}");
        }
        #endregion


        static void Main(string[] args)
        {
            //Callback By Delegate
            ExecuteCallback(MyCallbackFunction, 42);

            //Callback By Event
            var publisher = new EventPublisher();
            publisher.MyEvent += value => Console.WriteLine($"Event received: {value}");
            publisher.RaiseEvent(123);
        }
    }
}