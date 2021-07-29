namespace DesafioTecnicoSTi3.ViewModel.API
{
    class UcEnderecoEntregaViewModel : PropertyChange
    {
        private long _codigo;
        public long codigo
        {
            get => _codigo;
            set
            {
                _codigo = value;
                OnPropertyChanged(nameof(codigo));
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

        private string _endereco;
        public string endereco
        {
            get => _endereco;
            set
            {
                _endereco = value;
                OnPropertyChanged(nameof(endereco));
            }
        }

        private string _numero;
        public string numero
        {
            get => _numero;
            set
            {
                _numero = value;
                OnPropertyChanged(nameof(numero));
            }
        }

        private string _cep;
        public string cep
        {
            get => _cep;
            set
            {
                _cep = value;
                OnPropertyChanged(nameof(cep));
            }
        }

        private string _bairro;
        public string bairro
        {
            get => _bairro;
            set
            {
                _bairro = value;
                OnPropertyChanged(nameof(bairro));
            }
        }

        private string _cidade;
        public string cidade
        {
            get => _cidade;
            set
            {
                _cidade = value;
                OnPropertyChanged(nameof(cidade));
            }
        }

        private string _estado;
        public string estado
        {
            get => _estado;
            set
            {
                _estado = value;
                OnPropertyChanged(nameof(estado));
            }
        }

        private string _complemento;
        public string complemento
        {
            get => _complemento;
            set
            {
                _complemento = value;
                OnPropertyChanged(nameof(complemento));
            }
        }

        private string _referencia;
        public string referencia
        {
            get => _referencia;
            set
            {
                _referencia = value;
                OnPropertyChanged(nameof(referencia));
            }
        }
    }
}
