using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioTecnicoSTi3.data.Entidades
{
    public class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid id { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string razaoSocial { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
        public IList<Pedido> pedido { get; set; }
    }
}
