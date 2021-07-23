using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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

