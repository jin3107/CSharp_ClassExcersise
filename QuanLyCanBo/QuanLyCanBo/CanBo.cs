using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class CanBo
    {
        private string ten;
        private int tuoi;
        private string gioiTinh;
        private string diaChi;

        public CanBo() { }

        public CanBo(string ten, int tuoi, string gioiTinh, string diaChi)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
        }

        public string Ten 
        { 
            get => ten; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    ten = value.Trim();
                else
                    throw new ArgumentException("Tên không được để trống.");
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

        public string GioiTinh 
        { 
            get => gioiTinh;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    gioiTinh = value.Trim();
                else
                    throw new ArgumentException("Giới tính không được để trống.");
            }
        }

        public string DiaChi 
        { 
            get => diaChi;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    diaChi = value.Trim();
                else
                    throw new ArgumentException("Địa chỉ không được để trống.");
            }
        }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên: ");
            Ten = Console.ReadLine();

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

            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên: {Ten}, Tuổi: {Tuoi}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
        }
    }
}
