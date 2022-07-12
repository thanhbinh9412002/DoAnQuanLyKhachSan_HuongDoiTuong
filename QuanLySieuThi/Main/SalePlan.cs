using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class SalesPlan : Turnover
    {
        public SalesPlan()
        {

        }
        public bool checkKPIMonth(double KPI)
        {
            return this.Doanhthu() == KPI;
        }
        ~SalesPlan()
        {
            Console.ReadKey();
        }
    }
    
}
