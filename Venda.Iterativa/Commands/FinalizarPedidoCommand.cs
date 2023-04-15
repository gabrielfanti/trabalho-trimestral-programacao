using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.UserControls;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class FinalizarPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            var vm = parameter as ReceberViewModel;

            if (vm.Pedido.NumeroCartao.ToString().Length != 16 || vm.Pedido.Data < DateTime.Today || vm.Pedido.CVV == 0)
            {
                MessageBox.Show("Dados inválidos, tente novamente!");
                return;
            }

            MessageBox.Show("Pedido finalizado com sucesso!");
        }
    }
}