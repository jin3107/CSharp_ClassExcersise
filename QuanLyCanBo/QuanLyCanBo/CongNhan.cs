using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class CongNhan : CanBo
    {
        private int bac;

        public CongNhan() { }

        public CongNhan(string ten, int tuoi, string gioiTinh, string diaChi, int bac) : base(ten, tuoi, gioiTinh, diaChi)
        {
            this.Bac = bac;
        }

        public int Bac 
        { 
            get => bac;
            set
            {
                if (value >= 0)
                    bac = value;
                else
                    throw new ArgumentException("Bậc là số dương.");
            }
        }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Nhap();
            while (true)
            {
                Console.Write("Nhập bậc: ");
                if (int.TryParse(Console.ReadLine(), out bac) && bac >= 0)
                {
                    Bac = bac;
                    break;
                }
                else
                    Console.WriteLine("\nBậc không hợp lệ! Vui lòng nhập lại.\n");
            }
        }

        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Xuat();
            Console.Write($"Bậc: {Bac}");
        }
    }
}
