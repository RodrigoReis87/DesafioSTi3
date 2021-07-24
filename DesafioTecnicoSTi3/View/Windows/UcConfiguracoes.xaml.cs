using DesafioTecnicoSTi3.Business;
using DesafioTecnicoSTi3.ViewModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace DesafioTecnicoSTi3.View.UserControls
{
    /// <summary>
    /// Interaction logic for UcConfiguracoes.xaml
    /// </summary>
    public partial class UcConfiguracoes : Window
    {
        private UcConfigViewModel UcConfigVM = new UcConfigViewModel();

        public UcConfiguracoes()
        {
            InitializeComponent();

            DataContext = UcConfigVM;

            CarregarRegistro();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (!UcConfigVM.Alteracao)
            {
                SalvarURL();
            }
            else
            {
                AtualizarURL();
            }

            UcConfigVM.UrlAPI = "";

            CarregarRegistro();
        }

        private void BtnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            var url = (sender as Button).Tag as ConfigViewModel;
            
            PreencherCampos(url);
        }

        private void PreencherCampos(ConfigViewModel url)
        {
            UcConfigVM.Id = url.Id;
            UcConfigVM.UrlAPI = url.UrlAPI;
            UcConfigVM.Alteracao = true;
        }

        private void CarregarRegistro()
        {
            UcConfigVM.URLAdicionada = new ObservableCollection<ConfigViewModel>(new ConfigBusiness().Listar());
        }

        private void SalvarURL()
        {

            var novaURL = new ConfigViewModel
            {
                UrlAPI = UcConfigVM.UrlAPI
            };
            new ConfigBusiness().Adicionar(novaURL);
        }

        private void AtualizarURL()
        {

            var atualizaURL = new ConfigViewModel
            {
                Id = UcConfigVM.Id,
                UrlAPI = UcConfigVM.UrlAPI
            };
            new ConfigBusiness().Alterar(atualizaURL);
        }

        
    }
}

