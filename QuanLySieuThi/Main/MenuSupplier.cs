using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuSupplier
    {
        public MenuSupplier()
        {

        }
        public void Menu()
        {
            Supplier SPL = new Supplier();
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t================================= NHA CUNG UNG ===============================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    1.    |      Cung ung hang hoa                                  |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    2.    |      Cho thue mat bang                                  |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    0.    |      Thoat                                              |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*                                                                            *");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t==================================== END =====================================");
                Console.Write("\n\t\t\t\t\tNhap Selection thong tin can xem: ");
                int Selection;
                Selection = int.Parse(Console.ReadLine());
                if (Selection == 1)
                {
                    Console.Clear();
                    MenuSupplierGoods MNG = new MenuSupplierGoods();
                    MNG.Menu();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 2)
                {
                    Console.Clear();
                    MenuProvidePremises Mn = new MenuProvidePremises();
                    Mn.Menu();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 0)
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
        ~MenuSupplier()
        {
            Console.ReadKey();
        }
    }
}
