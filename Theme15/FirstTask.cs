namespace Theme15
{
    internal class FirstTask
    {
        public async Task FirstMethod(int i)
        {
            await Task.Delay(500*i);
            Console.WriteLine($"Frist Method. ThreadID {Thread.CurrentThread.ManagedThreadId}");
        }
        public async Task SecondMethod(int i)
        {
            await Task.Delay(1100*i);
            Console.WriteLine($"Second Method. ThreadID {Thread.CurrentThread.ManagedThreadId}");
        }

        public async Task ThirdMethod(int i)
        {
            await Task.Delay(900 * i);
            Console.WriteLine($"Third Method. ThreadID {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
