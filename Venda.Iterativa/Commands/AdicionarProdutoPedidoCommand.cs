using System.Linq;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class AdicionarProdutoPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            var vm = parameter as ListarProdutosViewModel;

            if (vm.ProdutoSelecionado.Estoque - 1.00m < 0.0m)
            {
                MessageBox.Show("Estoque não disponível");
                return;
            }

            vm.ProdutoSelecionado.Estoque -= 1.00m;
            vm.Pedido.Produtos.Add(vm.ProdutoSelecionado);
            vm.Pedido.Total = vm.Pedido.Produtos.Sum(x => x.Preco);
        }
    }
}
