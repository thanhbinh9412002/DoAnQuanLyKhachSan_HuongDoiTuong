using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class CostGoods : SupplyOfGoods
    {
        public CostGoods()
        {

        }
        public double chiPhi()
        {
            return Money;
        }
        ~CostGoods()
        {
            Console.ReadKey();
        }
    }
    class CostStaff : ListStaff
    {
        public CostStaff()
        {

        }
        public int Chiphi()
        {
            return (int)this.Tinh();

        }
        ~CostStaff()
        {
            Console.ReadKey();
        }
    }
    class CostProvidePremises : ProvidePremises
    {
        public CostProvidePremises()
        {

        }
        public double Chiphi()
        {
            return Money;
        }
        ~CostProvidePremises()
        {
            Console.ReadKey();
        }
    }
}
