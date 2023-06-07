namespace Theme15
{
    internal static class SecondTask
    {
        static int multiples = 0;

        public static int Multiples
        {
            get => multiples;
        }
        public static void CheckMultiples(int n)
        {
            if (n < 10)
                return;

            int summ = 0;
            int lastNum = n % 10;
            if (lastNum == 0)
            {
                Interlocked.Increment(ref multiples);
                return;
            }
            while (n > 0)
            {
                summ += n % 10;
                n /= 10;
            }
            if (summ % lastNum == 0)
                Interlocked.Increment(ref multiples);
        }
    }
}
