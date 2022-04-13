using DesafioTecnicoSTi3.Business;
using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.View.UserControls;
using DesafioTecnicoSTi3.ViewModel;
using DesafioTecnicoSTi3.ViewModel.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        private UcClienteViewModel UcClienteVM = new UcClienteViewModel();
        private UcItemViewModel UcItemVM = new UcItemViewModel();
        private UcEnderecoEntregaViewModel UcEnderecoVM = new UcEnderecoEntregaViewModel();
        private UcPagamentoViewModel UcPagamentoVM = new UcPagamentoViewModel();

        public Principal()
        {
            InitializeComponent();

            AplicarMigracoes();

            DataContext = UcPedidoVM;

            CarregarRegistros();

        }

        private void AplicarMigracoes()
        {
            using var context = new DesafioTecnicoSTi3Context();
            context.AplicarMigracoes();
        }

        private void BtnSincronizar_Click(object sender, RoutedEventArgs e)
        {
            SincronizarPedidos();
        }

    private void BtnConfig_Click(object sender, RoutedEventArgs e)
        {
            UcConfiguracoes Conteudo = new UcConfiguracoes();
            Conteudo.ShowDialog();
        }

        private void SincronizarPedidos()
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

                foreach (var item in obj )
                {
                    try
                    {
                        var novoPedido = new PedidoViewModel
                        {
                            id = item.id,
                            numero = item.numero,
                            dataAlteracao = item.dataAlteracao,
                            dataCriacao = item.dataCriacao,
                            frete = item.frete,
                            status = item.status,
                            desconto = item.desconto,
                            subTotal = item.subTotal,
                            valorTotal = item.valorTotal,
                            clientes = new Clientes()
                            {
                                id = item.cliente.id,
                                cnpj = item.cliente.cnpj,
                                cpf = item.cliente.cpf,
                                razaoSocial = item.cliente.razaoSocial,
                                nome = item.cliente.nome,
                                email = item.cliente.email,
                                dataNascimento = item.cliente.dataNascimento,

                            },
                            enderecoEntrega = new EnderecoEntrega()
                            {
                                id = item.enderecoEntrega.id,
                                endereco = item.enderecoEntrega.endereco,
                                numero = item.enderecoEntrega.numero,
                                cep = item.enderecoEntrega.cep,
                                bairro = item.enderecoEntrega.bairro,
                                cidade = item.enderecoEntrega.cidade,
                                estado = item.enderecoEntrega.estado,
                                complemento = item.enderecoEntrega.complemento,
                                referencia = item.enderecoEntrega.referencia,
                            }
                        };
                        new PedidoBusiness().Inserir(novoPedido);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                    

                    CarregarRegistros();

                }


            }
        }

        private void CarregarRegistros()
        {
            UcPedidoVM.PedidosAdicionados = new ObservableCollection<PedidoViewModel>(new PedidoBusiness().Listar());
        }
    }

}
