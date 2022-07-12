using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MainMenu
    {
        public MainMenu()
        {

        }
        public void MENU()
        {
            while (true )
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t======================== CHUONG TRINH QUAN LY SIEU THI =======================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    1.    |    Thong Thi Cua Sieu Thi                               |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    2.    |    Khach Hang                                           |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    3.    |    Nhan Vien                                            |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    4.    |    Hang Hoa                                             |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    5.    |    Hoa Don                                              |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    6.    |    Nha Cung Cap                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    7.    |    Doanh Thu                                            |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    8.    |    Ke Hoach Ban Hang                                    |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    0.    |    Thoat                                                |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*                                                                            *");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t================================== END =======================================");
                Console.Write("\n\t\t\t\t\tMoi nhap Selection thong tin can xem: ");
                int luachon;
                luachon = Convert.ToInt32(Console.ReadLine());
                if (luachon == 1)
                {
                    Console.Clear();
                    Supermarket SM = new Supermarket();
                    SM.InPut();
                    SM.OutPut();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (luachon == 2)
                {
                    Console.Clear();
                    MenuCustomer MNC = new MenuCustomer();
                    MNC.Menu();
                }
                else if (luachon == 3)
                {
                    Console.Clear();
                    MenuStaff mn = new MenuStaff();
                    mn.menu();

                }
                else if (luachon == 4)
                {
                    Console.Clear();
                    MenuGoods MG = new MenuGoods();
                    MG.Menu();
                }
                else if (luachon == 5)
                {
                    Console.Clear();
                    MenuBill MNB = new MenuBill();
                    MNB.Menu();
                }
                else if (luachon == 6)
                {
                    Console.Clear();
                    MenuSupplier MNS = new MenuSupplier();
                    MNS.Menu();
                }
                else if (luachon == 7)
                {
                    Console.Clear();
                    MenuTurnover MNT = new MenuTurnover();
                    MNT.Menu();
                }
                else if (luachon == 8)
                {
                    Console.Clear();
                    MenuSalesPlan MNS = new MenuSalesPlan();
                    MNS.Menu();
                }
                else if (luachon == 0)
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
        ~MainMenu()
        {
            Console.ReadKey();
        }
    }
}

