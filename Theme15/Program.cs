namespace Theme15
{
    internal class Program
    {
        public static int finish = 0;
        static async Task Main(string[] args)
        {

            #region first task
            Console.WriteLine("The beginning of the first task");

            List<Task> tasks = new List<Task>();
            FirstTask firstTask = new FirstTask();

            for (int i = 0; i < 3; i++)
            {
                tasks.Add(firstTask.FirstMethod(i));
                tasks.Add(firstTask.SecondMethod(i));
                tasks.Add(firstTask.ThirdMethod(i));
            }
            await Task.WhenAll(tasks);

            Console.WriteLine("The end of the first task");

            #endregion

            #region Task from video

            Console.WriteLine("\n\n\n");
            Console.WriteLine("The beginning of the second task (from the video)");

            Parallel.For(1_000_000_000, 2_000_000_000, SecondTask.CheckMultiples);
            Console.WriteLine($"The number of multiples between 1_000_000_000 and 2_000_000_000 is {SecondTask.Multiples}");

            Console.WriteLine("The end of the second task (from the video)s");
            Console.ReadLine();
            #endregion

        }



    }
}