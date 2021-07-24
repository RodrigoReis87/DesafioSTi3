using System.Collections.ObjectModel;

namespace DesafioTecnicoSTi3.ViewModel
{
    public class UcConfigViewModel : PropertyChange
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _urlapi;
        public string UrlAPI
        {
            get => _urlapi;
            set
            {
                _urlapi = value;
                OnPropertyChanged(nameof(UrlAPI));
            }
        }

        private bool _alteracao;
        public bool Alteracao
        {
            get => _alteracao;
            set
            {
                _alteracao = value;
                OnPropertyChanged(nameof(Alteracao));
            }
        }

        private ObservableCollection<ConfigViewModel> _urlAdicionada;
        public ObservableCollection<ConfigViewModel> URLAdicionada
        {
            get => _urlAdicionada;
            set
            {
                _urlAdicionada = value;
                OnPropertyChanged(nameof(URLAdicionada));
            }
        }
    }
}
