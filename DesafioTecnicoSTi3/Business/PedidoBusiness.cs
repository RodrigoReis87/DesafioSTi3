using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTecnicoSTi3.Business
{
    public class PedidoBusiness
    {
        private readonly DesafioTecnicoSTi3Context _context;

        public PedidoBusiness()
        {
            _context = new DesafioTecnicoSTi3Context();
        }

        public void Gravar(PedidoViewModel pedidoViewModel)
        {
            _context.Pedidos.Add(new Pedido
            {
                id = pedidoViewModel.id,
                numero = pedidoViewModel.numero,
                dataCriacao = pedidoViewModel.dataCriacao,
                dataAlteracao = pedidoViewModel.dataAlteracao,
                dataCriacao = pedidoViewModel.dataCriacao,
                status = pedidoViewModel.status,
                desconto = pedidoViewModel.desconto,
                frete = pedidoViewModel.frete,
                subTotal = pedidoViewModel.subTotal,
            });

            _context.SaveChanges();
        }
    }
}
