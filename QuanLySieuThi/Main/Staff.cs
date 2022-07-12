using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class Staff : People
    {
        private DateTime DayOfBirth;
        public DateTime dayOfBirth
        {
            get => DayOfBirth;
            set => DayOfBirth = value;
        }
        private string IdentityCard;
        public string identitycard
        {
            get => IdentityCard;
            set
            {
                if (value.Length < 0 && value.Length > 9)
                {
                    Console.WriteLine("\n\t\tBan nhap sai so CMND roi!!! Ban mau nhap lai di!!!");
                }
                else
                {
                    IdentityCard = value;
                }
            }
        }
        private string StaffID;
        public string staffID
        {
            get => StaffID;
            set
            {
                if (value.Length < 0 && value.Length > 7)
                {
                    Console.WriteLine("\n\t\t\t\t\tID khong dung!!!");
                    Console.WriteLine("\n\t\t\t\t\tMoi nhap lai !!!");
                }
                else
                {
                    StaffID = value;
                }
            }
        }
        private double Salary;
        public double salary
        {
            get => Salary;
            set => salary = value;
        }
        private string Position;
        public string position
        {
            get => Position;
            set => Position = value;
        }
        private double WorkingHours;
        public double workingHours
        {
            get => WorkingHours;
            set => WorkingHours = value;
        }
        private int DayOffNumber;
        public int dayOffNumber
        {
            get => DayOffNumber;
            set => DayOffNumber = value;
        }
        public Staff()
        {
            this.WorkingHours = 240;
            this.DayOffNumber = 12;
            this.Salary = 7000000;
        }
        
        public Staff(string fullname, string gender, string identitycard, string address, string phonenumber, string staffID, DateTime dayOfBirth, double income, string position, double workingHours)
            : base(fullname, address, phonenumber, gender)
        {

        }
        ~Staff()
        {

        }
    }
}

