using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ListCustomer
    {
        private static List<Customer> listct = new List<Customer>() {
               new Customer(){fullname = "Nguyen Van A", address = "Phu Yen", phonenumber = "0921312412", gender = "Nam",diem=0, customerID = "KH1",},
               new Customer(){fullname = "Nguyen Van B", address = "Binh Dinh", phonenumber = "0382139843", gender = "Nam",diem=0, customerID = "KH2"},
               new Customer(){fullname = "Nguyen Van C", address = "Phu Tho", phonenumber = "0721321412", gender = "Nam", diem=0,customerID = "KH3"},
               new Customer(){fullname = "Tran Van D", address = "TPHCM", phonenumber = "0345788921", gender = "Nam", diem=1,customerID = "KH4"},
               new Customer(){fullname = "Le Van E", address = "Ha Noi", phonenumber = "0374544334", gender = "Nam", diem=0,customerID = "KH5"},
               new Customer(){fullname = "Le Thi F", address = "Bac Kan", phonenumber = "0321412552", gender = "Nu ",diem=0, customerID = "KH6"},
               new Customer(){fullname = "Tran Thi G", address = "Dak Lak", phonenumber = "0912321412", gender = "Nu", diem=10,customerID = "KH7"},
               new Customer(){fullname = "Hua Thi H", address = "Dak Nong", phonenumber = "0312312412", gender = "Nu", diem=0,customerID = "KH8"},
               new Customer(){fullname = "Cao Ngoc I", address = "Hai Phong", phonenumber = "0712341233", gender = "Nu", diem=50,customerID = "KH9"},
               new Customer(){fullname = "Vo Diem J", address = "Nghe An", phonenumber = "0312451232", gender = "Nu",diem=0, customerID = "KH10"},
        };
        public Customer CustomerFindById(string ID)
        {
            Customer KhachHang = null;
            if (listct != null)
            {
                foreach (Customer kh in listct)
                {
                    if (kh.customerID == ID)
                    {
                        KhachHang = kh;
                    }
                }
            }
            return KhachHang;
        }
        public void AddCustomer()
        {
            Customer ct = new Customer();
            Console.Write("\n\t\t\t\t\tHo ten: ");
            ct.fullname = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tDia chi: ");
            ct.address = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tSDT: ");
            ct.phonenumber = Console.ReadLine();
            foreach (Customer kh in listct)
            {
                while (kh.phonenumber == ct.phonenumber)
                {
                    Console.WriteLine("\n\t\t\t\t\tDu lieu khong hop le Xin vui long nhap lai!!");
                    Console.Write("\n\t\t\t\t\tSDT: ");
                    ct.phonenumber = Console.ReadLine();
                }
            }
            Console.Write("\n\t\t\t\t\tGioi tinh: ");
            ct.gender = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tMa khach hang: ");
            ct.customerID = Console.ReadLine();
            foreach (Customer nv in listct)
            {
                while (nv.customerID == ct.customerID)
                {
                    Console.WriteLine("\n\t\t\t\t\tDu lieu khong hop le Xin vui long nhap lai!!");
                    ct.customerID = Console.ReadLine();
                }
            }
            listct.Add(ct);
        }

        public void UpDate(string Customerids)
        {
            Customer ct = CustomerFindById(Customerids);
            if (ct != null)
            {
                OutPutCustomer(ct);
                while (true)
                {
                    Console.WriteLine("\n\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\t\t================================ THONG TIN KHACH HANG  =======================");
                    Console.WriteLine("\t\t\t\t\t******************************************************************************");
                    Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    1.    |      Ho va ten                                          |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    2.    |      Dia chi                                            |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    3.    |      So dien thoai                                      |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    4.    |      Gioi tinh                                          |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    5.    |      Ma khach hang                                      |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    0.    |      Thoat                                              |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*                                                                            *");
                    Console.WriteLine("\t\t\t\t\t******************************************************************************");
                    Console.WriteLine("\t\t\t\t\t==================================== END =====================================");
                    int Selection;
                    Console.Write("\n\t\t\t\t\tNhap Selection can chinh sua: ");
                    Selection = int.Parse(Console.ReadLine());
                    if (Selection == 1)
                    {
                        Console.Write("\n\t\t\t\t\tNhap ho ten khach hang can sua:  ");
                        string fullNames = Console.ReadLine();
                        ct.fullname = fullNames;
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach khach hang ");
                        this.OutPut(this.OutPutCustomerList());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 2)
                    {
                        Console.Write("\n\t\t\t\t\tNhap dia chi khach hang can sua:  ");
                        string addRess = Console.ReadLine();
                        ct.address = addRess;
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach khach hang: ");
                        this.OutPut(this.OutPutCustomerList());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 3)
                    {
                        Console.Write("\n\t\t\t\t\tNhap SDT khach hang can sua: ");
                        string phoneNumbers = Console.ReadLine();
                        ct.phonenumber = phoneNumbers;
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong");
                        this.OutPut(this.OutPutCustomerList());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 4)
                    {
                        Console.Write("\n\t\t\t\t\tNhap gioi tinh khach hang can sua: ");
                        string genDer = Console.ReadLine();
                        ct.gender = genDer;
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong");
                        this.OutPut(this.OutPutCustomerList());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 5)
                    {
                        Console.Write("\n\t\t\t\t\tNhap ma khach hang can sua: ");
                        string customerIDs = Console.ReadLine();
                        ct.customerID = customerIDs;
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong");
                        this.OutPut(this.OutPutCustomerList());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tKhach hang co ID {0} khong ton tai", Customerids);
            }
        }
        public bool DeleteCustomer(string ID)
        {
            bool Deletect = false;
            Customer kh = CustomerFindById(ID);
            if (kh != null)
            {
                Deletect = listct.Remove(kh);
            }
            return Deletect;
        }
        public void OutPutCustomer(Customer ct)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t\t\t\t\t{0, -7} {1, -13} {2, -17} {3, -10} {4, -15} {5,-15} ", "ID", "Ho Ten", "Dia Chi", "SDT", "Gioi Tinh", "Diem");
            Console.WriteLine("\n\t\t\t\t\t{0, -5} {1, -15} {2, -15} {3, -15} {4, -13} {5,-15}", ct.customerID, ct.fullname, ct.address, ct.phonenumber, ct.gender, ct.diem);
        }
        public void OutPut(List<Customer> listct)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t\t\t\t\t{0, -7} {1, -13} {2, -17} {3, -10} {4, -15} {5,-15} ", "ID", "Ho Ten" ,"Dia Chi", "SDT", "Gioi Tinh", "Diem");
            if (listct != null)
            {
                foreach (Customer ct in listct)
                {
                    Console.WriteLine("\n\t\t");
                    Console.WriteLine("\t\t\t\t\t{0, -5} {1, -15} {2, -15} {3, -15} {4, -13} {5,-15}", ct.customerID, ct.fullname, ct.address, ct.phonenumber, ct.gender,ct.diem);
                }
            }
        }
        public List<Customer> OutPutCustomerList()
        {
            return listct;
        }
        ~ListCustomer()
        {
            Console.ReadKey();
        }
    }
}
