using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.ViewModel;
using System.Linq;

namespace DesafioTecnicoSTi3.Business
{
    public class EnderecoBusiness
    {
        private readonly DesafioTecnicoSTi3Context _context;

        public EnderecoBusiness()
        {
            _context = new DesafioTecnicoSTi3Context();
        }

    }
}
