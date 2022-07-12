using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ListDiscountGoods
    {
        private static List<DiscountGoods> listdiscount = new List<DiscountGoods>() {
               new DiscountGoods(){name = "Trung",     price=21000,    goodsid="GG1",  quantity=50, productiondate= new DateTime(2021, 11, 12), shelflife= new DateTime(2022, 01, 12), promotion= new DateTime(2021, 12, 25)},
               new DiscountGoods(){name = "Banh my",   price=30000,     goodsid="GG2",  quantity=50, productiondate= new DateTime(2021, 11, 20), shelflife= new DateTime(2021, 12, 30), promotion= new DateTime(2021, 12, 25)},
               new DiscountGoods(){name = "Ao thun",   price=100000,     goodsid="GG3",  quantity=50, productiondate= new DateTime(2020, 07, 07), shelflife = new DateTime(2025, 07, 07), promotion= new DateTime(2022, 01, 01)},
               new DiscountGoods(){name = "Bot giat",  price=50000,     goodsid="GG4",  quantity=50, productiondate= new DateTime(2021, 02, 15), shelflife= new DateTime(2023, 02, 15), promotion= new DateTime(2022, 01, 01)},
               new DiscountGoods(){name = "Noi com dien",   price=500000,    goodsid="GG5",  quantity=50, productiondate= new DateTime(2020, 05, 15), shelflife= new DateTime(2025, 05, 15), promotion= new DateTime(2022, 03, 06)},
               new DiscountGoods(){name = "Soong",     price=100000,    goodsid="GG6",  quantity=50, productiondate= new DateTime(2020, 07, 30), shelflife= new DateTime(2023, 07, 30), promotion= new DateTime(2022, 02, 04)},
               new DiscountGoods(){name = "Dau an",   price=20000,     goodsid="GG7",  quantity=50, productiondate= new DateTime(2020, 09, 10), shelflife= new DateTime(2024, 09, 10),promotion= new DateTime(2022, 03, 26)},
               new DiscountGoods(){name = "Nuoc mam",    price=250000,    goodsid="GG8",  quantity=50, productiondate= new DateTime(2019, 07, 07), shelflife= new DateTime(2023, 07, 07), promotion= new DateTime(2022, 01, 01)},
               new DiscountGoods(){name = "Quan jeans",price=12500000,  goodsid="GG9",quantity=50, productiondate= new DateTime(2020, 02, 15), shelflife= new DateTime(2022, 02, 15), promotion= new DateTime(2022, 01, 01)},
               new DiscountGoods(){name = "Nuoc Sting",  price=40000,    goodsid="GG10", quantity=50,productiondate= new DateTime(2020, 04, 01), shelflife= new DateTime(2022, 04, 01), promotion= new DateTime(2021, 12, 25)},
               new DiscountGoods(){name = "May say toc",  price=320000,    goodsid="GG11", quantity=50,productiondate= new DateTime(2021, 03, 01), shelflife= new DateTime(2023, 03, 01), promotion= new DateTime(2021, 12, 25)},
               new DiscountGoods(){name = "Bep dien",  price=2200000,   goodsid="GG12",quantity=50,productiondate= new DateTime(2020, 09, 10), shelflife = new DateTime(2023, 09, 10), promotion= new DateTime(2022, 02, 04)},
               new DiscountGoods(){name = "Bim bim",   price=10000,     goodsid="GG13", quantity=50,productiondate= new DateTime(2020, 12, 05), shelflife= new DateTime(2022, 12, 05), promotion= new DateTime(2022, 03, 06)},
               new DiscountGoods(){name = "Nuoc hoa",  price=200000,    goodsid="GG14",quantity=50,productiondate= new DateTime(2021, 08, 10), shelflife= new DateTime(2024, 08, 10), promotion= new DateTime(2022, 01, 01)},
               new DiscountGoods(){name = "Sua rua mat",price=350000,   goodsid="GG15",quantity=50,productiondate = new DateTime(2021, 01, 20), shelflife= new DateTime(2025, 01, 20), promotion= new DateTime(2022, 01, 01)},
               new DiscountGoods(){name = "Trai cam", price=200000,    goodsid="GG16",quantity=50,productiondate= new DateTime(2021, 05, 05), shelflife= new DateTime(2022, 05, 05), promotion= new DateTime(2021, 12, 25)},
        };
        public void AddDiscountGoods()
        {
            DiscountGoods newtk = new DiscountGoods();
            Console.Write("\n\t\t\t\t\tTen hang hoa: ");
            newtk.name = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tTien hang hoa: ");
            newtk.price = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tMa hang hoa giam gia: ");
            newtk.goodsid = Console.ReadLine();
            foreach (DiscountGoods tk in listdiscount)
            {
                while (tk.goodsid == newtk.goodsid)
                {
                    Console.WriteLine("\n\t\t\t\t\tDu lieu khong hop le Xin vui long nhap lai !!!");
                    Console.Write("\n\t\t\t\t\tMa hang hoa giam gia: ");
                    tk.goodsid = Console.ReadLine();
                }
            }
            Console.Write("\n\t\t\t\t\tSo Luong: ");
            newtk.quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tNSX (yyyy,mm,dd): ");
            newtk.productiondate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tHSD (yyyy,mm,dd): ");
            newtk.shelflife = Convert.ToDateTime(Console.ReadLine());
            if (newtk.shelflife.Year - newtk.productiondate.Year < 0)
            {
                Console.Write("\n\t\t\t\t\tNgay het han (yyyy,mm,dd): ");
                newtk.shelflife = Convert.ToDateTime(Console.ReadLine());
            }
            Console.Write("\n\t\t\t\t\tNgay giam gia (yyyy,mm,dd) :");
            newtk.promotion = Convert.ToDateTime(Console.ReadLine());
            listdiscount.Add(newtk);
        }
        public DiscountGoods FindByID(string Id)
        {
            DiscountGoods giamgia = null;
            if (listdiscount != null)
            {
                foreach (DiscountGoods tk in listdiscount)
                {
                    if (tk.goodsid == Id)
                    {
                        giamgia = tk;
                    }
                }
            }
            return giamgia;
        }
        public void Update(string Id)
        {
            ListDiscountGoods TK = new ListDiscountGoods();
            DiscountGoods Tk = FindByID(Id);
            OutPutDiscount(Tk);
            if (Tk != null)
            {
                while (true)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t\t\t\t========================= CHINH SUA HANG HOA GIAM GIA ========================");
                    Console.WriteLine("\t\t\t\t\t******************************************************************************");
                    Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |     1.   |      So luong                                           |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |     2.   |      Gia tien                                           |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |     0.   |      Thoat                                              |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*                                                                            *");
                    Console.WriteLine("\t\t\t\t\t******************************************************************************");
                    Console.WriteLine("\t\t\t\t\t==================================== END =====================================");
                    Console.Write("\n\t\t\t\t\tNhap Selection thong tin can sua: ");
                    int Selection;
                    Selection = int.Parse(Console.ReadLine());
                    switch (Selection)
                    {
                        case 1:
                            {
                                Console.Write("\n\t\t\t\t\tNhap so luong can sua: ");
                                Tk.quantity = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                                Console.WriteLine("\n\t\t\t\t\tDanh sach hang giam gia: ");
                                this.OutPutListDiscount(this.getListDiscount());
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                Console.Write("\n\t\t\t\t\tNhap gia tien can sua: ");
                                Tk.price = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                                Console.WriteLine("\n\t\t\t\t\tDanh sach hang giam gia ");
                                this.OutPutListDiscount(this.getListDiscount());
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 0:
                            {
                                Console.Clear();
                                return;
                            }
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tHang giam gia co Id {0} khong ton tai !!!", Id);
            }
        }
        public bool DeleteDiscount(string ID)
        {
            bool IsDelete = false;
            DiscountGoods tk = FindByID(ID);
            if (tk != null)
            {
                IsDelete = listdiscount.Remove(tk);
            }
            return IsDelete;
        }
        public void OutPutDiscount(DiscountGoods Tk)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t{0, -10} {1, -15} {2, -15} {3, -15} {4, -30} {5, -25} {6, -30}", "ID", "Ten SP", "Gia", "SL", "NSX", "HSD", "Ngay Giam Gia");
            Console.WriteLine("\n\t{0, -10} {1, -15} {2, -15} {3, -15} {4, -30} {5, -30} {6, -30}", Tk.goodsid, Tk.name, Tk.price, Tk.quantity, Tk.productiondate, Tk.shelflife, Tk.promotion);
        }
        public void OutPutListDiscount(List<DiscountGoods> listdiscount)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t{0, -10} {1, -15} {2, -17} {3, -23} {4, -30} {5, -25} {6, -30}", "ID", "Ten SP", "Gia", "SL", "NSX", "HSD", "Ngay Giam Gia");
            if (listdiscount != null)
            {
                foreach (DiscountGoods Tk in listdiscount)
                {
                    Console.WriteLine("\n\t\t");
                    Console.WriteLine("\t{0, -10} {1, -15} {2, -17} {3, -13} {4, -30} {5, -30} {6, -30}", Tk.goodsid, Tk.name, Tk.price, Tk.quantity, Tk.productiondate, Tk.shelflife, Tk.promotion);
                }
            }
        }
        public List<DiscountGoods> getListDiscount()
        {
            return listdiscount;
        }
        ~ListDiscountGoods()
        {
            Console.ReadKey();
        }
    }
}
