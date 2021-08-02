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

        public void Inserir(EnderecoEntregaViewModel enderecoViewModel)
        {
            var endereco = _context.EnderecoEntregas.FirstOrDefault(x => x.id == enderecoViewModel.id);

            if(endereco == null)
            {
                endereco = new EnderecoEntrega();
                _context.EnderecoEntregas.Add(endereco);
            }

                endereco.id = enderecoViewModel.id;
                endereco.endereco = enderecoViewModel.endereco;
                endereco.numero = enderecoViewModel.numero;
                endereco.cep = enderecoViewModel.cep;
                endereco.bairro = enderecoViewModel.bairro;
                endereco.cidade = enderecoViewModel.cidade;
                endereco.estado = enderecoViewModel.estado;
                endereco.complemento = enderecoViewModel.complemento;
                endereco.referencia = enderecoViewModel.referencia;
            

            _context.SaveChanges();
        }
    }
}
