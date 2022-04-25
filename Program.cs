using System;
using System.Globalization;

namespace Exercicio_1___property
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Nome = "TV";
            p.Preco = 1000;
            p.Quant = 4;

            Console.WriteLine(p);
        }
    }
}
