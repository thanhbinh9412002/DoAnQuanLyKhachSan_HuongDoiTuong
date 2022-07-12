using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class Turnover : ListBill
    {
        public Turnover()
        {

        }
        public double Doanhthu()
        {
            return this.TienThanhToan();
        }
        ~Turnover()
        {
            Console.ReadKey();
        }
    }
}
