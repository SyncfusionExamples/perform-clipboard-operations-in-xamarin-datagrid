using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridXamarin
{
    public class OrderInfoRepository
    {
        private ObservableCollection<OrderInfo> orderInfo;

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
        }

        public ObservableCollection<OrderInfo> GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(1001, true, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo(1002, false, "Ana Trujilo", "Mexico", "ANATR", "México D.F."));
            orderInfo.Add(new OrderInfo(1003, true, "Ant Fuller", "Mexico", "ANTON", "México D.F."));
            orderInfo.Add(new OrderInfo(1004,true, "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1005, false, "Tim Adams", "Sweden", "BERGS", "Luleå"));
            orderInfo.Add(new OrderInfo(1006, true, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(1007,false, "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(1008, false, "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo(1009, true, "Lenny Lin", "France", "BONAP", "Marseille"));
            orderInfo.Add(new OrderInfo(1010,false, "John Carter", "Canada", "BOTTM", "Tsawassen"));
            orderInfo.Add(new OrderInfo(1011,true, "Lauro King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1012,false, "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(1013,true, "Alfki Kyle", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(1014,false, "Gina Irene", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1001, true, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo(1002, false, "Ana Trujilo", "Mexico", "ANATR", "México D.F."));
            orderInfo.Add(new OrderInfo(1003, true, "Ant Fuller", "Mexico", "ANTON", "México D.F."));
            orderInfo.Add(new OrderInfo(1004,true, "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1005, false, "Tim Adams", "Sweden", "BERGS", "Luleå"));
            orderInfo.Add(new OrderInfo(1006, true, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(1007,false, "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(1008, false, "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo(1009, true, "Lenny Lin", "France", "BONAP", "Marseille"));
            orderInfo.Add(new OrderInfo(1010,false, "John Carter", "Canada", "BOTTM", "Tsawassen"));
            orderInfo.Add(new OrderInfo(1011,true, "Lauro King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1012,false, "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(1013,true, "Alfki Kyle", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(1014,false, "Gina Irene", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1001, true, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo(1002, false, "Ana Trujilo", "Mexico", "ANATR", "México D.F."));
            orderInfo.Add(new OrderInfo(1003, true, "Ant Fuller", "Mexico", "ANTON", "México D.F."));
            orderInfo.Add(new OrderInfo(1004,true, "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1005, false, "Tim Adams", "Sweden", "BERGS", "Luleå"));
            orderInfo.Add(new OrderInfo(1006, true, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(1007,false, "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(1008, false, "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo(1009, true, "Lenny Lin", "France", "BONAP", "Marseille"));
            orderInfo.Add(new OrderInfo(1010,false, "John Carter", "Canada", "BOTTM", "Tsawassen"));
            orderInfo.Add(new OrderInfo(1011,true, "Lauro King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1012,false, "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(1013,true, "Alfki Kyle", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(1014,false, "Gina Irene", "UK", "AROUT", "London"));



            return orderInfo;
        }
    }
}
