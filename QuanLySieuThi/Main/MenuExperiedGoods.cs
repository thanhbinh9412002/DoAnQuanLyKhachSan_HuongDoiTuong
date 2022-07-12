using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuExperiedGoods
    {
        public MenuExperiedGoods()
        {

        }
        public void Menu()
        {
            ListExperiedGoods ptg = new ListExperiedGoods();
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t============================= HANG HET HAN ===================================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     1.   |      Check hang het han                                 |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     2.   |      Them hang het han                                  |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     3.   |      Xem danh sach hang het han                         |  *");
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
                switch (Selection)
                {
                    case 1:
                        string Id;
                        Console.Write("\n\t\t\t\t\tNhap Id:  ");
                        Id = Console.ReadLine();
                        ExperiedGoods tk = new ExperiedGoods();
                        tk = ptg.FindByID(Id);
                        if (tk != null)
                        {
                            ptg.Display(tk);
                            Console.Write("\n\t\t\t\t\tNhap ngay hien tai kiem tra voi ngay het han (yyyy,mm,dd):  ");
                            DateTime NgayHienTai = Convert.ToDateTime(Console.ReadLine());
                            TimeSpan span = tk.shelflife - NgayHienTai;
                            if (span.TotalDays < 4 && span.TotalDays > 0)
                            {
                                tk.price = tk.price - tk.price * 0.5;
                                Console.WriteLine("\n\t\t\t\t\tGiam gia 50% !!!");
                                Console.WriteLine("\n\t\t\t\t\tTien san pham sau giam:  " + tk.price);
                            }
                            else if (span.TotalDays <= 7 && span.TotalDays >= 4)
                            {
                                tk.price = tk.price - tk.price * 0.3;
                                Console.WriteLine("\n\t\t\t\t\tGiam gia 30%  !!!");
                                Console.WriteLine("\n\t\t\t\t\tTien san pham sau giam:  " + tk.price);
                            }
                            else if (span.TotalDays <= 0)
                            {
                                Console.WriteLine("\n\t\t\t\t\tSan pham da het hang !!! ");
                                Console.Write("\n\t\t\t\t\tBan co muon xoa khong:(Y/N)  ");
                                string luachon = Console.ReadLine();
                                if (luachon == "Y" || luachon == "y")
                                {
                                    ptg.DeleteHangHetHan(Id);
                                    Console.WriteLine("\n\t\t\t\t\tXoa thanh cong !!!");
                                    Console.WriteLine("\n\t\t\t\t\tDanh sach hang hoa sau khi da xoa: ");
                                    ptg.DisPlayList(ptg.getListHangHH());

                                }
                                else if (luachon == "N" || luachon == "n")
                                {
                                    ptg.DisPlayList(ptg.getListHangHH());
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\tChua du dieu kien de giam gia !!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t\t\t\tKHONG TIM THAY !!!");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        {
                            ptg.AddHangHetHan();
                            Console.WriteLine("\n\t\t\t\t\tThem thanh cong !!!");
                            Console.WriteLine("\n\t\t\t\t\tDanh sach hang het han: ");
                            ptg.DisPlayList(ptg.getListHangHH());
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            ptg.DisPlayList(ptg.getListHangHH());
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("\n\t\t\t\t\tKhong co chuc nang nay !!!");
                            Console.WriteLine("\n\t\t\t\t\tMoi nhap lai !!!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
        ~MenuExperiedGoods()
        {
            Console.ReadKey();
        }
    }
}
