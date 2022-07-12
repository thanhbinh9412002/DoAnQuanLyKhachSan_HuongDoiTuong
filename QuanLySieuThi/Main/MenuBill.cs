using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuBill
    {
        public MenuBill()
        {

        }
        public void Menu()
        {
            ListBill b = new ListBill();
            ScoreCustomer SC = new ScoreCustomer();
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t============================= Hoa Don ==============================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     1.   |      Nhap hoa don                                       |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     2.   |      Xuat hoa don                                       |  *");
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
                    b.OutPut();
                    SC.Handle();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 2)
                {
                    b.XuatBill();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if ( Selection == 0)
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.WriteLine("\n\t\t\t\t\tKhong co chuc nang nay!");
                    Console.WriteLine("\n\t\t\t\t\tMoi nhap lai !!!");
                    Console.ReadKey();
                    Console.Clear();
                }    
            }
        }
        ~MenuBill()
        {
            Console.ReadKey();
        }
    }
}
