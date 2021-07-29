﻿using System;
using System.Collections.ObjectModel;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class UcClienteViewModel : PropertyChange
    {
        private long _codigocliente;
        public long codigo_cliente
        {
            get => _codigocliente;
            set
            {
                _codigocliente = value;
                OnPropertyChanged(nameof(codigo_cliente));
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

        private string _cnpj;
        public string cnpj
        {
            get => _cnpj;
            set
            {
                _cnpj = value;
                OnPropertyChanged(nameof(cnpj));
            }
        }

        private string _cpf;
        public string cpf
        {
            get => _cpf;
            set
            {
                _cpf = value;
                OnPropertyChanged(nameof(cpf));
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

        private string _razaosocial;
        public string razaosocial
        {
            get => _razaosocial;
            set
            {
                _razaosocial = value;
                OnPropertyChanged(nameof(razaosocial));
            }
        }

        private string _email;
        public string email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(email));
            }
        }

        private DateTime _datadeNascimento;
        public DateTime datadeNascimento
        {
            get => _datadeNascimento;
            set
            {
                _datadeNascimento = value;
                OnPropertyChanged(nameof(datadeNascimento));
            }
        }

        private ObservableCollection<ClienteViewModel> _clientesAdicionados;
        public ObservableCollection<ClienteViewModel> ClientesAdicionados
        {
            get => _clientesAdicionados;
            set
            {
                _clientesAdicionados = value;
                OnPropertyChanged(nameof(ClientesAdicionados));
            }
        }

    }
}
