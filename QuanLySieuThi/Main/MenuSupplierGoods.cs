using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuSupplierGoods
    {
        public MenuSupplierGoods()
        {

        }
        public void Menu()
        {
            SupplyOfGoods sog = new SupplyOfGoods();
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t================================ QUAN LY CUNG UNG HANG HOA ===================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     1.   |      Nhap hang                                          |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     2.   |      Thanh toan                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     0.   |      Thoat                                              |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*                                                                            *");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t==================================== END =====================================");
                Console.Write("\n\t\t\t\t\tNhap Selection thong tin can xem: ");
                int Selection;
                Selection = int.Parse(Console.ReadLine());
                if (Selection == 1)
                {
                    sog.InPutSupplyofgoods();
                    Console.WriteLine("\n\t\t\t\t\tNhap hang thanh cong !!!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 2)
                {
                    Console.WriteLine("\n\t\t\t\t\tGia tien cho don nay la:  {0} VND ",  sog.PayMoneyGoods());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if ( Selection == 0)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("\n\t\t\t\t\tKhong co chuc nang nay !!!");
                    Console.WriteLine("\n\t\t\t\t\tMoi nhap lai !!!");
                    Console.ReadKey();
                    Console.Clear();
                }    
            }
        }
        ~MenuSupplierGoods()
        {
            Console.ReadKey();
        }
    }
}
