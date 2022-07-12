using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class Customer : People
    {
        public enum Rank
        {
            Copper,
            Silver,
            Gold,
            Dianmond
        }
        private string CustomerID;
        public string customerID
        {
            get => CustomerID;
            set => CustomerID = value;
        }
        private int Diem;
        public int diem
        {
            get => Diem;
            set => Diem = value;
        }
        public Customer()
        {

        }
        public Customer(string fullname, string address, string phonenumber, string gender, string customerID, int Diem)
            : base(fullname, address, phonenumber, gender)
        {
            this.CustomerID = customerID;
            this.Diem = Diem;
        }
        public void CheckRank(int diem)
        {
            if (diem > 0 && diem <= 10)
                Console.WriteLine("\n\t\t\t\t\t Rank : {0} ", Rank.Copper);
            else if (diem > 10 && diem <= 20)
                Console.WriteLine("\n\t\t\t\t\t Rank : {0} ", Rank.Silver);
            else if (diem > 20 && diem < 50)
                Console.WriteLine("\n\t\t\t\t\t Rank : {0} ", Rank.Gold);
            else
                Console.WriteLine("\n\t\t\t\t\t Rank : {0} ", Rank.Dianmond);
        }
        ~Customer()
        {

        }
    }
}
