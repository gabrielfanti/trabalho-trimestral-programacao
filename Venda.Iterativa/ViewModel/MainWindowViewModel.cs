using System.Windows.Controls;
using Venda.Iterativa.Classes;
using Venda.Iterativa.Commands;
using Venda.Iterativa.Interfaces;

namespace Venda.Iterativa.ViewModel
{
    internal class MainWindowViewModel : AbstractViewModel, IObserver
    {
        private UserControl _userControl;

        public UserControl UserControl
        {
            get => _userControl;
            set => SetField(ref _userControl, value);
        }

        public ListarProdutosCommand ListarProdutos { get; private set; } = new ListarProdutosCommand();

        public MainWindowViewModel() : base("UMFG | Home") { }

        public void Update(ISubject subject)
        {
            if (subject is ListarProdutosViewModel)
                UserControl = (subject as ListarProdutosViewModel).UserControl;

            if (subject is ReceberViewModel)
                UserControl = (subject as ReceberViewModel).UserControl;
        }
    }
}
