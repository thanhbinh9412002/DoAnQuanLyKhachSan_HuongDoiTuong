using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuGoods
    {
        public MenuGoods()
        {

        }
        public void Menu()
        {
            ListGoods LG = new ListGoods();
            SupplyOfGoods SP = new SupplyOfGoods();
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t================================ QUAN LY HANG HOA ============================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     1.   |      Hang ton kho                                       |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     2.   |      Hang het han                                       |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     3.   |      Hang giam gia                                      |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     4.   |      Hang tiem nang                                     |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     5.   |      Hien thi danh sach hang hoa                        |  *");
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
                    Console.Clear();
                    MenuInventoryGoods MI = new MenuInventoryGoods();
                    MI.Menu();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 2)
                {
                    Console.Clear();
                    MenuExperiedGoods ME = new MenuExperiedGoods();
                    ME.Menu();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 3)
                {
                    Console.Clear();
                    MenuDiscountGoods MD = new MenuDiscountGoods();
                    MD.Menu();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 4)
                {
                    Console.Clear();
                    MenuPotentialGoods MP = new MenuPotentialGoods();
                    MP.Menu();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 5)
                {
                    Console.Clear();
                    LG.OutPut();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 0)
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
        ~MenuGoods()
        {
            Console.ReadKey();
        }
    }
}
