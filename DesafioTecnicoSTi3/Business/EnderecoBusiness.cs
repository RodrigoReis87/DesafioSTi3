using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.ViewModel;

namespace DesafioTecnicoSTi3.Business
{
    public class EnderecoBusiness
    {
        private readonly DesafioTecnicoSTi3Context _context;

        public EnderecoBusiness()
        {
            _context = new DesafioTecnicoSTi3Context();
        }

        public void Gravar(EnderecoEntregaViewModel enderecoViewModel)
        {
            _context.EnderecoEntregas.Add(new EnderecoEntrega
            {
                id = enderecoViewModel.id,
                endereco = enderecoViewModel.endereco,
                numero = enderecoViewModel.numero,
                cep = enderecoViewModel.cep,
                bairro = enderecoViewModel.bairro,
                cidade = enderecoViewModel.cidade,
                estado = enderecoViewModel.estado,
                complemento = enderecoViewModel.complemento,
                referencia = enderecoViewModel.referencia
            });

            _context.SaveChanges();
        }
    }
}
