using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class Supermarket
    {
        private string Name;
        public string name
        {
            get => Name;
            set => Name = value;
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
                    Console.WriteLine("\n\t\tSo nay khong phai SDT cua sieu thi!!! Moi nhap lai!!!");
                }
                else
                {
                    PhoneNumber = value;
                }
            }
        }
        private string Email;
        public string email
        {
            get => Email;
            set => Email = value;
        }
        public Supermarket()
        {

        }
       
        public Supermarket(string name, string address, string phonenumber, string email)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
        public void InPut()
        {
            name = "COOPMART";
            address = "Nga tu Thu Duc";
            phonenumber = "0996699696";
            email = "coopmartpro@gmail.com";
        }
        public void OutPut()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\t\t============================= THONG TIN SIEU THI =============================");
            Console.WriteLine("\t\t\t\t\t******************************************************************************");
            Console.WriteLine("\t\t\t\t\t*     ____________________________________________________________________   *");
            Console.WriteLine("\t\t\t\t\t*    |                          |                                         |  *");
            Console.WriteLine("\t\t\t\t\t*    |        Ten sieu thi      |  {0}                               |  *",name);
            Console.WriteLine("\t\t\t\t\t*    |__________________________|_________________________________________|  *");
            Console.WriteLine("\t\t\t\t\t*    |                          |                                         |  *");
            Console.WriteLine("\t\t\t\t\t*    |      Dia chi sieu thi    |  {0}                         |  *",address);
            Console.WriteLine("\t\t\t\t\t*    |__________________________|_________________________________________|  *");
            Console.WriteLine("\t\t\t\t\t*    |                          |                                         |  *");
            Console.WriteLine("\t\t\t\t\t*    |  So dien thoai sieu thi  |  {0}                             |  *",phonenumber);
            Console.WriteLine("\t\t\t\t\t*    |__________________________|_________________________________________|  *");
            Console.WriteLine("\t\t\t\t\t*    |                          |                                         |  *");
            Console.WriteLine("\t\t\t\t\t*    |        Email sieu thi    |  {0}                  |  *",email);
            Console.WriteLine("\t\t\t\t\t*    |__________________________|_________________________________________|  *");
            Console.WriteLine("\t\t\t\t\t*                                                                            *");
            Console.WriteLine("\t\t\t\t\t******************************************************************************");
            Console.WriteLine("\t\t\t\t\t==================================== END =====================================");
        }
        ~Supermarket()
        {
            Console.ReadKey();
        }
    }
}
