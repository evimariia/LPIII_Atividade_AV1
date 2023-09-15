using DunderMifflin.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin
{
    internal class Pedido
    {
        private double numPedido;
        private string dataEntrega;
        private double desconto;
        private double quantidade;

        private IVendedor vendedor;
        private ICliente cliente;
        private IProduto produto;

        public Pedido(double numPedido, string dataEntrega, double desconto, double quantidade, IVendedor vendedor, ICliente cliente, IProduto produto)
        {
            this.numPedido = numPedido;
            this.dataEntrega = dataEntrega;
            this.desconto = desconto;
            this.quantidade = quantidade;
            this.vendedor = vendedor;
            this.cliente = cliente;
            this.produto = produto;
        }

        public double NumPedido { get => numPedido; set => numPedido = value; }
        public string DataEntrega { get => dataEntrega; set => dataEntrega = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        
        public double ValorPedido()
        {
            return (double)((produto.Valor * quantidade) * (1 - (desconto/100) ) );
        }

        public override string ToString()
        {
            return $"Número do Pedido: {numPedido}\n" +
                   $"Vendedor -------------\n{vendedor}\n"+
                   $"Cliente --------------\n{cliente}\n"+
                   $"Produto: {produto}\n" +
                   $"Valor do Pedido: {ValorPedido()}\n" +
                   $"Data de Entrega: {dataEntrega}\n" +
                   $"Desconto: R${desconto}\n" +
                   $"Quantidade: {quantidade} pacote(s)";
        }

    }
}
