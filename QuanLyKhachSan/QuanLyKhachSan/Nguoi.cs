using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    internal class Nguoi
    {
        private string hoTen;
        private int tuoi;
        private string cmnd;

        public Nguoi(string hoTen, int tuoi, string cmnd)
        {
            this.HoTen = hoTen;
            this.Tuoi = tuoi;
            this.Cmnd = cmnd;
        }

        public Nguoi() { }

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
                if (value >= 1)
                    tuoi = value;
                else
                    throw new ArgumentException("Tuổi là số dương.");
            }
        }

        public string Cmnd 
        { 
            get => cmnd;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    cmnd = value.Trim();
                else
                    throw new ArgumentException("CMND không được để trống.");
            }
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập tuổi: ");
                if (int.TryParse(Console.ReadLine(), out int tuoi) && tuoi > 0)
                {
                    Tuoi = tuoi;
                    break;
                }
                Console.WriteLine("Tuổi là một số nguyên dương.");
            }

            Console.Write("Nhập CMND: ");
            Cmnd = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên: {HoTen}, Tuổi: {Tuoi}, CMND: {Cmnd}\n");
        }
    }
}
