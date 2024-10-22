using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class NhanVien : CanBo
    {
        private string congViec;

        public NhanVien() { }

        public NhanVien(string ten, int tuoi, string gioiTinh, string diaChi, string congViec) : base(ten, tuoi, gioiTinh, diaChi)
        {
            this.congViec = congViec;
        }

        public string CongViec 
        { 
            get => congViec; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    congViec = value.Trim();
                else
                    throw new ArgumentException("Công việc không được để trống.");
            }
        }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Nhap();
            Console.Write("Nhập công việc: ");
            CongViec = Console.ReadLine();
        }

        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Xuat();
            Console.WriteLine($"Công việc: {CongViec}\n");
        }
    }
}
