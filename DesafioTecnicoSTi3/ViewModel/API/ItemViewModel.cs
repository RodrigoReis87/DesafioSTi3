using DesafioTecnicoSTi3.data.Entidades;
using System.Collections.Generic;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class ItemViewModel
    {
        public long codigo_item { get; set; }
        public string id { get; set; }
        public string idProduto { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }
        public List<PedidoViewModel> Pedido { get; set; }
    }
}
