using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuDiscountGoods
    {
        public MenuDiscountGoods()
        {

        }
        public void Menu()
        {
            ListDiscountGoods HangGiamGia = new ListDiscountGoods();
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t\t============================= QUAN LY HANG GIAM GIA ==========================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     1.   |      Them hang hang giam gia                            |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     2.   |      Cap nhat thong tin hang giam gia                   |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     3.   |      Xoa hang hoa boi ID                                |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |     4.   |      Tim kiem hang giam gia                             |  *");
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
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\t\t\t\t\t1. Them hang hoa");
                            HangGiamGia.AddDiscountGoods();
                            Console.WriteLine("\n\t\t\t\t\tThem hang hoa thanh cong !!!");
                            Console.WriteLine("\n\t\t\t\t\tDanh sach hang giam gia: ");
                            HangGiamGia.OutPutListDiscount(HangGiamGia.getListDiscount());
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            string Id;
                            Console.WriteLine("\n\t\t\t\t\t2. Cap nhat thong tin hang hoa ");
                            Console.Write("\n\t\t\t\t\tNhap Id hang hoa: ");
                            Id = Console.ReadLine();
                            HangGiamGia.Update(Id);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            string Id1;
                            Console.WriteLine("\n\t\t\t\t\t3. Xoa hang hoa ");
                            Console.Write("\n\t\t\t\t\tNhap Id hang hoa can xoa: ");
                            Id1 = Console.ReadLine();
                            if (HangGiamGia.DeleteDiscount(Id1))
                            {
                                Console.WriteLine("\n\t\t\t\t\tXoa hang hoa thanh cong !!!");
                                Console.WriteLine("\n\t\t\t\t\tDanh sach hang giam gia: ");
                                HangGiamGia.OutPutListDiscount(HangGiamGia.getListDiscount());
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\tXoa khong thanh cong !!!");
                                Console.WriteLine("\n\t\t\t\t\tDanh sach hang giam gia: ");
                                HangGiamGia.OutPutListDiscount(HangGiamGia.getListDiscount());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            string Id2;
                            Console.WriteLine("\n\t\t\t\t\t4.Tim kiem hang giam gia ");
                            Console.Write("\n\t\t\t\t\tNhap Id hang hoa can tim kiem: ");
                            Id2 = Console.ReadLine();
                            DiscountGoods Tk = HangGiamGia.FindByID(Id2);
                            if (Tk != null)
                            {
                                HangGiamGia.OutPutDiscount(Tk);
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\tKhong tim thay hang hoa co ID: {0} nay trong danh sach !!!", Id2);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            HangGiamGia.OutPutListDiscount(HangGiamGia.getListDiscount());
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
                            Console.WriteLine("\n\t\t\t\t\tKhong co chuc nang nay!");
                            Console.WriteLine("\n\t\t\t\t\tMoi nhap lai !!!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
        ~MenuDiscountGoods()
        {
            Console.ReadKey();
        }
    }
}
