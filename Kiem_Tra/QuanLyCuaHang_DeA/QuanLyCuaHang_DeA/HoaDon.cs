using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang_DeA
{
    internal class HoaDon
    {
        private List<MatHang> danhSachMatHang = new List<MatHang>();
        private int soHoaDon;

        internal List<MatHang> DanhSachMatHang 
        { 
            get => danhSachMatHang; 
            set => danhSachMatHang = value; 
        }

        public int SoHoaDon 
        { 
            get => soHoaDon; 
            set => soHoaDon = value; 
        }

        public HoaDon(List<MatHang> danhSachMatHang, int soHoaDon)
        {
            this.DanhSachMatHang = danhSachMatHang;
            this.SoHoaDon = soHoaDon;
        }

        public HoaDon()
        {
        }

        public void Nhap(int soHoaDon)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            SoHoaDon = soHoaDon;

            Console.WriteLine($"\n--- Nhập thông tin cho hóa đơn {SoHoaDon} ---");

            while (true)
            {
                MatHang matHang = new MatHang();
                matHang.Nhap();
                DanhSachMatHang.Add(matHang);

                Console.Write("Bạn có muốn nhập thêm mặt hàng không? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();
                if (response != "Y") break;
            }
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"\n--- Hóa đơn số: {SoHoaDon} ---");
            Console.WriteLine($"{"STT",-5} {"Ma hang",-10} {"Ten hang",-15} {"So luong",-10} {"Don gia",-10} {"Thanh tien",-10}");

            int stt = 1;
            int tongTriGia = 0;
            foreach (MatHang matHang in DanhSachMatHang)
            {
                matHang.Xuat(stt++);
                tongTriGia += matHang.ThanhTien;
            }
            Console.WriteLine($"Tong tri gia hoa don: {tongTriGia}");
        }

        public int TinhTongTriGia()
        {
            int tongTriGia = 0;
            foreach (MatHang matHang in DanhSachMatHang)
            {
                tongTriGia += matHang.ThanhTien;
            }
            return tongTriGia;
        }
    }
}
