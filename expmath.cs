namespace testmath
{
    public class Expmath
    {
        public int Times;
        public Expmath(int times)
        {
            Times = times;
            Console.WriteLine("inconstructor:" + Times);
        }

        public int Run()
        {
            double ss = 0.0;
            Console.WriteLine("show times:" + Times);
            for (int f = 0; f < Times; f++)
            {
                for (int s = 0; s < 100; s++)
                    for (int j = 0; j < 1000; j++)
                    {
                        for (int i = 0; i < 1000; i++)
                        {
                            double a = 1.3;
                            double y = (double)(i);
                            ss = ss + Math.Exp(a / y);
                        }

                    }
            }
            return Times;

        }
        public async Task<int> RunAsync()
        {
            double ss = 0.0;
            Console.WriteLine("show times:" + Times);
            for (int f = 0; f < Times; f++)
            {
                for (int s = 0; s < 100; s++)
                    for (int j = 0; j < 1000; j++)
                    {
                        for (int i = 0; i < 1000; i++)
                        {
                            double a = 1.3;
                            double y = (double)(i);
                            ss = ss + Math.Exp(a / y);
                        }

                    }
            }
            return Times;

        }
    }
}