using DesafioTecnicoSTi3.Business;
using DesafioTecnicoSTi3.data.Context;
using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.View.UserControls;
using DesafioTecnicoSTi3.ViewModel;
using DesafioTecnicoSTi3.ViewModel.API;
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
        private UcClienteViewModel UcClienteVM = new UcClienteViewModel();
        private UcItemViewModel UcItemVM = new UcItemViewModel();
        private UcEnderecoEntregaViewModel UcEnderecoVM = new UcEnderecoEntregaViewModel();
        private UcPagamentoViewModel UcPagamentoVM = new UcPagamentoViewModel();

        public Principal()
        {
            InitializeComponent();

            AplicarMigracoes();

            DataContext = UcPedidoVM;
            DataContext = UcClienteVM;
            DataContext = UcItemVM;
            DataContext = UcEnderecoVM;
            DataContext = UcPagamentoVM;

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

                foreach (var item in obj)
                {
                    //Pedido
                    UcPedidoVM.id = item.id;
                    UcPedidoVM.numero = item.numero;
                    UcPedidoVM.dataAlteracao = item.dataAlteracao;
                    UcPedidoVM.dataCriacao = item.dataCriacao;
                    UcPedidoVM.frete = item.frete;
                    UcPedidoVM.Status = item.status;
                    UcPedidoVM.desconto = item.desconto;
                    UcPedidoVM.subTotal = item.subTotal;
                    UcPedidoVM.ValorTotal = item.valorTotal;

                    //Cliente
                    UcClienteVM.id = item.cliente.id;
                    UcClienteVM.cnpj = item.cliente.cnpj;
                    UcClienteVM.cpf = item.cliente.cpf;
                    UcClienteVM.nome = item.cliente.nome;
                    UcClienteVM.razaosocial = item.cliente.razaoSocial;
                    UcClienteVM.email = item.cliente.email;
                    UcClienteVM.datadeNascimento = item.cliente.dataNascimento;

                    //Endereço
                    UcEnderecoVM.id = item.enderecoEntrega.id;
                    UcEnderecoVM.endereco = item.enderecoEntrega.endereco;
                    UcEnderecoVM.numero = item.enderecoEntrega.numero;
                    UcEnderecoVM.cep = item.enderecoEntrega.cep;
                    UcEnderecoVM.bairro = item.enderecoEntrega.bairro;
                    UcEnderecoVM.cidade = item.enderecoEntrega.cidade;
                    UcEnderecoVM.estado = item.enderecoEntrega.estado;
                    UcEnderecoVM.complemento = item.enderecoEntrega.complemento;
                    UcEnderecoVM.referencia = item.enderecoEntrega.referencia;


                    GravarCliente();

                    GravarEndereço();

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
                frete = UcPedidoVM.frete,
                status = UcPedidoVM.Status,
                desconto = UcPedidoVM.desconto,
                subTotal = UcPedidoVM.subTotal,
                valorTotal = UcPedidoVM.ValorTotal
            };
            new PedidoBusiness().Gravar(novoPedido);
        }

        private void GravarCliente()
        {

            var novoCliente = new ClienteViewModel
            {
                id = UcClienteVM.id,
                cnpj = UcClienteVM.cnpj,
                cpf = UcClienteVM.cpf,
                nome = UcClienteVM.nome,
                razaoSocial = UcClienteVM.razaosocial,
                email = UcClienteVM.email,
                dataNascimento = UcClienteVM.datadeNascimento
            };
            new ClienteBusiness().Gravar(novoCliente);
        }

        private void GravarEndereço()
        {

            var Endereco = new EnderecoEntregaViewModel
            {
                id = UcEnderecoVM.id,
                endereco = UcEnderecoVM.endereco,
                numero = UcEnderecoVM.numero,
                cep = UcEnderecoVM.cep,
                bairro = UcEnderecoVM.bairro,
                cidade = UcEnderecoVM.cidade,
                estado = UcEnderecoVM.estado,
                complemento = UcEnderecoVM.complemento,
                referencia = UcEnderecoVM.referencia
            };
            new EnderecoBusiness().Gravar(Endereco);
        }

    }

}
