using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapAn_DeA
{
    internal class CuaHang
    {
        private double doanhThu = 0;
        private List<HoaDon> arr = new List<HoaDon>();

        public CuaHang()
        {
            
        }

        public CuaHang(double doanhThu, List<HoaDon> arr)
        {
            this.DoanhThu = doanhThu;
            this.Arr = arr;
        }

        public double DoanhThu { get => doanhThu; set => doanhThu = value; }
        internal List<HoaDon> Arr { get => arr; set => arr = value; }

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
                Arr.Add(hd);
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
