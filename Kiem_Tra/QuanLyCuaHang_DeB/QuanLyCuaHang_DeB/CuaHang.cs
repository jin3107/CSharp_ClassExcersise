using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang_DeB
{
    internal class CuaHang
    {
        private List<HoaDon> danhSachHoaDon = new List<HoaDon>();

        public CuaHang()
        {
        }

        public CuaHang(List<HoaDon> danhSachHoaDon)
        {
            this.DanhSachHoaDon = danhSachHoaDon;
        }

        internal List<HoaDon> DanhSachHoaDon { get => danhSachHoaDon; set => danhSachHoaDon = value; }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int soHoaDon = 1;

            while (true)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.Nhap(soHoaDon++);
                DanhSachHoaDon.Add(hoaDon);

                Console.Write("Bạn có muốn nhập thêm hóa đơn không? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();
                if (response != "Y") break;
            }
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tongDoanhThu = 0;

            foreach (HoaDon hoaDon in DanhSachHoaDon)
            {
                hoaDon.Xuat();
                tongDoanhThu += hoaDon.TinhTongTriGia();
            }

            Console.WriteLine($"\nTong doanh thu cua cua hang: {tongDoanhThu}");
        }
    }
}
