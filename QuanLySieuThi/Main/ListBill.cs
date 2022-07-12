using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ListBill : ListGoods
    {
        private static List<Goods> listbill = new List<Goods>();
        public List<Goods> getListBill()
        {
            return listbill;
        }
        public void NhapBill()
        {
            Console.WriteLine("\n\t\t\t\t\t~~~~~~~~~~  Nhap '0' neu muon dung nhap hoa don  ~~~~~~~~~~ \n\n");
            while (true)
            {
                Goods G = new Goods();
                Console.Write("\n\t\t\t\t\tNhap ten hang hoa:  ");
                G.name = Console.ReadLine();
                if (G.name == "0")
                {
                    break;
                }
                Console.Write("\n\t\t\t\t\tNhap so luong hang hoa:  ");
                G.quantity = Convert.ToInt32(Console.ReadLine());
                foreach (Goods g in listGoods)
                {
                    if (G.name == g.name)
                    {
                        int tmp = g.quantity;
                        if (G.quantity > g.quantity)
                        {
                            g.quantity = tmp;
                            Console.WriteLine("\n\t\t\t\t\tKhong du so luong");
                            return;
                        }
                        else
                        {
                            g.quantity = g.quantity - G.quantity;
                        }
                        G.price = g.price;
                    }
                }
                listbill.Add(G);
            }
        }
        public int TinhDiem(double n)
        {
            return (int)n / 500000;
        }
        public double Tinhtien()
        {
            double Money = 0;
            foreach (Goods g in listbill)
            {
                Money += g.quantity * g.price;
            }
            return Money;
        }
        public double TienGiam()
        {
            double n = this.Tinhtien();
            int Score = TinhDiem(n);
            if (Score == 0)
                return 0;
            else if (Score > 0 && Score <= 10)
            {
                n = n * 0.02;
            }
            else if (Score > 10 && Score <= 20)
            {
                n = n * 0.05;

            }
            else if (Score > 20 && Score <= 50)
            {
                n = n * 0.1;
            }
            else
            {
                n = n * 0.2;

            }
            return n;
        }
        public double TienThanhToan()
        {
            return this.Tinhtien() - this.TienGiam();
        }
        public void XuatBill()
        {
            Console.WriteLine("\n\t\t\t\t\t=================================== BILL =====================================");
            Console.WriteLine("\n\t\t\t\t\t******************************************************************************");
            Console.WriteLine("\n\t\t\t\t\t\t{0,-10}\t {1,-5}\t {2,-5} ", "Ten SP", "SL", "Thanh tien");
            foreach (Goods b in listbill)
            {
                Console.WriteLine("\n\t\t\t\t\t* \t{0,-10}\t {1,-5}\t {2,-5}   VND", b.name, b.quantity, b.price);
            }
            Console.WriteLine("\t\t\t\t\t_____________________________________________________________________________");
            Console.WriteLine("\n\t\t\t\t\t* \tSo diem cua ban: {0} diem\n", this.TinhDiem(this.Tinhtien()));
            Console.WriteLine("\t\t\t\t\t* \tTien giam: {0} VND", this.TienGiam());
            Console.WriteLine("\t\t\t\t\t_____________________________________________________________________________");
            Console.WriteLine("\n\t\t\t\t\t* \tTong tien cho don nay la:  {0}  VND", this.TienThanhToan());
        }
        ~ListBill()
        {
            Console.ReadKey();
        }
    }
    class ScoreCustomer : ListCustomer
    {
        ListBill lb = new ListBill();
        public void Handle()
        {
            Customer cs = new Customer();
            Console.Write("\n\t\t\t\t\t Nhap ID khach hang : ");
            cs.customerID = Console.ReadLine();
            cs = this.CustomerFindById(cs.customerID);
            if (cs != null)
            {
                lb.NhapBill();
                int Diem = lb.TinhDiem(lb.Tinhtien());
                cs.diem += Diem;
            }else
            {
                Console.WriteLine("\n\t\t\t\t\t KHACH HANG KHONG TON TAI !!");
                Console.WriteLine("\n\t\t\t\t\t THEM KHACH HANG ");
                this.AddCustomer();
                Console.WriteLine("\n\t\t\t\t\t CHUC MUNG BAN DA TRO THANH HOI VIEN SIEU THI ");
            }
        }
    }
}
