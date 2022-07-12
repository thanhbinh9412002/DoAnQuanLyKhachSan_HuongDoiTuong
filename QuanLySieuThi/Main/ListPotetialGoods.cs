using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Main
{
    class ListPotetialGoods
    {
        private static List<PotentialGoods> listPotential = new List<PotentialGoods>() {
               new PotentialGoods(){name = "Bia", price=50000, goodsid="TN1"},
               new PotentialGoods(){name = "Nuoc ngot", price=30000, goodsid="TN2"},
               new PotentialGoods(){name = "Kem", price=10000, goodsid="TN3"},
               new PotentialGoods(){name = "Mi Tom", price=3000, goodsid="TN4"},
               new PotentialGoods(){name = "Gao", price=12000, goodsid="TN5"},
               new PotentialGoods(){name = "Dau goi", price=100000, goodsid="TN6"},
               new PotentialGoods(){name = "Banh mi", price=10000, goodsid="TN7"},
               new PotentialGoods(){name = "Bot nem", price=25000, goodsid="TN8"},
               new PotentialGoods(){name = "Khan giay", price=10000, goodsid="TN9"},
               new PotentialGoods(){name = "Kem danh rang", price=20000, goodsid="TN10"}
        };
        public void Them()
        {
            PotentialGoods g = new PotentialGoods();
            Console.Write("\n\t\t\t\t\tTen hang:  ");
            g.name = Console.ReadLine();
            Console.Write("\n\t\t\t\t\tGia:  ");
            g.price = double.Parse(Console.ReadLine());
            Console.Write("\n\t\t\t\t\tID hang: ");
            g.goodsid = Console.ReadLine();
            listPotential.Add(g);
        }
        public PotentialGoods FindByID(string Id)
        {
            PotentialGoods HangHoa = null;
            if (listPotential != null)
            {
                foreach (PotentialGoods hh in listPotential)
                {
                    if (hh.goodsid == Id)
                    {
                        HangHoa = hh;
                    }
                }
            }
            return HangHoa;
        }
        public void UpdatePrice(string Id)
        {
            PotentialGoods PG = new PotentialGoods();
            PG = FindByID(Id);
            if (PG != null)
            {
                Console.Write("\n\t\t\t\t\tNhap gia moi:  ");
                PG.price = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void OutPutGoods(PotentialGoods g)
        {
            Console.WriteLine("\n\t\t");
            Console.WriteLine("\t\t\t\t\t{0, -15}\t {1, -15}\t {2, -5} ", "ID", "Ten SP", "Gia");
            Console.WriteLine("\n\t\t\t\t\t{0, -15}\t {1, -15}\t {2, -5} ", g.goodsid, g.name, g.price);
        }
        public void Display(List<PotentialGoods> listPotential)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t\t{0, -10}\t {1, -15}\t {2, -5} ", "ID", "Ten SP", "Gia");
            if (listPotential != null)
            {
                foreach (PotentialGoods g in listPotential)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\n\t\t\t\t\t{0, -10}\t {1, -15}\t {2, -5} ", g.goodsid, g.name, g.price);
                }
            }
        }
        public List<PotentialGoods> getListPotentialGoods()
        {
            return listPotential;
        }
        ~ListPotetialGoods()
        {
            Console.ReadKey();
        }
    }
}
