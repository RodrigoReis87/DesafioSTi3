using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.View.UserControls;
using DesafioTecnicoSTi3.ViewModel;
using System.Windows;

namespace DesafioTecnicoSTi3.View
{
    /// <summary>
    /// Interaction logic for Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        private UcPedidoViewModel UcPedidoVM = new UcPedidoViewModel();
        public Principal()
        {
            InitializeComponent();

            AplicarMigracoes();

            DataContext = UcPedidoVM;

        }



        private void AplicarMigracoes()
        {
            using var context = new DesafioTecnicoSTi3Context();
            context.AplicarMigracoes();
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAlgumaCoisa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnConfig_Click(object sender, RoutedEventArgs e)
        {
            UcConfiguracoes Conteudo = new UcConfiguracoes();
            Conteudo.ShowDialog();
        }


    }
}
