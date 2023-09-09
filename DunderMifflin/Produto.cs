using DunderMifflin.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin
{
	class Produto : IProduto
	{
        private string descricao;
        private double valor;

        public Produto(string descricao, double valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }

        public string? Descricao { get => descricao; set => descricao = value; }
        public double? Valor { get => valor; set => valor = (double)value; }
    }
}
