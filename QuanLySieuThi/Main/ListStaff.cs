using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ListStaff
    {
        private static List<Staff> ListNhanVien = new List<Staff>() {
               new Staff(){fullname = "Nguyen Van A",  address = "Phu Yen", phonenumber = "0921312412", gender = "Nam", identitycard = "113203458712", staffID = "BV1",  position = "Bao ve",dayOfBirth=new DateTime(1981, 12, 12)},
               new Staff(){fullname = "Nguyen Van B", address = "Binh Dinh", phonenumber = "0382139843", gender = "Nam", identitycard = "123487900982", staffID = "BV2",  position = "Bao ve",dayOfBirth=new DateTime(1983, 03, 12)},
               new Staff(){fullname = "Nguyen Van C",  address = "Phu Tho", phonenumber = "0721321412", gender = "Nam", identitycard = "087980912314", staffID = "BV3",  position = "Bao ve",dayOfBirth=new DateTime(1965, 02, 17)},
               new Staff(){fullname = "Tran Van D",  address = "TPHCM", phonenumber = "0345788921", gender = "Nam", identitycard = "123122412412", staffID = "BV4",  position = "Bao ve",dayOfBirth=new DateTime(1976, 08, 09)},
               new Staff(){fullname = "Le Van E",  address = "Ha Noi", phonenumber = "0374544334", gender = "Nam", identitycard = "131242159090", staffID = "BV5",  position = "Bao ve",dayOfBirth=new DateTime(1981, 07, 07)},
               new Staff(){fullname = "Le Thi F",  address = "Bac Kan", phonenumber = "0321412552", gender = "Nu ", identitycard = "231231231241", staffID = "TN1",  position = "Thu Ngan",dayOfBirth=new DateTime(2001, 04, 14)},
               new Staff(){fullname = "Tran Thi G",  address = "Dak Lak", phonenumber = "0912321412", gender = "Nu", identitycard = "312312412411", staffID = "TN2",  position = "Thu Ngan",dayOfBirth=new DateTime(2000, 05, 16)},
               new Staff(){fullname = "Hua Thi H",  address = "Dak Nong", phonenumber = "0312312412", gender = "Nu", identitycard = "123213213213", staffID = "TN3",  position = "Thu Ngan",dayOfBirth=new DateTime(2002, 05, 17)},
               new Staff(){fullname = "Cao Ngoc I",  address = "Hai Phong", phonenumber = "0712341233", gender = "Nu", identitycard = "124523241231", staffID = "TN4",  position = "Thu Ngan",dayOfBirth=new DateTime(2003, 07, 29)},
               new Staff(){fullname = "Vo Diem J",  address = "Nghe An", phonenumber = "0312451232", gender = "Nu", identitycard = "442232141232", staffID = "TN5",  position = "Thu Ngan",dayOfBirth=new DateTime(1999, 8, 31)},
               new Staff(){fullname = "Tran Le K",  address = "Ha Tinh", phonenumber = "0912313213", gender = "Nu", identitycard = "122145678532", staffID = "XH1",  position = "Xep Hang",dayOfBirth=new DateTime(2003, 9, 6)},
               new Staff(){fullname = "Nguyen My L",  address = "Thanh Hoa", phonenumber = "0954365433", gender = "Nam", identitycard = "123246673763", staffID = "XH2",  position = "Xep Hang",dayOfBirth=new DateTime(1998, 11, 7)},
               new Staff(){fullname = "Thieu Van M",  address = "Quang Nam", phonenumber = "0341231241", gender = "Nam", identitycard = "125797534635", staffID = "XH3",  position = "Xep Hang",dayOfBirth=new DateTime(1997, 2, 12)},
               new Staff(){fullname = "Dinh Thai N",  address = "Khanh Hoa", phonenumber = "0725536875", gender = "Nu ", identitycard = "546775432168", staffID = "XH4",  position = "Xep Hang",dayOfBirth=new DateTime(1996, 12, 15)},
               new Staff(){fullname = "Ngo Nhat O",  address = "Ha Nam", phonenumber = "0912325466", gender = "Nam", identitycard = "432526732313", staffID = "XH5",  position = "Xep Hang",dayOfBirth=new DateTime(1994, 4, 1)},
               new Staff(){fullname = "Nguyen Thi P",  address = "Ha Nam", phonenumber = "0986534123", gender = "Nu", identitycard = "321321421563", staffID = "VS1",  position = "Ve Sinh",dayOfBirth=new DateTime(1982, 5, 2)},
               new Staff(){fullname = "Tran Thi Q",  address = "Bac Ninh", phonenumber = "0341543645", gender = "Nu", identitycard = "879565644324", staffID = "VS2",  position = "Ve Sinh",dayOfBirth=new DateTime(1981, 3, 1)},
               new Staff(){fullname = "Doan Thi R",  address = "Son La", phonenumber = "0912315656", gender = "Nu", identitycard = "234356346743", staffID = "VS3",  position = "Ve Sinh",dayOfBirth=new DateTime(1980, 11, 4)},
               new Staff(){fullname = "Vo Thi S ", address = "Ha Giang", phonenumber = "0345678975", gender = "Nu", identitycard = "345346223435", staffID = "VS4",  position = "Ve Sinh",dayOfBirth=new DateTime(1979, 12, 5)},
               new Staff(){fullname = "Phung Thi T",  address = "An Giang", phonenumber = "0341656512", gender = "Nu", identitycard = "213244365656", staffID = "VS5",  position = "Ve Sinh",dayOfBirth=new DateTime(1978, 1, 6)},
               new Staff(){fullname = "Tran Thai U",  address = "Ninh Binh", phonenumber = "0965676856", gender = "Nam", identitycard = "232678564543", staffID = "GX1",  position = "Giu Xe",dayOfBirth=new DateTime(1980, 8, 7)},
               new Staff(){fullname = "Dinh Van V",  address = "Thai Binh", phonenumber = "0343563454", gender = "Nam", identitycard = "363454363464", staffID = "GX2",  position = "Giu Xe",dayOfBirth=new DateTime(1979, 6, 8)},
               new Staff(){fullname = "Ngo Thai X",  address = "Thai Binh", phonenumber = "0912422781", gender = "Nam", identitycard = "678768786787", staffID = "GX3",  position = "Giu Xe",dayOfBirth=new DateTime(1978, 1, 9)},
               new Staff(){fullname = "Le Cong Y",  address = "Ha Nam", phonenumber = "0312512531", gender = "Nam", identitycard = "543465788980", staffID = "GX4",  position = "Giu Xe",dayOfBirth=new DateTime(1977, 2, 10)},
               new Staff(){fullname = "Luong Van Z",  address = "Ha Giang", phonenumber = "0751259122", gender = "Nam", identitycard = "457476756587", staffID = "GX5",  position = "Giu Xe",dayOfBirth=new DateTime(1976, 3, 11)},
        };
        public void AddStaff()
        {
            Staff st = new Staff();
            Console.Write("\n\t\tHo ten: ");
            st.fullname = Console.ReadLine();
            Console.Write("\n\t\tDia chi: ");
            st.address = Console.ReadLine();
            Console.Write("\n\t\tSDT: ");
            st.phonenumber = Console.ReadLine();
            foreach (Staff nv in ListNhanVien)
            {
                while (nv.phonenumber == st.phonenumber)
                {
                    Console.WriteLine("\n\t\tDu lieu khong hop le Xin vui long nhap lai!!");
                    Console.Write("\n\t\tSDT: ");
                    st.phonenumber = Console.ReadLine();
                }
            }
            Console.Write("\n\t\tGioi tinh: ");
            st.gender = Console.ReadLine();
            Console.Write("\n\t\tCMND/CCCD: ");
            st.identitycard = Console.ReadLine();
            foreach (Staff nv in ListNhanVien)
            {
                while (nv.identitycard == st.identitycard)
                {
                    Console.WriteLine("\n\t\tDu lieu khong hop le Xin vui long nhap lai!!");
                    Console.Write("\n\t\tCMND/CCCD: ");
                    st.identitycard = Console.ReadLine();
                }
            }
            Console.Write("\n\t\tID Nhan Vien: ");
            st.staffID = Console.ReadLine();
            foreach (Staff nv in ListNhanVien)
            {
                while (nv.staffID == st.staffID)
                {
                    Console.WriteLine("\n\t\tDu lieu khong hop le Xin vui long nhap lai!!");
                    Console.Write("\n\t\tID Nhan Vien: ");
                    st.staffID = Console.ReadLine();
                }
            }
            Console.Write("\n\t\tChuc Vu: ");
            st.position = Console.ReadLine();
            Console.Write("\n\t\tNgay thang nam sinh (yyyy,mm,dd): ");
            st.dayOfBirth = Convert.ToDateTime(Console.ReadLine());
            ListNhanVien.Add(st);
        }
        public Staff FindByID(string Id)
        {
            Staff Nhanvien = null;
            if (ListNhanVien != null)
            {
                foreach (Staff nv in ListNhanVien)
                {
                    if (nv.staffID == Id)
                    {
                        Nhanvien = nv;
                    }
                }
            }
            return Nhanvien;
        }
        public void UpDate(string Id)
        {
            Staff Nv = FindByID(Id);
            if (Nv != null)
            {
                ShowStaff(Nv);
                bool flag = false;
                while (true || flag == true)
                {
                    Console.WriteLine("\n\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\t\t============================= THONG TIN NHAN VIEN ==============================");
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
                    Console.WriteLine("\t\t\t\t\t*    |    4.    |      Ngay thang nam sinh                                |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    5.    |      Chuc vu                                            |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*    |          |                                                         |  *");
                    Console.WriteLine("\t\t\t\t\t*    |    0.    |      Thoat                                              |  *");
                    Console.WriteLine("\t\t\t\t\t*    |__________|_________________________________________________________|  *");
                    Console.WriteLine("\t\t\t\t\t*                                                                            *");
                    Console.WriteLine("\t\t\t\t\t******************************************************************************");
                    Console.WriteLine("\t\t\t\t\t==================================== END =====================================");
                    int Selection;
                    Console.Write("\n\t\t\t\t\tNhap lua chon can chinh sua: ");
                    Selection = int.Parse(Console.ReadLine());
                    if (Selection == 1)
                    {
                        Console.Write("\n\t\t\t\t\tNhap ho ten : ");
                        Nv.fullname = Console.ReadLine();
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach nhan vien: ");
                        this.Show(this.getListNhanVien());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 2)
                    {
                        Console.Write("\n\t\t\t\t\tNhap dia chi : ");
                        Nv.address = Console.ReadLine();
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach nhan vien: ");
                        this.Show(this.getListNhanVien());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 3)
                    {
                        Console.Write("\n\t\t\t\t\tNhap SDT : ");
                        Nv.phonenumber = Console.ReadLine();
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach nhan vien: ");
                        this.Show(this.getListNhanVien());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 4)
                    {
                        Console.Write("\n\t\t\t\t\tNhap vao ngay sinh: ");
                        int ngay = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\t\t\t\t\tNhap vao thang sinh: ");
                        int Thang = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\t\t\t\t\tNhap vao nam sinh: ");
                        int Nam = Convert.ToInt32(Console.ReadLine());
                        DateTime dt1 = new DateTime(Nam, Thang, ngay);
                        Nv.dayOfBirth = dt1;
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach nhan vien: ");
                        this.Show(this.getListNhanVien());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (Selection == 5)
                    {
                        Console.Write("\n\t\t\t\t\tNhap chuc vu : ");
                        Nv.position = Console.ReadLine();
                        Console.Write("\n\t\t\t\t\tNhap ma : ");
                        Nv.staffID = Console.ReadLine();
                        Console.WriteLine("\n\t\t\t\t\tChinh Sua Thanh Cong !!!");
                        Console.WriteLine("\n\t\t\t\t\tDanh sach nhan vien : ");
                        this.Show(this.getListNhanVien());
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tNhan vien co Id {0} khong ton tai !!!", Id);
            }
        }
        public bool DeleteStaff(string ID)
        {
            bool IsDelete = false;
            Staff nv = FindByID(ID);
            if (nv != null)
            {
                IsDelete = ListNhanVien.Remove(nv);
            }
            return IsDelete;
        }
        public static double Tien;
        public double TinhLuong()
        {
            string Id3;
            Console.Write("\n\t\t\t\t\tNhap Id nhan vien: ");
            Id3 = Console.ReadLine();
            Staff Nv1 = this.FindByID(Id3);
            this.ShowStaff(Nv1);
            double TienGio = Nv1.salary / 240;
            double BHXH = 0.105;
            double GioLam = 0;
            double Luong = 0;
            Console.Write("\n\t\t\t\t\tNhap vao so gio lam cua nhan vien trong 1 thang:  ");
            GioLam = Convert.ToDouble(Console.ReadLine());
            if (GioLam == 240)
            {
                Luong = Nv1.salary;
                Tien = Luong - Luong * BHXH;
                return Tien;
            }
            else if (GioLam != 240)
            {
                Luong = TienGio * GioLam;
                Tien = Luong - Luong * BHXH;
                return Tien;
            }
            return Tien;
        }
        public double Tinh()
        {
            return Tien;
        }
        public double LuongThuong(Staff Nv)
        {
            Console.Write("\n\t\t\t\t\tNhap vao so ngay nghi nhan vien trong 1 nam:  ");
            int ngaynghi = Convert.ToInt32(Console.ReadLine());
            if (ngaynghi <= Nv.dayOffNumber)
            {
                return Nv.salary;
            }
            else
            {
                return 500000;
            }
        }
        public void ShowStaff(Staff Nv)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\n\t\t {0, -7} {1, -13}  {2, -15} {3, -7} {4, -12} {5, -14} {6, -17} {7, -8}  ", "ID", "Ho Ten", "Dia Chi", "SDT", "Gioi Tinh", "So CMND", "Chuc Vu", "Ngay Sinh");
            Console.WriteLine("\n\t\t {0, -5} {1, -15}  {2, -12} {3, -13} {4, -8} {5, -15} {6, -12} {7, -8}  ", Nv.staffID, Nv.fullname, Nv.address, Nv.phonenumber, Nv.gender, Nv.identitycard, Nv.position, Nv.dayOfBirth);
        }
        public void Show(List<Staff> ListNV)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t\t {0, -7} {1, -13}  {2, -15} {3, -7} {4, -12} {5, -14} {6, -17} {7, -8}  ", "ID", "Ho Ten", "Dia Chi", "SDT", "Gioi Tinh", "So CMND", "Chuc Vu", "Ngay Sinh");
            if (ListNV != null)
            {
                foreach (Staff Nv in ListNV)
                {
                    Console.WriteLine("\n\t\t");
                    Console.WriteLine("\t\t {0, -5} {1, -15}  {2, -12} {3, -13} {4, -8} {5, -15} {6, -12} {7, -8}  ", Nv.staffID, Nv.fullname, Nv.address, Nv.phonenumber, Nv.gender, Nv.identitycard, Nv.position, Nv.dayOfBirth);
                }
            }
        }
        public List<Staff> getListNhanVien()
        {
            return ListNhanVien;
        }
        ~ListStaff()
        {
            Console.ReadKey();
        }
    }
}

