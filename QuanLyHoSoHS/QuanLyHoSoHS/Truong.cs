using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoSoHS
{
    internal class Truong
    {
        private List<HocSinh> danhSachHocSinh;

        public Truong() 
        { 
            danhSachHocSinh = new List<HocSinh>();
        }

        public Truong(List<HocSinh> danhSachHocSinh)
        {
            this.DanhSachHocSinh = danhSachHocSinh;
        }

        internal List<HocSinh> DanhSachHocSinh 
        { 
            get => danhSachHocSinh; 
            set => danhSachHocSinh = value;
        }

        public void ThemHocSinh()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            HocSinh hocSinh = new HocSinh();
            hocSinh.Nhap();
            danhSachHocSinh.Add(hocSinh);
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập số lượng học sinh trong trường: ");
            int soLuong;
            while (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0)
            {
                Console.WriteLine("Số lượng học sinh phải là số nguyên dương.");
            }

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin cho học sinh thứ {i + 1} ---");
                HocSinh hocSinh = new HocSinh();
                hocSinh.Nhap();
                danhSachHocSinh.Add(hocSinh);
            }
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n--- Thông tin danh sách học sinh ---");
            if (danhSachHocSinh.Count == 0)
            {
                Console.WriteLine("Hiện chưa có học sinh nào trong danh sách.");
                return;
            }

            for (int i = 0; i < danhSachHocSinh.Count; i++)
            {
                Console.WriteLine($"\n-- Học sinh thứ {i + 1} --");
                danhSachHocSinh[i].Xuat();
            }
        }

        public List<HocSinh> LayHocSinh20Tuoi()
        {
            return danhSachHocSinh.Where(hocSinh => hocSinh.Tuoi == 20).ToList();
        }

        public int DemHocSinh23TuoiQueDN()
        {
            return danhSachHocSinh.Count(hocSinh => hocSinh.Tuoi == 23 && hocSinh.QueQuan == "DN");
        }
    }
}
