using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuPotentialGoods
    {
        public MenuPotentialGoods()
        {

        }
        public void Menu()
        {
            ListPotetialGoods ptg = new ListPotetialGoods();
            PotentialGoods PG = new PotentialGoods();
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t============================= HANG TIEM NANG ==============================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     1.   |      Tim hang tiem nang                                 |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     2.   |      Them hang tiem nang                                |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     3.   |      Update gia hang tiem nang                          |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     4.   |      Xem danh sach hang tiem nang                       |  *");
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
                    string Id;
                    Console.Write("\n\t\t\t\t\tNhap Id: ");
                    Id = Console.ReadLine();
                    PG = ptg.FindByID(Id);
                    ptg.OutPutGoods(PG);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 2)
                {
                    ptg.Them();
                    Console.WriteLine("\n\t\t\t\t\tThem thanh cong !!!!");
                    Console.WriteLine("\n\t\t\t\t\tDanh sach hang tiem nang: ");
                    ptg.Display(ptg.getListPotentialGoods());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 3)
                {
                    Console.Write("\n\t\t\t\t\tNhap vao Id hang can Update: ");
                    string Id1 = Console.ReadLine();
                    ptg.UpdatePrice(Id1);
                    Console.WriteLine("\n\t\t\t\t\tCap nhat gia thanh cong !!!");
                    Console.WriteLine("\n\t\t\t\t\tDanh sach hang tiem nang: ");
                    ptg.Display(ptg.getListPotentialGoods());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 4)
                {
                    ptg.Display(ptg.getListPotentialGoods());
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
        ~MenuPotentialGoods()
        {
            Console.ReadKey();
        }
    }
}
