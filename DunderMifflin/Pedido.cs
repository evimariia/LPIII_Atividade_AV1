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
        private double valorPedido;
        private string dataEntrega;
        private string dataPedido;
        private double desconto;
        private string formaPagamento;
        private string produto;
        private double quantidade;
        private double valorUnitario;

        private Vendedor vendedor;
        private Cliente cliente;

        public Pedido(double numPedido, double valorPedido, string dataEntrega, string dataPedido, 
            double desconto, string formaPagamento, string produto, double quantidade, double valorUnitario, Vendedor vendedor)
        {
            this.numPedido = numPedido;
            this.valorPedido = valorPedido;
            this.dataEntrega = dataEntrega;
            this.dataPedido = dataPedido;
            this.desconto = desconto;
            this.formaPagamento = formaPagamento;
            this.produto = produto;
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;

            this.vendedor = vendedor;
        }

        public double NumPedido { get => numPedido; set => numPedido = value; }
        public double ValorPedido { get => valorPedido; set => valorPedido = value; }
        public string DataEntrega { get => dataEntrega; set => dataEntrega = value; }
        public string DataPedido { get => dataPedido; set => dataPedido = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
        public string Produto { get => produto; set => produto = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }

        public void setValorPedido()
        {
            valorPedido = (valorUnitario*quantidade)-desconto;
        }

        public override string ToString()
        {
            return $"Número do Pedido: {numPedido}\n" +
                   $"Vendedor-------------\n {vendedor}\n"+
                   $"Cliente-------------\n {cliente}\n"+
                   $"Valor do Pedido: {valorPedido}\n" +
                   $"Data de Entrega: {dataEntrega}\n" +
                   $"Data do Pedido: {dataPedido}\n" +
                   $"Desconto: {desconto}\n" +
                   $"Forma de Pagamento: {formaPagamento}\n" +
                   $"Produto: {produto}\n" +
                   $"Quantidade: {quantidade}\n" +
                   $"Valor Unitário: {valorUnitario}\n";
        }

    }
}
