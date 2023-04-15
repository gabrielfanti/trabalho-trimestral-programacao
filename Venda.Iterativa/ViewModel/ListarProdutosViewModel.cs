using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Venda.Iterativa.Classes;
using Venda.Iterativa.Commands;
using Venda.Iterativa.Interfaces;
using Venda.Iterativa.Model;

namespace Venda.Iterativa.ViewModel
{
    internal sealed class ListarProdutosViewModel : AbstractViewModel
    {
        private const string _C_DESCRICAO = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In lobortis feugiat quam, non tristique leo tempor id. Duis in iaculis lorem. Curabitur sit amet interdum erat. Proin in sapien cursus, tincidunt dui nec, sagittis nulla. Pellentesque id placerat ante. Etiam pulvinar lobortis tempor. Nunc at metus blandit, eleifend ligula in, hendrerit metus. Praesent pulvinar urna ut sem varius, id rutrum magna malesuada. Morbi tempor leo id turpis scelerisque, et fermentum ex facilisis. Nam tincidunt pretium leo at mollis. Sed sit amet gravida augue. Maecenas imperdiet ut orci vel dapibus. Aliquam cursus porttitor luctus. Quisque tincidunt libero vehicula, mattis justo at, sollicitudin magna. Suspendisse pulvinar turpis ut diam iaculis pellentesque.";

        private ProdutoModel _produtoSelecionado = new ProdutoModel();
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();
        private PedidoModel _pedido = new PedidoModel();



        public ObservableCollection<ProdutoModel> Produtos
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        public PedidoModel Pedido
        {
            get => _pedido;
            set => SetField(ref _pedido, value);
        }

        public ProdutoModel ProdutoSelecionado
        {
            get => _produtoSelecionado;
            set => SetField(ref _produtoSelecionado, value);
        }



        public AdicionarProdutoPedidoCommand Adicionar { get; private set; } = new AdicionarProdutoPedidoCommand();
        public RemoverProdutoPedidoCommand Remover { get; private set; } = new RemoverProdutoPedidoCommand();
        public ReceberPedidoCommand Receber { get; private set; } = new ReceberPedidoCommand();
        public ListarProdutosViewModel(UserControl userControl, IObserver observer) : base("Lista de Produtos")
        {
            UserControl = userControl;
            MainUserControl = observer;

            Add(observer);
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            Produtos.Clear();
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"..\net6.0-windows\Images\batata.png", UriKind.RelativeOrAbsolute)),
                Referencia = "Batata",
                Descricao = _C_DESCRICAO,
                Estoque = 50.00m,
                Preco = 32.90m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"..\net6.0-windows\Images\combo.png", UriKind.RelativeOrAbsolute)),
                Referencia = "Combo",
                Descricao = _C_DESCRICAO,
                Estoque = 77.00m,
                Preco = 32.49m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"..\net6.0-windows\Images\lanche.jpg", UriKind.RelativeOrAbsolute)),
                Referencia = "Lanche",
                Descricao = _C_DESCRICAO,
                Estoque = 5.00m,
                Preco = 17.99m,
            });

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(new Uri(@"..\net6.0-windows\Images\refrigerante.png", UriKind.RelativeOrAbsolute)),
                Referencia = "Refrigerante",
                Descricao = _C_DESCRICAO,
                Estoque = 100.00m,
                Preco = 8.90m,
            });
        }
    }
}
