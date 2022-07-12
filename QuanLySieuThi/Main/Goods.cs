using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class Goods
    {
        private string Name;
        public string name
        {
            get => Name;
            set => Name = value;
        }
        private double Price;
        public double price
        {
            get => Price;
            set => Price = value;
        }
        private string GoodsId;
        public string goodsid
        {
            get => GoodsId;
            set => GoodsId = value;
        }
        private int Quantity;
        public int quantity
        {
            get => Quantity;
            set => Quantity = value;
        }
        private DateTime Productiondate;
        public DateTime productiondate
        {
            get => Productiondate;
            set => Productiondate = value;
        }
        private DateTime Shelflife;
        public DateTime shelflife
        {
            get => Shelflife;
            set => Shelflife = value;
        }
        public Goods()
        {

        }
        public Goods(string name, double price, string goodsId, int quantity, DateTime productiondate,
            DateTime shelflife)
        {
            this.Name = name;
            this.Price = price;
            this.GoodsId = goodsId;
            this.Quantity = quantity;
            this.Productiondate = productiondate;
            this.Shelflife = shelflife;
        }
        public Goods(string name , double price , string goodsId)
        {
            this.Name = name;
            this.Price = price;
            this.GoodsId = goodsId;
        }
        ~Goods()
        {

        }
    }
}
