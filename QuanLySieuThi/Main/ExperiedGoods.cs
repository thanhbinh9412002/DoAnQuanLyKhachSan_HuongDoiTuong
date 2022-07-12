using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ExperiedGoods : Goods
    {
        public ExperiedGoods()
        {

        }
        public ExperiedGoods(string Name, double Price, string GoodsId, int Quantity, DateTime Productiondate, DateTime shelflife) : base(Name,Price,GoodsId,Quantity,Productiondate,shelflife)
        {
            
        }
        ~ExperiedGoods()
        {
            Console.ReadKey();
        }
    }
}
