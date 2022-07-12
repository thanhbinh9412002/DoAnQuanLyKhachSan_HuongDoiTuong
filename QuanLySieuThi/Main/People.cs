using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class People
    {
        public People()
        {

        }
        private string FullName;
        public string fullname
        {
            get => FullName;
            set
            {
                if (value.Length > 0 && value.Length < 30)
                {
                    FullName = value;
                }
                else
                {
                    Console.WriteLine("\n\t\tTen ban nhap khong hop!!! Moi nhap lai!!!");
                }
            }
        }
        private string Address;
        public string address
        {
            get => Address;
            set => Address = value;
        }
        private string PhoneNumber;
        public string phonenumber
        {
            get => PhoneNumber;
            set
            {
                if (value.Length < 0 && value.Length > 10)
                {
                    Console.WriteLine("\n\t\t\t\t\tSDT ban nhap bi sai !!!");
                    Console.WriteLine("\n\t\t\t\t\tMoi Nhap lai !!!");
                }
                else
                {
                    PhoneNumber = value;
                }
            }
        }
        private string Gender;
        public string gender
        {
            get => Gender;
            set => Gender = value;
        }
        
        
        public People(string fullName, string address, string phonenumber, string gender)
        {
            this.FullName = fullName;
            this.Address = address;
            this.PhoneNumber = phonenumber;
            this.Gender = gender;
        }
        ~People()
        {

        }
    }
}

