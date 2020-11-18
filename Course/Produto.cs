using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Produto
    {
        // Em C#, para atributos privados,
        // por convenção, eles iniciam com 
        // underline seguido pela primeira letra
        // minúscula;
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // Property para o atributo nome
        // A palavra reservada "value" refere-se ao input(entrada)
        // Usuário
        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
        }

        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            _quantidade -= quantity;
        }
    }
}
