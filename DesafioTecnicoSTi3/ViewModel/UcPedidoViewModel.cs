using System;
using System.Collections.ObjectModel;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class UcPedidoViewModel : PropertyChange
    {
        private string _numero;
        public string Numero
        {
            get => _numero;
            set
            {
                _numero = value;
                OnPropertyChanged(nameof(Numero));
            }
        }

        private DateTime _data;
        public DateTime Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged(nameof(Data));
            }
        }

        private string _cliente;
        public string Cliente
        {
            get => _cliente;
            set
            {
                _cliente = value;
                OnPropertyChanged(nameof(Cliente));
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
