using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoHS
{
    internal class HocSinh
    {
        private string hoTen;
        private int tuoi;
        private string queQuan;

        public HocSinh(string hoTen, int tuoi, string queQuan)
        {
            this.HoTen = hoTen;
            this.Tuoi = tuoi;
            this.QueQuan = queQuan;
        }

        public string HoTen 
        {
            get => hoTen; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    hoTen = value.Trim();
                else
                    throw new ArgumentException("Họ tên không được để trống.");
            }
        }

        public int Tuoi
        {
            get => tuoi; 
            set
            {
                if (value > 0)
                    tuoi = value;
                else
                    throw new ArgumentException("Tuổi là số dương.");
            }
        }

        public string QueQuan 
        {
            get => queQuan; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    queQuan = value.Trim();
                else
                    throw new ArgumentException("Quê quán không được để trống.");
            }
        }

        public HocSinh() { }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập tuổi: ");
                if (int.TryParse(Console.ReadLine(), out int tuoi) && tuoi > 0)
                {
                    Tuoi = tuoi;
                    break;
                }
                Console.WriteLine("Tuổi phải là một số nguyên dương.");
            }

            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên: {HoTen}, Tuổi: {Tuoi}, Quê quán: {QueQuan}\n");
        }
    }
}
