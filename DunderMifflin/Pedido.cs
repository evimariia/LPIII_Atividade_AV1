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
        private string nomeCliente;
        private double cadastroCliente;
        private string telefoneCliente;
        private string emailCliente;
        private string enderecoCliente;
        private double valorPedido;
        private string dataEntrega;
        private string dataPedido;
        private double desconto;
        private string formaPagamento;
        private string produto;
        private double quantidade;
        private double valorUnitario;

        private Vendedor vendedor;

        public Pedido(double numPedido, string nomeCliente, double cadastroCliente, string telefoneCliente, 
            string emailCliente, string enderecoCliente, double valorPedido, string dataEntrega, string dataPedido, 
            double desconto, string formaPagamento, string produto, double quantidade, double valorUnitario, Vendedor vendedor)
        {
            this.numPedido = numPedido;
            this.nomeCliente = nomeCliente;
            this.cadastroCliente = cadastroCliente;
            this.telefoneCliente = telefoneCliente;
            this.emailCliente = emailCliente;
            this.enderecoCliente = enderecoCliente;
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
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public double CadastroCliente { get => cadastroCliente; set => cadastroCliente = value; }
        public string TelefoneCliente { get => telefoneCliente; set => telefoneCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string EnderecoCliente { get => enderecoCliente; set => enderecoCliente = value; }
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
                   $"Vendedor: {vendedor}\n"+
                   $"Nome do Cliente: {nomeCliente}\n" +
                   $"Cadastro do Cliente: {cadastroCliente}\n" +
                   $"Telefone do Cliente: {telefoneCliente}\n" +
                   $"Email do Cliente: {emailCliente}\n" +
                   $"Endereço do Cliente: {enderecoCliente}\n" +
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
