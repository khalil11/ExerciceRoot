public class Program
{

    public static void CalculeRacine(double number, int root)
    {
        if (number >= 1.00 && root >= 1)
        {
            double result = 1;
            double nth = 1;
            while (true)
            {
                result = 1;
                for (int i = 0; i < root; i++)
                {
                    result *= nth;
                }
                if (result >= number)
                    break;
                else
                    nth += 0.0001;
            }
            Console.WriteLine($"valeur approximative {nth}  ≈  {(int)nth}");

        }
        else
        {
            Console.WriteLine("Erreur Parametre");
        }

    }
    private static void Main(string[] args)
    {
        CalculeRacine(16, 4);
        CalculeRacine(8, 3);
        CalculeRacine(10, 2);
        CalculeRacine(8, 3);
        CalculeRacine(1, 1);
        CalculeRacine(25, 2);
        CalculeRacine(81, 4);
    }
}