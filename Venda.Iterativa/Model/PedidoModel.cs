using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.Iterativa.Classes;

namespace Venda.Iterativa.Model
{
    internal sealed class PedidoModel : AbstractModel
    {
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();
        private decimal _total;
        private long _numeroCartao;
        private DateTime _data = DateTime.Now;
        private int _cvv;

        public ObservableCollection<ProdutoModel> Produtos
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        public decimal Total
        {
            get => _total;
            set => SetField(ref _total, value);
        }

        public long NumeroCartao
        {
            get => _numeroCartao;
            set => SetField(ref _numeroCartao, value);
        }

        public DateTime Data
        {
            get => _data;
            set => SetField(ref _data, value);
        }

        public int CVV
        {
            get => _cvv;
            set => SetField(ref _cvv, value);
        }
    }
}
