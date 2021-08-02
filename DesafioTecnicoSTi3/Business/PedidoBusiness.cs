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

        public void Gravar(PedidoViewModel pedidoViewModel)
        {
            _context.Pedidos.Add(new Pedido
            {
                id = pedidoViewModel.id,
                numero = pedidoViewModel.numero,
                dataCriacao = pedidoViewModel.dataCriacao,
                dataAlteracao = pedidoViewModel.dataAlteracao,
                status = pedidoViewModel.status,
                desconto = pedidoViewModel.desconto,
                frete = pedidoViewModel.frete,
                subTotal = pedidoViewModel.subTotal,
                valorTotal = pedidoViewModel.valorTotal
            });

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
