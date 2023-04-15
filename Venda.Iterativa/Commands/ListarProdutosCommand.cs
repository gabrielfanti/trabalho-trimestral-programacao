using Venda.Iterativa.Classes;
using Venda.Iterativa.UserControls;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class ListarProdutosCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            ucListarProduto.Exibir(parameter as MainWindowViewModel);
        }
    }
}
