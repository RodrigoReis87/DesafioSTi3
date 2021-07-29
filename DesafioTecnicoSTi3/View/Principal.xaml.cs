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
                    UcPedidoVM.id = item.id;
                    UcPedidoVM.numero = item.numero;
                    UcPedidoVM.dataAlteracao = item.dataAlteracao;
                    UcPedidoVM.dataCriacao = item.dataCriacao;
                    UcPedidoVM.Status = item.status;
                    UcPedidoVM.desconto = item.desconto;
                    UcPedidoVM.subTotal = item.subTotal;
                    UcPedidoVM.ValorTotal = item.valorTotal;

                    GravarPedido();

                }

                
            }
        }

        private void GravarPedido()
        {

            var novoPedido = new PedidoViewModel
            {
                id = UcPedidoVM.id,
                numero = UcPedidoVM.numero,
                dataAlteracao = UcPedidoVM.dataAlteracao,
                dataCriacao = UcPedidoVM.dataCriacao,
                status = UcPedidoVM.Status,
                desconto = UcPedidoVM.desconto,
                subTotal = UcPedidoVM.subTotal,
                valorTotal = UcPedidoVM.ValorTotal
            };
            new PedidoBusiness().Gravar(novoPedido);
        }


    }
}
