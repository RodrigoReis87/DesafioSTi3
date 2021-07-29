using DesafioTecnicoSTi3.data.Entidades;
using System;
using System.Collections.Generic;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class PedidoViewModel
    {
        public long cod_pedido { get; set; }
        public string id { get; set; }
        public string numero { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public string status { get; set; }
        public double desconto { get; set; }
        public double frete { get; set; }
        public double subTotal { get; set; }
        public double valorTotal { get; set; }
        public Clientes cliente { get; set; }
        public EnderecoEntrega enderecoEntrega { get; set; }
        public List<ItemViewModel> itens { get; set; }
        public List<PagamentoViewModel>pagamento { get; set; }
    }
}
