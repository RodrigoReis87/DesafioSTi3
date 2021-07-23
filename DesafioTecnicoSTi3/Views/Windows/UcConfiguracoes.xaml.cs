using System.Windows;

namespace DesafioTecnicoSTi3.View.UserControls
{
    /// <summary>
    /// Interaction logic for UcConfiguracoes.xaml
    /// </summary>
    public partial class UcConfiguracoes : Window
    {
        public UcConfiguracoes()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

