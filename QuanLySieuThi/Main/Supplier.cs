using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLySieuThi.Main
{
    class Supplier
    {
        private string NameOfCompany;
        public string nameofcompany
        {
            get => NameOfCompany;
            set => NameOfCompany = value;
        }
        private string Address;
        public string address
        {
            get => Address;
            set => Address = value;
        }
        private string NumberPhone;
        public string numberphone
        {
            get => NumberPhone;
            set => NumberPhone = value;
        }
        private string Email;
        public string email
        {
            get => Email;
            set => Email = value;
        }
        private string FieldOfSupply;
        public string fieldofsupply
        {
            get => FieldOfSupply;
            set => FieldOfSupply = value;
        }
        public Supplier()
        {

        }
        public Supplier(string NameOfCompany, string Address, string NumberPhone, string Email, string FieldOfSupply)
        {
            this.NameOfCompany = NameOfCompany;
            this.Address = Address;
            this.NumberPhone = NumberPhone;
            this.Email = Email;
            this.FieldOfSupply = FieldOfSupply;
        }
        ~Supplier()
        {
            Console.ReadKey();
        }
    }
}
