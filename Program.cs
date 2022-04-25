using System;
using System.Globalization;

namespace Exercicio_1___property
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Nome = "TV";
            p1.Preco = 1000;
            p1.Quant = 4;

            Console.WriteLine(p1);

            Produto p2 = new Produto("Geladeira", 2000, 7);
            Console.WriteLine(p2);
        }
    }
}
