using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class DiscountGoods : Goods
    {
        public DiscountGoods()
        {

        }
        public DiscountGoods(string Name, double Price, string GoodsId, int Quantity, DateTime Productiondate, DateTime shelflife) : base(Name, Price, GoodsId, Quantity, Productiondate, shelflife)
        {

        }
        private DateTime Promotion;
        public DateTime promotion
        {
            get => Promotion;
            set => Promotion = value;
        }
        ~DiscountGoods()
        {

        }
    }
}
