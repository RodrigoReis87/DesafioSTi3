using DesafioTecnicoSTi3.data.Entidades;
using System;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel(Guid id, string cnpj, string cpf, string nome, string razaoSocial, string email, DateTime dataNascimento)
        {
            this.id = id;
            this.cnpj = cnpj;
            this.cpf = cpf;
            this.nome = nome;
            this.razaoSocial = razaoSocial;
            this.email = email;
            this.dataNascimento = dataNascimento;
        }

        public ClienteViewModel() 
        {
        }

        public Guid id { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string razaoSocial { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
        public Pedido pedido { get; set; }
    }
}
