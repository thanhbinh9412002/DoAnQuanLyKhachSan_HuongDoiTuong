using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ListInventoryGoods
    {
        private static List<InventoryGoods> listinventory = new List<InventoryGoods>() {
               new InventoryGoods(){name = "Sua",       price=21000, goodsid="TK1",  quantity=500, productiondate= new DateTime(2020, 10, 12), shelflife=new DateTime(2022, 12, 12)},
               new InventoryGoods(){name = "Nuoc ngot", price=30000, goodsid="TK2",  quantity=1000, productiondate=new DateTime(2020, 02, 20), shelflife=new DateTime(2021, 02, 20)},
               new InventoryGoods(){name = "Keo deo",   price=10000, goodsid="TK3",  quantity=500, productiondate=new DateTime(2020, 07, 07), shelflife=new DateTime(2021, 07, 07)},
               new InventoryGoods(){name = "Socola",    price=50000, goodsid="TK4",  quantity=500, productiondate=new DateTime(2020, 02, 15), shelflife=new DateTime(2022, 02, 15)},
               new InventoryGoods(){name = "Qua nho",   price=150000,goodsid="TK5",  quantity=300, productiondate=new DateTime(2021, 05, 15), shelflife=new DateTime(2021, 12, 15)},
               new InventoryGoods(){name = "Bia",       price=350000,goodsid="TK6",  quantity=500, productiondate=new DateTime(2021, 07, 30), shelflife=new DateTime(2021, 10, 30)},
               new InventoryGoods(){name = "Rau cai",   price=20000, goodsid="TK7",  quantity=400, productiondate=new DateTime(2021, 09, 10), shelflife=new DateTime(2021, 10, 10)},
               new InventoryGoods(){name = "Ca hoi",    price=250000,goodsid="TK8",  quantity=200, productiondate=new DateTime(2021, 10, 07), shelflife=new DateTime(2021, 12, 07)},
               new InventoryGoods(){name = "Quan jeans",price=12500000,goodsid="TK9",quantity=100, productiondate=new DateTime(2020, 02, 15), shelflife=new DateTime(2022, 02, 15)},
               new InventoryGoods(){name = "Ao so mi",  price=880000,goodsid="TK10", quantity=500,productiondate=new DateTime(2020, 04, 01), shelflife=new DateTime(2022, 04, 01)},
               new InventoryGoods(){name = "Bot giat",  price=320000,goodsid="TK11", quantity=1000,productiondate=new DateTime(2021, 03, 01), shelflife=new DateTime(2023, 03, 01)},
               new InventoryGoods(){name = "Bep dien",  price=2200000,goodsid="TK12",quantity=500,productiondate=new DateTime(2020, 09, 10), shelflife=new DateTime(2023, 09, 10)},
               new InventoryGoods(){name = "Bim bim",   price=10000, goodsid="TK13", quantity=2000,productiondate=new DateTime(2020, 12, 05), shelflife=new DateTime(2022, 12, 05)},
               new InventoryGoods(){name = "Nuoc hoa",  price=200000, goodsid="TK14",quantity=500,productiondate=new DateTime(2021, 08, 10), shelflife=new DateTime(2024, 08, 10)},
               new InventoryGoods(){name = "Sua rua mat",price=350000, goodsid="TK15",quantity=5000,productiondate=new DateTime(2021, 01, 20), shelflife=new DateTime(2025, 01, 20)},
               new InventoryGoods(){name = "Banh ngot", price=200000, goodsid="TK16",quantity=500,productiondate=new DateTime(2021, 05, 05), shelflife=new DateTime(2023, 05, 05)},
        };
        public void AddInventory()
        {
            InventoryGoods newtk = new InventoryGoods();
            Console.Write("\n\t\t\t\t\tTen Hang Hoa: ");
            newtk.name = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tTien Hang Hoa: ");
            newtk.price = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tMa Hang Hoa Ton Kho: ");
            newtk.goodsid = Console.ReadLine();
            foreach (InventoryGoods tk in listinventory)
            {
                while (tk.goodsid == newtk.goodsid)
                {
                    Console.WriteLine("\n\t\t\t\t\tDu lieu khong hop le Xin vui long nhap lai !!!");
                    Console.Write("\n\t\t\t\t\tMa Hang Hoa Ton Kho: ");
                    newtk.goodsid = Console.ReadLine();
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
                Console.Write("\n\t\t\t\t\tNgay Het Han (yyyy,mm,dd): ");
                newtk.shelflife = Convert.ToDateTime(Console.ReadLine());
            }
            listinventory.Add(newtk);
        }
        public InventoryGoods FindByID(string Id)
        {
            InventoryGoods TonKho = null;
            if (listinventory != null)
            {
                foreach (InventoryGoods tk in listinventory)
                {
                    if (tk.goodsid == Id)
                    {
                        TonKho = tk;
                    }
                }
            }
            return TonKho;
        }
        public void Update(string Id)
        {
            InventoryGoods Tk = FindByID(Id);
            OutPutInventory(Tk);
            if (Tk != null)
            {

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t\t\t\t============================== THONG TIN HANG TON KHO ========================");
                    Console.WriteLine("\t\t\t\t\t******************************************************************************");
                    Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    1.    |      So Luong                                           |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    2.    |      Gia Tien                                           |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    0.    |      Thoat                                              |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*                                                                            *");
                    Console.WriteLine("\t\t\t\t\t******************************************************************************");
                    Console.WriteLine("\t\t\t\t\t==================================== END =====================================");
                    int Selection;
                    Console.Write("\n\t\t\t\t\tNhap Selection can chinh sua: ");
                    Selection = int.Parse(Console.ReadLine());
                    if (Selection == 1)
                    {
                        Console.Write("\n\t\t\t\t\tNhap so luong can sua: ");
                        Tk.quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach hang ton kho ");
                        this.OutPutListInventory(this.getListInventory());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 2)
                    {
                        Console.Write("\n\t\t\t\t\tNhap gia tien can sua: ");
                        Tk.price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach hang ton kho ");
                        this.OutPutListInventory(this.getListInventory());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tHang ton kho co Id {0} khong ton tai !!!", Id);
            }
        }
        public bool DeleteInventory(string ID)
        {
            bool IsDelete = false;
            InventoryGoods tk = FindByID(ID);
            if (tk != null)
            {
                IsDelete = listinventory.Remove(tk);
            }
            return IsDelete;
        }
        public void OutPutInventory(InventoryGoods Tk)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t{0, -15} {1, -16} {2, -15} {3, -19} {4, -30} {5, -8}", "ID", "Ten SP", "Gia", "SL", "NSX", "HSD");
            Console.WriteLine("\n\t{0, -15} {1, -15} {2, -16} {3, -12} {4, -30} {5, -8}", Tk.goodsid, Tk.name, Tk.price, Tk.quantity, Tk.productiondate, Tk.shelflife);
        }
        public void OutPutListInventory(List<InventoryGoods> listinventory)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t{0, -15} {1, -16} {2, -15} {3, -19} {4, -30} {5, -8}", "ID", "Ten SP", "Gia", "SL", "NSX", "HSD");
            if (listinventory != null)
            {
                foreach (InventoryGoods Tk in listinventory)
                {
                    Console.WriteLine("\n\t\t");
                    Console.WriteLine("\t{0, -15} {1, -15} {2, -16} {3, -12} {4, -30} {5, -8}", Tk.goodsid, Tk.name, Tk.price, Tk.quantity, Tk.productiondate, Tk.shelflife);
                }
            }
        }
        public List<InventoryGoods> getListInventory()
        {
            return listinventory;
        }
        ~ListInventoryGoods()
        {
            Console.ReadKey();
        }
    }
}
