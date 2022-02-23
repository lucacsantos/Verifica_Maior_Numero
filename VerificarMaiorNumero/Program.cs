using System;

namespace VerificarMaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro número:");
            float num3 = float.Parse(Console.ReadLine());

            Maior(num1, num2, num3);
        }

        public static float Maior(float num1, float num2, float num3)
        {
            float maior;

            if (num1 > num2 && num1 > num3)
            {
                maior = num1;
                Console.WriteLine("o maior é: {0}", maior);
                return maior;

            }
            else if (num2 > num1 && num2 > num3)
            {
                maior = num2;
                Console.WriteLine("o maior é: {0}", maior);
                return maior;
            }
            else
            {
                maior = num3;
                Console.WriteLine("o maior é: {0}", maior);
            }
            return maior;
        }
    }
}