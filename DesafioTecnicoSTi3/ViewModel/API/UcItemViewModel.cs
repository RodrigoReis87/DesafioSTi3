using System.Collections.ObjectModel;

namespace DesafioTecnicoSTi3.ViewModel.API
{
    public class UcItemViewModel : PropertyChange
    {
        private long _codigo_item;
        public long codigo_item
        {
            get => _codigo_item;
            set
            {
                _codigo_item = value;
                OnPropertyChanged(nameof(codigo_item));
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

        private string _idProduto;
        public string idProduto
        {
            get => _idProduto;
            set
            {
                _idProduto = value;
                OnPropertyChanged(nameof(idProduto));
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

        private int _quantidade;
        public int quantidade
        {
            get => _quantidade;
            set
            {
                _quantidade = value;
                OnPropertyChanged(nameof(quantidade));
            }
        }

        private double _valorUnitario;
        public double valorUnitario
        {
            get => _valorUnitario;
            set
            {
                _valorUnitario = value;
                OnPropertyChanged(nameof(valorUnitario));
            }
        }

        private ObservableCollection<PedidoViewModel> _pedido;

        public ObservableCollection<PedidoViewModel> Pedido
        {
            get => _pedido;
            set
            {
                _pedido = value;
                OnPropertyChanged(nameof(Pedido));
            }
        }
    }
}
