/*
Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos. Armazene os N produtos em um vetor.
Em seguida, mostrar o preço médio dos produtos.
*/
using System;
using System.Globalization;

namespace PrecoProduto {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            double precoMedio = sum / n;

            Console.WriteLine("Preço médio dos produtos: " + precoMedio.ToString("F2", CultureInfo.InvariantCulture ));




        }
    }
}

