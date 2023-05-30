namespace Prak1_C_sharp
{ 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть число:");
        string input = Console.ReadLine();

        int minDigit = int.MaxValue;
        int maxDigit = int.MinValue;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                int digit = c - '0';
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
            }
        }

        Console.WriteLine($"Мiнiмальна цифра: {minDigit}");
        Console.WriteLine($"Максимальна цифра: {maxDigit}");

        Console.ReadLine();
    }
}
}