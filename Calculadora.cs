using System;

namespace CS_BasicCalculator
{
    class Calculadora
    {
        public void Run()
        {
            int operando1, operando2;

            ShowMenu("SOMAR [1]\nSUBTRAIR [2]\nMULTIPLICAR [3]\nDIVIDIR [4]");
            switch (Console.ReadLine())
            {
                case "1":
                    LerValores("somando", "somado", out operando1, out operando2);
                    Console.WriteLine($"\n    > {operando1} + {operando2} = {operando1 + operando2}");
                    break;
                case "2":
                    LerValores("subtraindo", "subtraído", out operando1, out operando2);
                    Console.WriteLine($"\n    > {operando1} - {operando2} = {operando1 - operando2}");
                    break;
                case "3":
                    LerValores("multiplicando", "multiplicado", out operando1, out operando2);
                    Console.WriteLine($"\n    > {operando1} * {operando2} = {operando1 * operando2}");
                    break;
                case "4":
                    LerValores("dividendo", "divisor", out operando1, out operando2);
                    Console.WriteLine($"\n    > {operando1} / {operando2} = {operando1 / operando2}, resto: {operando1 % operando2}");
                    break;
                default:
                    Console.WriteLine("\nOperação inválida...");
                    break;
            }
        }
        private void ShowMenu(string options)
        {
            Console.Clear();
            Console.Write($"CALCULADORA\n\n{options}\n\n    > ");
        }
        private void LerValores(string nome1, string nome2, out int operando1, out int operando2)
        {
            ShowMenu($"Digite o {nome1}: ");
            operando1 = Convert.ToInt32(Console.ReadLine());
            ShowMenu($"Digite o {nome2}: ");
            operando2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}