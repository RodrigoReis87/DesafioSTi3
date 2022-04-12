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

        public List<ClienteViewModel> Listar()
        {
            return _context.Clientes.AsNoTracking()
                .Select(s => new ClienteViewModel
                {
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
