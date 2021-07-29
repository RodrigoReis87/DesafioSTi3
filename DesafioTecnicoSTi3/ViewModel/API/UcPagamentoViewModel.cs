namespace DesafioTecnicoSTi3.ViewModel.API
{
    public class UcPagamentoViewModel : PropertyChange
    {
        private long _cod_pagto;
        public long cod_pagto
        {
            get => _cod_pagto;
            set
            {
                _cod_pagto = value;
                OnPropertyChanged(nameof(cod_pagto));
            }
        }

        private string _id;
        public string id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        private int _parcela;
        public int parcela
        {
            get => _parcela;
            set
            {
                _parcela = value;
                OnPropertyChanged(nameof(parcela));
            }
        }

        private double _valor;
        public double valor
        {
            get => _valor;
            set
            {
                _valor = value;
                OnPropertyChanged(nameof(valor));
            }
        }

        private string _codigo;
        public string codigo
        {
            get => _codigo;
            set
            {
                _codigo = value;
                OnPropertyChanged(nameof(codigo));
            }
        }

        private string _nome;
        public string nome
        {
            get => _nome;
            set
            {
                _nome = value;
                OnPropertyChanged(nameof(nome));
            }
        }
    }
}
