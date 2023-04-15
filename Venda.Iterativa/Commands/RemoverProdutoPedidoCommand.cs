using System.Linq;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class RemoverProdutoPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            var vm = parameter as ListarProdutosViewModel;
            if (vm.Pedido.Produtos.Count == 0)
            {
                MessageBox.Show("Selecione um produto para remover!");
                return;
            }

            if (vm.Pedido.Produtos.Contains(vm.ProdutoSelecionado))
            {
                vm.ProdutoSelecionado.Estoque += 1.00m;
                vm.Pedido.Produtos.Remove(vm.ProdutoSelecionado);
                vm.Pedido.Total = vm.Pedido.Produtos.Sum(x => x.Preco);
            }
        }
    }
}
