using System;

namespace CS_BasicCalculator
{
    class Program
    {
        static void Main()
        {
            Calculadora calculadora = new Calculadora();

            while (true)
            {
                calculadora.Run();
                
                Console.Write("\nFazer outra operação? Senão ESC... ");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            Console.Write("\n\nFim do programa...");
            Console.ReadKey(false);
        }
    }
}