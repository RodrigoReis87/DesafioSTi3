using System;
using System.Collections.ObjectModel;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class UcPedidoViewModel : PropertyChange
    {
        private long _cod_pedido;
        public long cod_pedido
        {
            get => _cod_pedido;
            set
            {
                _cod_pedido = value;
                OnPropertyChanged(nameof(cod_pedido));
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

        private string _dataCriacao;
        public string dataCriacao
        {
            get => _dataCriacao;
            set
            {
                _dataCriacao = value;
                OnPropertyChanged(nameof(dataCriacao));
            }
        }

        private DateTime _dataAlteracao;
        public DateTime dataAlteracao
        {
            get => _dataAlteracao;
            set
            {
                _dataAlteracao = value;
                OnPropertyChanged(nameof(dataAlteracao));
            }
        }

        private string _status;
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        private int _desconto;
        public int desconto
        {
            get => _desconto;
            set
            {
                _desconto = value;
                OnPropertyChanged(nameof(desconto));
            }
        }

        private int _frete;
        public int frete
        {
            get => _frete;
            set
            {
                _frete = value;
                OnPropertyChanged(nameof(frete));
            }
        }

        private double _subTotal;
        public double subTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                OnPropertyChanged(nameof(subTotal));
            }
        }

        private string _valortotal;
        public string ValorTotal
        {
            get => _valortotal;
            set
            {
                _valortotal = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private ObservableCollection<ClienteViewModel> _cliente;

        public ObservableCollection<ClienteViewModel> cliente
        {
            get => _cliente;
            set
            {
                _cliente = value;
                OnPropertyChanged(nameof(cliente));
            }
        }

        private ObservableCollection<EnderecoEntregaViewModel> _enderecoEntrega;

        public ObservableCollection<EnderecoEntregaViewModel> enderecoEntrega
        {
            get => _enderecoEntrega;
            set
            {
                _enderecoEntrega = value;
                OnPropertyChanged(nameof(enderecoEntrega));
            }
        }

        private ObservableCollection<ItemViewModel> _itens;

        public ObservableCollection<ItemViewModel> Itens
        {
            get => _itens;
            set
            {
                _itens = value;
                OnPropertyChanged(nameof(Itens));
            }
        }

        private ObservableCollection<PagamentoViewModel> _pagamento;

        public ObservableCollection<PagamentoViewModel> Pagamento
        {
            get => _pagamento;
            set
            {
                _pagamento = value;
                OnPropertyChanged(nameof(Pagamento));
            }
        }


        private ObservableCollection<PedidoViewModel> _pedidosAdicionados;
        public ObservableCollection<PedidoViewModel> PedidosAdicionados
        {
            get => _pedidosAdicionados;
            set
            {
                _pedidosAdicionados = value;
                OnPropertyChanged(nameof(PedidosAdicionados));
            }
        }
    }

}
