using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization
{
    public class OrderInfoViewModel
    {

        private ObservableCollection<Orders> _orders;
        public ObservableCollection<Orders> Order
        {
            get { return _orders; }
            set { _orders = value; }

        }

        public OrderInfoViewModel()
        {
            _orders = new ObservableCollection<Orders>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            _orders.Add(new Orders(1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new Orders(1002, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new Orders(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new Orders(1004, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new Orders(1005, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new Orders(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new Orders(1007, "Frederique Cite aux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new Orders(1008, "Martin", "Spain", "BOLID", "Madrid"));
            _orders.Add(new Orders(1009, "Laurence", "France", "BONAP", "Marseille"));
            _orders.Add(new Orders(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
        }

    }
}
