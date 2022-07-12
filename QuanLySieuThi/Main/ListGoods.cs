using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ListGoods
    {
        public static List<Goods> listGoods = new List<Goods>() {
               new Goods() { name = "Sua", price = 21000, goodsid = "HHS1",quantity = 200,productiondate = new DateTime(2020, 12, 12) ,shelflife = new DateTime(2023, 12, 12)},
               new Goods() { name = "Nuoc ngot", price = 30000, goodsid = "HHN2",quantity = 300,productiondate = new DateTime(2020, 02, 20),shelflife = new DateTime(2022, 02, 20)},
               new Goods() { name = "Keo deo", price = 10000, goodsid = "HHK3",quantity = 200,productiondate = new DateTime(2020, 07, 07),shelflife =  new DateTime(2021, 07, 07)},
               new Goods() { name = "Socola", price = 50000, goodsid = "HHS4",quantity = 700,productiondate = new DateTime(2020, 02, 15),shelflife = new DateTime(2022, 02, 15)},
               new Goods() { name = "Qua nho", price = 150000, goodsid = "TKQ5",quantity = 500,productiondate = new DateTime(2020, 05, 15),shelflife = new DateTime(2022, 05, 15)},
               new Goods() { name = "Ca canh", price = 350000, goodsid = "TKC6",quantity = 2000,productiondate = new DateTime(2021, 07, 30),shelflife = new DateTime(2023, 07, 30)},
               new Goods() { name = "Rau cai", price = 20000, goodsid = "TKR7",quantity = 100,productiondate = new DateTime(2020, 09, 10) ,shelflife = new DateTime(2024, 09, 10)},
               new Goods() { name = "Ca hoi", price = 250000, goodsid = "TKC8",quantity = 200,productiondate = new DateTime(2020, 07, 07),shelflife = new DateTime(2022, 07, 07) },
               new Goods() { name = "Quan jeans", price = 1250000, goodsid = "GGQ9",quantity = 450,productiondate = new DateTime(2020, 02, 15),shelflife = new DateTime(2022, 02, 15)},
               new Goods() { name = "Ao so mi", price = 880000, goodsid = "GGA10",quantity = 200,productiondate = new DateTime(2020, 04, 01),shelflife = new DateTime(2022, 04, 01)},
               new Goods() { name = "Bot giat", price = 320000, goodsid = "GGB11",quantity = 390,productiondate = new DateTime(2021, 03, 01) ,shelflife = new DateTime(2023, 03, 01)},
               new Goods() { name = "Bep dien", price = 2200000, goodsid = "GGB12",quantity = 200,productiondate = new DateTime(2020, 09, 10),shelflife = new DateTime(2023, 09, 10)},
               new Goods() { name = "Bim bim", price = 10000, goodsid = "TNB13",quantity = 600,productiondate = new DateTime(2020, 12, 05),shelflife = new DateTime(2022, 12, 05)},
               new Goods() { name = "Nuoc hoa", price = 200000, goodsid = "TNN14",quantity = 900,productiondate = new DateTime(2021, 08, 10),shelflife = new DateTime(2024, 08, 10)},
               new Goods() { name = "Sua rua mat", price = 350000, goodsid = "TNS15",quantity = 3000,productiondate = new DateTime(2021, 01, 20),shelflife = new DateTime(2025, 01, 20)},
               new Goods() { name = "Banh ngot", price = 200000, goodsid = "TNB16",quantity = 5000,productiondate = new DateTime(2021, 05, 05) ,shelflife = new DateTime(2023, 05, 05)},
        };
        public Goods FindByID(string Id)
        {
            Goods HangHoa = null;
            if (listGoods != null)
            {
                foreach (Goods Hh in listGoods)
                {
                    if (Hh.goodsid == Id)
                    {
                        HangHoa = Hh;
                    }
                }
            }
            return HangHoa;
        }
        public void AddGoods()
        {
            Goods g = new Goods();
            Console.Write("\n\t\t\t\tTen hang:  ");
            g.name = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tGia: ");
            g.price = double.Parse(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tID hang: ");
            g.goodsid = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tSo luong: ");
            g.quantity = int.Parse(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tNgay san xuat: ");
            g.productiondate = DateTime.Parse(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tNgay het han: ");
            g.shelflife = DateTime.Parse(Console.ReadLine());
            listGoods.Add(g);
        }
        public bool DeleteGoods(string ID)
        {
            bool Deletegoodss = false;
            Goods g = FindByID(ID);
            if (g != null)
            {
                Deletegoodss = listGoods.Remove(g);
            }
            return Deletegoodss;
        }
        public void OutPutGoods(Goods g)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t{0, -15} {1, -16} {2, -15} {3, -19} {4, -30} {5, -8}", "ID", "Ten SP", "Gia", "SL", "NSX", "HSD");
            Console.WriteLine("\n\t{0, -15} {1, -15} {2, -16} {3, -12} {4, -30} {5, -8}", g.goodsid, g.name, g.price, g.quantity, g.productiondate, g.shelflife);
        }
        public void OutPut()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t{0, -15} {1, -16} {2, -15} {3, -19} {4, -30} {5, -8}", "ID", "Ten SP", "Gia", "SL", "NSX", "HSD");
                foreach (Goods g in listGoods)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\t{0, -15} {1, -15} {2, -16} {3, -12} {4, -30} {5, -8}", g.goodsid, g.name, g.price, g.quantity, g.productiondate, g.shelflife);
                }
            
        }
        public List<Goods> OutPutGoodsList()
        {
            return listGoods;
        }
        ~ListGoods()
        {
            Console.ReadKey();
        }
    }
}
