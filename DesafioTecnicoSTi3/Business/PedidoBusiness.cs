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

            var cliente = _context.Clientes.FirstOrDefault(x => x.id == pedidoViewModel.clientes.id);            

            if (cliente != null)
            {
                pedido.cliente = cliente;
            }
            else
            {
                pedido.cliente = new Clientes();
                _context.Clientes.Add(pedido.cliente);

                pedido.cliente.id = pedidoViewModel.clientes.id;
                pedido.cliente.cnpj = pedidoViewModel.clientes.cnpj;
                pedido.cliente.cpf = pedidoViewModel.clientes.cpf;
                pedido.cliente.nome = pedidoViewModel.clientes.nome;
                pedido.cliente.razaoSocial = pedidoViewModel.clientes.razaoSocial;
                pedido.cliente.email = pedidoViewModel.clientes.email;
                pedido.cliente.dataNascimento = pedidoViewModel.clientes.dataNascimento;
            }

            var endereco = _context.EnderecoEntregas.FirstOrDefault(x => x.id == pedidoViewModel.enderecoEntrega.id);

            if(endereco != null)
            {
                pedido.enderecoEntrega = endereco;
            }
            else
            {
                pedido.enderecoEntrega = new EnderecoEntrega();
                _context.EnderecoEntregas.Add(pedido.enderecoEntrega);

                pedido.enderecoEntrega.id = pedidoViewModel.enderecoEntrega.id;
                pedido.enderecoEntrega.bairro = pedidoViewModel.enderecoEntrega.bairro;
                pedido.enderecoEntrega.cidade = pedidoViewModel.enderecoEntrega.cidade;
                pedido.enderecoEntrega.endereco = pedidoViewModel.enderecoEntrega.endereco;
                pedido.enderecoEntrega.numero = pedido.enderecoEntrega.numero;
                pedido.enderecoEntrega.referencia = pedidoViewModel.enderecoEntrega.referencia;
                pedido.enderecoEntrega.cep = pedidoViewModel.enderecoEntrega.cep;
                pedido.enderecoEntrega.complemento = pedidoViewModel.enderecoEntrega.complemento;
                pedido.enderecoEntrega.estado = pedidoViewModel.enderecoEntrega.estado;

            }
            _context.SaveChanges();
        }       

        public void ConverterParaObjeto(PedidoViewModel item)
        {

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
                    valorTotal = p.valorTotal, 
                    clientes = p.cliente,
                })
                .ToList();

        }
    }
}
