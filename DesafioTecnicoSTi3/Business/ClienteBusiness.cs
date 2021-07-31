using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTecnicoSTi3.Business
{
    public class ClienteBusiness
    {
        private readonly DesafioTecnicoSTi3Context _context;

        public ClienteBusiness()
        {
            _context = new DesafioTecnicoSTi3Context();
        }

        public void Gravar(ClienteViewModel clienteViewModel)
        {
            _context.Clientes.Add(new Clientes
            {
                id = clienteViewModel.id,
                cnpj = clienteViewModel.cnpj,
                cpf = clienteViewModel.cpf,
                nome = clienteViewModel.nome,
                razaoSocial = clienteViewModel.razaoSocial,
                email = clienteViewModel.email,
                dataNascimento = clienteViewModel.dataNascimento
            });

            _context.SaveChanges();
        }

        public List<ClienteViewModel> Listar()
        {
            return _context.Clientes.AsNoTracking()
                .Select(s => new ClienteViewModel
                {
                    codigo_cliente = s.codigo_cliente,
                    id = s.id,
                    cnpj = s.cnpj,
                    cpf = s.cpf,
                    nome = s.nome,
                    razaoSocial = s.razaoSocial,
                    email = s.email,
                    dataNascimento = s.dataNascimento
                }).ToList()
                .OrderBy(x => x.nome).ToList();
        }
    }
}
