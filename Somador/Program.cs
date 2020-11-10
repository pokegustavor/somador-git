using System;

namespace Somador {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos números você quer somar? " );
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Então somaremos {N} números");

            int Soma = 0;
            for (int L = 1 ; L <= N; L++) {
                Console.Write($"Número {L}:" );
                int R = int.Parse(Console.ReadLine());
                Soma += R;
            }
            Console.WriteLine($"A soma dos números é: {Soma}");

        }
    }
}
