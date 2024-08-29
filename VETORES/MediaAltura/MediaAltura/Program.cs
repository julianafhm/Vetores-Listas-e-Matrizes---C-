/* Fazer um programa para ler um número inteiro N e a altura de N pessoas.
 Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.
*/

using System;
using System.Globalization;
using System.Numerics;

namespace MediaAltura {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double media = sum / n;

            Console.WriteLine("Média das alturas = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}