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

        public void Inserir(ClienteViewModel clienteViewModel)
        {
            var cliente = _context.Clientes.FirstOrDefault(x => x.cpf == clienteViewModel.cpf);

            if (cliente == null)
            {
                 cliente = new Clientes();
                _context.Clientes.Add(cliente);
            }

            cliente.id = clienteViewModel.id;
            cliente.cnpj = clienteViewModel.cnpj;
            cliente.cpf = clienteViewModel.cpf;
            cliente.nome = clienteViewModel.nome;
            cliente.razaoSocial = clienteViewModel.razaoSocial;
            cliente.email = clienteViewModel.email;
            cliente.dataNascimento = clienteViewModel.dataNascimento;               
            

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
