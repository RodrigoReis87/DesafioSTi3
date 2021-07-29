using System;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class ClienteViewModel
    {
        public long codigo_cliente { get; set; }
        public string id { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string razaoSocial { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
    }
}
