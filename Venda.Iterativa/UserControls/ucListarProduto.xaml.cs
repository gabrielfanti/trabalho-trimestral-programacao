using System.Windows.Controls;
using Venda.Iterativa.Interfaces;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.UserControls
{
    public partial class ucListarProduto : UserControl
    {
        private ucListarProduto(IObserver observer)
        {
            InitializeComponent();
            DataContext = new ListarProdutosViewModel(this, observer);
        }

        internal static void Exibir(IObserver observer)
        {
            (new ucListarProduto(observer).DataContext as ListarProdutosViewModel).Notify();
        }
    }
}
