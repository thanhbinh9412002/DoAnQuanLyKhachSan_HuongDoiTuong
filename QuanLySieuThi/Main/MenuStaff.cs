using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuStaff
    {
        public MenuStaff()
        {

        }
        public void menu()
        {
            ListStaff listStaff = new ListStaff();
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t============================= QUAN LY NHAN VIEN ==============================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    1.    |      Them nhan vien                                     |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    2.    |      Cap nhat nhan vien boi ID                          |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    3.    |      Xoa nhan vien boi ID                               |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    4.    |      Tim kiem nhan vien theo ID                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    5.    |      Hien thi danh sach nhan vien                       |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    6.    |      Tinh luong                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    7.    |      Tinh luong thuong cuoi nam                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    0.    |      Thoat                                              |  *");
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
                            Console.Clear();
                            Console.WriteLine("\n\t\t\t\t\t1. Them nhan vien ");
                            listStaff.AddStaff();
                            Console.WriteLine("\n\t\t\t\t\tThem nhan vien thanh cong !!!");
                            Console.WriteLine("\n\t\t\t\t\tDanh sach nhan vien: ");
                            listStaff.Show(listStaff.getListNhanVien());
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            string Id;
                            Console.WriteLine("\n\t\t\t\t\t2. Cap nhat thong tin nhan vien");
                            Console.Write("\n\t\t\t\t\tNhap Id nhan vien: ");
                            Id = Console.ReadLine();
                            listStaff.UpDate(Id);
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            string Id1;
                            Console.WriteLine("\n\t\t\t\t\t3. Xoa nhan vien ");
                            Console.Write("\n\t\t\t\t\tNhap Id nhan vien can xoa: ");
                            Id1 = Console.ReadLine();
                            if (listStaff.DeleteStaff(Id1))
                            {
                                Console.WriteLine("\n\t\t\t\t\tXoa nhan vien thanh cong !!!");
                                Console.WriteLine("\n\t\t\t\t\tDanh sach nhan vien: ");
                                listStaff.Show(listStaff.getListNhanVien());
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\tXoa khong thanh cong !!!");
                                Console.WriteLine("\n\t\t\t\t\tDanh sach nhan vien: ");
                                listStaff.Show(listStaff.getListNhanVien());
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            string Id2;
                            Console.WriteLine("\n\t\t\t\t\t4.Tim kiem nhan vien ");
                            Console.Write("\n\t\t\t\t\tNhap Id nhan vien can tim kiem: ");
                            Id2 = Console.ReadLine();
                            Staff Nv = listStaff.FindByID(Id2);
                            if (Nv != null)
                            {
                                listStaff.ShowStaff(Nv);
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t\t\tKHONG TIM THAY !!!");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            listStaff.Show(listStaff.getListNhanVien());
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            double Luong = listStaff.TinhLuong();
                            Double dc = Math.Round((Double)Luong, 0);
                            Console.WriteLine("\n\t\t\t\t\tTien Luong: " + dc);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 7:
                        {
                            string Id4;
                            Console.Write("\n\t\t\t\t\tNhap Id nhan vien: ");
                            Id4 = Console.ReadLine();
                            Staff Nv2 = listStaff.FindByID(Id4);
                            if (Nv2 != null)
                            {
                                listStaff.ShowStaff(Nv2);
                                Console.WriteLine("\n\t\t\t\t\tLuong thuong : " + listStaff.LuongThuong(Nv2));
                            }
                            else
                                Console.WriteLine("\n\t\t\t\t\tKhong tim thay !!!");
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
        ~MenuStaff()
        {
            Console.ReadKey();
        }
    }
}
