using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_1___property
{
    class Produto
    {
        private string _nome;
        private int _quant;
        private double _preco;
        /// <summary>
        /// AUTOPROPERTY
        /// pode ser escrito diretamente como:
        /// 
        /// public double Preco { get; private set; }
        /// 
        /// essa implementação dispensa a anterior. Porém, a autoproperty só funciona caso as 
        /// operações básicas não possuam uma lógica própria, como if, etc.
        /// </summary>

        public Produto() { }

        public Produto(string nome, double preco, int quant)
        {
            _nome = nome;
            _preco = preco;
            _quant = quant;
        }

        //PROPERTIES
        //As properties podem ser usadas dentro da própria class.
        //Elas mantêm o encapsulanento e facilitam a escrita do cod. utilizam o padrão da sintaxe do c#.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                    _preco = value;
            }
        }

        public int Quant
        {
            get { return _quant; }
            set
            {
                if (value >= 0)
                    _quant = value;
            }
        }
        ////////////////////////////////////////////////////////////////////
        public double ValorTotalEmEstoque()
        {
            return Preco * Quant;
        }

        public void AdicionarProdutos(int i)
        {
            _quant += i;
        }

        public void RemoverProdutos(int i)
        {
            _quant -= i;
        }

        public override string ToString()
        {
            return Nome + ", custando $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", com " + Quant + " unidades em estoque.";
        }

    }
}
