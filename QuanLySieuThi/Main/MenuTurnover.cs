using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuTurnover
    {
        public MenuTurnover()
        {

        }
        public void Menu()
        {
            Turnover tnv = new Turnover();
            CostGoods CG = new CostGoods();
            CostStaff CS = new CostStaff();
            CostProvidePremises CP = new CostProvidePremises();
            double Tongchiphi = CG.chiPhi() + CS.Chiphi() + CP.Chiphi();
            double TongDoanhThu = tnv.Doanhthu();
            double LoiNhuan = TongDoanhThu - Tongchiphi;
            while (true)
            { 
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t============================= QUAN LY DOANH THU ==============================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    1.    |      Tong doanh thu                                     |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    2.    |      Tong chi phi                                       |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    3.    |      Loi nhuan                                          |  *");
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
                    Console.WriteLine("\n\t\t\t\t\tTong doanh thu:  {0}  VND ", TongDoanhThu);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 2)
                {
                    Console.WriteLine("\n\t\t\t\t\tChi phi luong nhan vien: {0} VND ", CS.Chiphi());
                    Console.WriteLine("\n\t\t\t\t\tChi phi mua hang: {0} VND ",  CG.chiPhi());
                    Console.WriteLine("\n\t\t\t\t\tChi phi cho mat bang:  {0}  VND", CP.Chiphi());
                    Console.Write("\n\t\t\t\t\tTong Chi Phi: {0} VND", Tongchiphi);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 3)
                {
                    Console.WriteLine("\n\t\t\t\t\tLoi nhuan: {0} VND", LoiNhuan);
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
        ~MenuTurnover()
        {
            Console.ReadKey();
        }
    }
}
