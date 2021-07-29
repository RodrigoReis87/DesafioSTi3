using DesafioTecnicoSTi3.data.Entidades;
using System;
using System.Collections.Generic;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class PedidoViewModel
    {
        //public long cod_pedido { get; set; }
        public string id { get; set; }
        public string numero { get; set; }
        public string dataCriacao { get; set; }
        public string dataAlteracao { get; set; }
        public string status { get; set; }
        public string desconto { get; set; }
        public string frete { get; set; }
        public string subTotal { get; set; }
        public string valorTotal { get; set; }
        public Clientes cliente { get; set; }
        public EnderecoEntrega enderecoEntrega { get; set; }
        public List<ItemViewModel> itens { get; set; }
        public List<PagamentoViewModel>pagamento { get; set; }
    }
}
