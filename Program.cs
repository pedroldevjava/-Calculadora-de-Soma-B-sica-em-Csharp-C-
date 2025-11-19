using System;
using System.Globalization;

namespace matematicaSOMA {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite dois números:");

            int num1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int num2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int soma = num1 + num2;


            Console.WriteLine("Soma = " + soma);

        }
    }
}
