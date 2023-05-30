namespace Prak1._1_C_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            Console.WriteLine("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x < -1)

            {
                y = (x - 1) / (x + 1);
            }
            else
            if (x < 20)
            {
                for (int i = -1; i <= x; i++)
                {
                    y += 4 - (i / 2);
                }

            }

            else 
            {

                y = 1;

                for (int i = 20; i <= x; i++)
                {
                    y *= 0.5 * (i / 3.0 + 1.0);
                }
            };

            Console.WriteLine(y);
        }
    }
}