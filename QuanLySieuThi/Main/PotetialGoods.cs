using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class PotentialGoods : Goods
    {

        public PotentialGoods()
        {

        }
        public PotentialGoods(string Name, double Price, string GoodsId) : base(Name, Price, GoodsId)
        {

        }
        ~PotentialGoods()
        {
            Console.ReadKey();
        }
    }
}
