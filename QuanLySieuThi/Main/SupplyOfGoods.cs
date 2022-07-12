using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class SupplyOfGoods : ListGoods
    {
        public SupplyOfGoods()
        {

        }
        public static double Money; 
        public void InPutSupplyofgoods()
        {
            Goods g = new Goods();
            while (true)
            {
                Console.Write("\n\t\t\t\t\tNhap ten hang:  ");
                g.name = Console.ReadLine();
                if (g.name == "0")
                {
                    return;
                }
                Console.Write("\n\t\t\t\t\tNhap so luong:  ");
                g.quantity = Convert.ToInt32(Console.ReadLine());
                foreach (Goods G in listGoods)
                {
                    if (g.name == G.name)
                    {
                        g.price = G.price;
                        G.quantity = G.quantity + g.quantity;
                        Money += g.price * g.quantity;
                    }
                }
            }
        }
        public double PayMoneyGoods()
        {
            return Money;
        }
        ~SupplyOfGoods()
        {
            Console.ReadKey();
        }
    }
}
