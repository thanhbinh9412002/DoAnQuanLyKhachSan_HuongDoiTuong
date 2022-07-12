using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ProvidePremises : Supplier
    {
        public ProvidePremises()
        {

        }
        public ProvidePremises(string NameOfCompany, string Address, string NumberPhone, string Email, string FieldOfSupply, double RentialPrice)
            : base(NameOfCompany, Address, NumberPhone, Email, FieldOfSupply)
        {
        }
        public static double Money = 1000000;
        public double Outputprovidepremises()
        {
            return Money;
        }
        public double UpdateRentialPrice(double NewRentialPrice)
        {
            return Money = NewRentialPrice;
        }
        ~ProvidePremises()
        {
            Console.ReadKey();
        }
    }
}
