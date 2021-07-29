using DesafioTecnicoSTi3.Business;
using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.View.UserControls;
using DesafioTecnicoSTi3.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
            ConsultarPedidos();
        }

        private void BtnAlgumaCoisa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnConfig_Click(object sender, RoutedEventArgs e)
        {
            UcConfiguracoes Conteudo = new UcConfiguracoes();
            Conteudo.ShowDialog();
        }

        private void ConsultarPedidos()
        {
            var urlAPI = new ConfigBusiness().Listar();

            var client = new HttpClient
            {
                BaseAddress = new Uri("https://desafiotecnicosti3.azurewebsites.net/")
            };

            var response = client.GetAsync($"pedido").Result;

            if (response.IsSuccessStatusCode)
            {
                var pedidoCompleto = response.Content.ReadAsStringAsync().Result;

                var obj = JsonConvert.DeserializeObject<List<Pedido>>(pedidoCompleto);

                foreach(var item in obj) 
                {
                    string texto = string.Join(Environment.NewLine, item.numero, item.dataCriacao, item.cliente.nome, item.status, item.valorTotal);
                    MessageBox.Show(texto);

                    var pedidos = new PedidoViewModel
                    {
                        cod_pedido = UcPedidoVM.cod_pedido
                        
                    };
                    new PedidoBusiness().Adicionar(pedidos);
                }             
                           

                
            }
        }


    }
}
