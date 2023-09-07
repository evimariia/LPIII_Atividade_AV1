using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin
{
    internal class Vendedor
    {
        private string nome;
        private double cadastro;
        private string telefone;

        public Vendedor(string nome, double cadastro, string telefone)
        {
            this.nome = nome;
            this.cadastro = cadastro;
            this.telefone = telefone;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Cadastro { get => cadastro; set => cadastro = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public override string ToString()
        {
            return $"Nome do Vendedor: {nome}\n" +
                   $"Cadastro do Vendedor: {cadastro}\n" +
                   $"Telefone do Vendedor: {telefone}\n";
        }
    }
}
