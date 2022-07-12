using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class MenuCustomer 
    {
        public MenuCustomer()
        {

        }
        public void Menu()
        {
            ListCustomer QuanLyKhachHang = new ListCustomer();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t\t============================== QUAN LY KHACH HANG ============================");
                Console.WriteLine("\t\t\t\t\t******************************************************************************");
                Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    1.    |      Tim kiem khach hang                                |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    2.    |      Them khach hang vao danh sach                      |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    3.    |      Chinh sua thong tin khach hang                     |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    4.    |      Xoa thong tin khach hang                           |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    5.    |      Kiem tra Rank khach hang                           |  *");
                Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                Console.WriteLine("\t\t\t\t\t*    |    6.    |      Xuat danh sach khach hang                          |  *");
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
                    string id1;
                    Console.WriteLine("\n\t\t\t\t\tTim kiem khach hang");
                    Console.Write("\n\t\t\t\t\tNhap ID khach hang can tim kiem: ");
                    id1 = Console.ReadLine();
                    Customer ct = QuanLyKhachHang.CustomerFindById(id1);
                    if (ct != null)
                    {
                        QuanLyKhachHang.OutPutCustomer(ct);
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\tKhong tim thay khach co ID: {0} nay trong danh sach !!!", id1);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 2)
                {
                    QuanLyKhachHang.AddCustomer();
                    Console.WriteLine("\n\t\t\t\t\tThem khach hang thanh cong!!");
                    Console.WriteLine("\n\t\t\t\t\tDanh sach khach hang ");
                    QuanLyKhachHang.OutPut(QuanLyKhachHang.OutPutCustomerList());
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 3)
                {
                    Console.Clear();
                    string id3;
                    Console.Write("\n\t\t\t\t\tNhap id khach hang : ");
                    id3 = Console.ReadLine();
                    QuanLyKhachHang.UpDate(id3);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 4)
                {
                    string id4;
                    Console.Write("\n\t\t\t\t\tNhap id khach hang can xoa: ");
                    id4 = Console.ReadLine();
                    if (QuanLyKhachHang.DeleteCustomer(id4))
                    {
                        Console.WriteLine("\n\t\t\t\t\tXoa khach hang thanh cong!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach khach hang ");
                        QuanLyKhachHang.OutPut(QuanLyKhachHang.OutPutCustomerList());
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t\t\tXoa khong thanh cong !!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach khach hang: ");
                        QuanLyKhachHang.OutPut(QuanLyKhachHang.OutPutCustomerList());
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 5)
                {
                    Customer Cs = new Customer();
                    Console.Write("\n\t\t\t\t\t Nhap Id : ");
                    Cs.customerID = Console.ReadLine();
                    Cs = QuanLyKhachHang.CustomerFindById(Cs.customerID);
                    QuanLyKhachHang.OutPutCustomer(Cs);
                    Cs.CheckRank(Cs.diem);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Selection == 6)
                {
                    QuanLyKhachHang.OutPut(QuanLyKhachHang.OutPutCustomerList());
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
        ~MenuCustomer()
        {
            Console.ReadKey();
        }
    }
}
