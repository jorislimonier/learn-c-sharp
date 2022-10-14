namespace EulerProblems
{
    class Euler
    {
        static int One()
        {
            int total = 0;

            // Loop until 1000
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                };
            };
            return total;
        }

        static int Two()
        {
            int res = -1;
            int nextFib = 0;

            List<int> fibList = new List<int> { 0, 1 };
            while (nextFib < 400000)
            {
                int nbElem = fibList.Count();
                int penLastFib = fibList.ElementAt(nbElem - 2);
                int lastFib = fibList.ElementAt(nbElem - 1);
                nextFib = penLastFib + lastFib;
                fibList.Add(nextFib);
                System.Console.WriteLine(lastFib);
            }

            
            return res;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(Two());
        }

    }

}