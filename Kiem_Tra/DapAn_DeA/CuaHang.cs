using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapAn_DeA
{
    public class CuaHang
    {
        public List<HoaDon> DanhSachHoaDon = new List<HoaDon>();
        double DoanhThu = 0;

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int soHD = 1;
            double giaTriHD;
            do
            {
                Console.WriteLine($"Nhập hóa đơn thứ: {soHD}");
                HoaDon hd = new HoaDon();
                hd.Nhap();
                giaTriHD = hd.Xuat();
                if (giaTriHD == 0) break;
                DoanhThu += giaTriHD;
                DanhSachHoaDon.Add(hd);
                soHD++;
            }
            while (true);
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n=================================");
            Console.WriteLine($"Tổng doanh thu: {DoanhThu:N0} VND");
            Console.WriteLine("=================================");
        }
    }
}
