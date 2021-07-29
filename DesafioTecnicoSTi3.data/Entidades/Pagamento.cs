using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTecnicoSTi3.data.Entidades
{
    public class Pagamento
    {
        public long cod_pgto { get; set; }
        public string id { get; set; }
        public int parcela { get; set; }
        public double valor { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
    }
}
