using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTecnicoSTi3.Business
{
    public class PedidoBusiness
    {
        private readonly DesafioTecnicoSTi3Context _context;

        public PedidoBusiness()
        {
            _context = new DesafioTecnicoSTi3Context();
        }

        public void Inserir(PedidoViewModel pedidoViewModel)
        {
            var pedido = _context.Pedidos.FirstOrDefault(x => x.id == pedidoViewModel.id);

            if (pedido == null)
            {
                pedido = new Pedido();
                _context.Pedidos.Add(pedido);
            }

            pedido.id = pedidoViewModel.id;
            pedido.numero = pedidoViewModel.numero;
            pedido.dataCriacao = pedidoViewModel.dataCriacao;
            pedido.dataAlteracao = pedidoViewModel.dataAlteracao;
            pedido.status = pedidoViewModel.status;
            pedido.desconto = pedidoViewModel.desconto;
            pedido.frete = pedidoViewModel.frete;
            pedido.subTotal = pedidoViewModel.subTotal;
            pedido.valorTotal = pedidoViewModel.valorTotal;


            _context.SaveChanges();
        }       

        public List<PedidoViewModel> Listar()
        {
            return _context.Pedidos.AsNoTracking()
                .Select(p => new PedidoViewModel
                {
                    id = p.id,
                    numero = p.numero,
                    dataAlteracao = p.dataAlteracao,
                    dataCriacao = p.dataCriacao,
                    desconto = p.desconto,
                    frete = p.frete,
                    status = p.status,
                    subTotal = p.subTotal,
                    valorTotal = p.valorTotal

                }).ToList();
        }
    }
}
