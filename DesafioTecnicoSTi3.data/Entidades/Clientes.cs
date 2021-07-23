using System;

namespace DesafioTecnicoSTi3.data.Entidades
{
    public class Clientes
    {
        public long id { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string razaoSocial { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
    }
}
