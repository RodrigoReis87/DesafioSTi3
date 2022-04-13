﻿using System.Collections.Generic;

namespace DesafioTecnicoSTi3.data.Entidades
{
    public class Item
    {
        public long codigo_item { get; set; }
        public string id { get; set; }
        public string idProduto { get; set; }
        public string idPedido { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }
        public List<Pedido> Pedido { get; set; }
    }
}
