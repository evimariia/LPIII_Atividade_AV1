using DunderMifflin.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin
{
    class Cliente : ICliente
    {
        private double cadastro;
        private string nome;
        private string telefone;
        private string email;
        private string endereco;

        public Cliente(double cadastro, string nome, string telefone, string email, string endereco)
        {
            this.cadastro = cadastro;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.endereco = endereco;
        }

        public double? Cadastro { get => cadastro; set => cadastro = (double)value; }
        public string? Nome { get => nome; set => nome = value; }
        public string? Telefone { get => telefone; set => telefone = value; }
        public string? Email { get => email; set => email = value; }
        public string? Endereco { get => endereco; set => endereco = value; }

        public override string ToString()
        {
            return $"Nome: {nome}\n" +
                   $"Cadastro: {cadastro}\n" +
                   $"Telefone: {telefone}\n" +
                   $"Email: {email}\n" +
                   $"Endereço: {endereco}\n";
        }
    }
}
