using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTecnicoSTi3.Business
{
    public class ConfigBusiness
    {
        private readonly DesafioTecnicoSTi3Context _context;

        public ConfigBusiness()
        {
            _context = new DesafioTecnicoSTi3Context();
        }

        public void Adicionar(ConfigViewModel configViewModel)
        {
            _context.Configuracoes.Add(new Configuracoes
            {
                UrlAPI = configViewModel.UrlAPI
            });

            _context.SaveChanges();
        }

        public void Alterar(ConfigViewModel configViewModel)
        {
            var config = _context.Configuracoes.First(x => x.Id == configViewModel.Id);

            config.UrlAPI = configViewModel.UrlAPI;

            _context.SaveChanges();
        }

        public List<ConfigViewModel> Listar()
        {
            return _context.Configuracoes.AsNoTracking()
                .Select(s => new ConfigViewModel
                {
                    Id = s.Id,
                    UrlAPI = s.UrlAPI
                }).ToList()
                .OrderBy(x => x.UrlAPI).ToList();
        }

    }
}

