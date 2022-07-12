using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuSalesPlan
    {
        public MenuSalesPlan()
        {

        }
        public void Menu()
        {
            SalesPlan SP = new SalesPlan();

            int luachon;
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t============================= Ke hoach ban hang ==============================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    1.    |      Kiem tra doanh thu                                 |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    0.    |      Thoat                                              |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*                                                                            *");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t==================================== END =====================================");
                Console.Write("\n\t\t\t\t\tNhap Selection thong tin can xem: ");
                luachon = Convert.ToInt32(Console.ReadLine());
                if (luachon == 1)
                {
                    Console.WriteLine("\n\t\t\t\t\t{0}",SP.checkKPIMonth(1000000));
                    Console.ReadKey();
                    Console.Clear();
                }
                else if ( luachon == 0)
                {
                    Console.Clear();
                    return;
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
        ~MenuSalesPlan()
        {
            Console.ReadKey();
        }
    }
}
