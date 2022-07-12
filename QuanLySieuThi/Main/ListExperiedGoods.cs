using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ListExperiedGoods
    {
        private static List<ExperiedGoods> ListHetHan = new List<ExperiedGoods>() {
               new ExperiedGoods(){name = "Sua", price=21000, goodsid="HH1",quantity=30, productiondate=new DateTime(2020, 12, 12), shelflife=new DateTime(2021, 12, 4)},
               new ExperiedGoods(){name = "Nuoc ngot", price=30000, goodsid="HH2",quantity=40, productiondate=new DateTime(2020, 02, 20), shelflife=new DateTime(2021, 12, 20)},
               new ExperiedGoods(){name = "Keo deo", price=10000, goodsid="HH3",quantity=50, productiondate=new DateTime(2020, 10, 07), shelflife=new DateTime(2021, 12, 07)},
               new ExperiedGoods(){name = "Socola", price=50000, goodsid="HH4",quantity=35, productiondate=new DateTime(2020, 02, 15), shelflife=new DateTime(2021, 12, 15)},
               new ExperiedGoods(){name = "Tao", price=150000, goodsid="HH5",quantity=40, productiondate=new DateTime(2020, 05, 15), shelflife=new DateTime(2021, 12, 15)},
               new ExperiedGoods(){name = "Dau goi", price=350000, goodsid="HH6",quantity=60, productiondate=new DateTime(2020, 07, 30), shelflife=new DateTime(2021, 12, 30)},
               new ExperiedGoods(){name = "Banh mi", price=20000, goodsid="HH7",quantity=50, productiondate=new DateTime(2020, 09, 10), shelflife=new DateTime(2021, 12, 10)},
               new ExperiedGoods(){name = "Ca hoi", price=250000, goodsid="HH8",quantity=20, productiondate=new DateTime(2020, 07, 07), shelflife=new DateTime(2021, 12, 07)},
               new ExperiedGoods(){name = "Sua tam", price=125000000, goodsid="HH9",quantity=10, productiondate=new DateTime(2020, 02, 15), shelflife=new DateTime(2021, 12, 15)},
               new ExperiedGoods(){name = "Ruou", price=880000, goodsid="HH10",quantity=32, productiondate= new DateTime(2020, 04, 01), shelflife=new DateTime(2021, 12, 11)},
        };
        public void AddHangHetHan()
        {
            ExperiedGoods newtk = new ExperiedGoods();
            Console.Write("\n\t\t\t\t\tTen Hang Hoa: ");
            newtk.name = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tTien Hang Hoa: ");
            newtk.price = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tMa Hang Hoa Het Han: ");
            newtk.goodsid = Console.ReadLine();
            foreach (ExperiedGoods tk in ListHetHan)
            {
                while (tk.goodsid == newtk.goodsid)
                {
                    Console.WriteLine("\n\t\t\t\t\tDu lieu khong hop le Xin vui long nhap lai !!!");
                    Console.Write("\n\t\t\t\t\tMa Hang Hoa Het Han: ");
                    newtk.goodsid = Console.ReadLine();
                }
            }
            Console.Write("\n\t\t\t\t\tSo Luong: ");
            newtk.quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tNSX (yyyy,mm,dd): ");
            newtk.productiondate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tHSD (yyyy,mm,dd): ");
            newtk.shelflife = Convert.ToDateTime(Console.ReadLine());
            ListHetHan.Add(newtk);
        }
        public ExperiedGoods FindByID(string Id)
        {
            ExperiedGoods TonKho = null;
            if (ListHetHan != null)
            {
                foreach (ExperiedGoods tk in ListHetHan)
                {
                    if (tk.goodsid == Id)
                    {
                        TonKho = tk;
                    }
                }
            }
            return TonKho;
        }
        public bool DeleteHangHetHan(string ID)
        {
            bool IsDelete = false;
            ExperiedGoods tk = FindByID(ID);
            if (tk != null)
            {
                IsDelete = ListHetHan.Remove(tk);
            }
            return IsDelete;
        }
        public void Display(ExperiedGoods g)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t{0, -15} {1, -18} {2, -15} {3, -21} {4, -30} {5, -8}", "ID", "Ten SP", "Gia", "SL", "NSX", "HSD");
            Console.WriteLine("\n\t{0, -15} {1, -17} {2, -16} {3, -15} {4, -30} {5, -8}", g.goodsid, g.name, g.price, g.quantity, g.productiondate, g.shelflife);
        }
        public void DisPlayList(List<ExperiedGoods> ListHetHan)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t{0, -15} {1, -18} {2, -15} {3, -21} {4, -30} {5, -8}", "ID", "Ten SP", "Gia", "SL", "NSX", "HSD");
            if (ListHetHan != null)
            {
                foreach (ExperiedGoods g in ListHetHan)
                {
                    Console.WriteLine("\n\t\t");
                    Console.WriteLine("\t{0, -15} {1, -17} {2, -16} {3, -15} {4, -30} {5, -8}", g.goodsid, g.name, g.price, g.quantity, g.productiondate, g.shelflife);
                }
            }
        }
        public List<ExperiedGoods> getListHangHH()
        {
            return ListHetHan;
        }
        ~ListExperiedGoods()
        {
            Console.ReadKey();
        }
    }
}
