using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapAn_DeA
{
    public class HoaDon
    {
        public List<MatHang> DanhSachMatHang = new List<MatHang>();
        double GiaTriHoaDon = 0;

        public HoaDon() { }

        public void Nhap()
        {
            bool tt = true;
            do
            {
                try
                {
                    MatHang mh = new MatHang();
                    mh.Nhap();
                    DanhSachMatHang.Add(mh);
                }
                catch (Exception)
                {
                    tt = false;
                }
            }
            while (tt == true);
        }

        public double Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int stt = 1;
            Console.WriteLine($"\n{"STT", -5} {"Mã Hàng",-10} {"Tên Hàng",-20} {"Số Lượng",-10} {"Đơn Giá",-10} {"Thành Tiền",-15}");
            Console.WriteLine(new string('-', 70));
            foreach (MatHang mh in DanhSachMatHang)
            {
                GiaTriHoaDon += mh.TienHang();
                mh.Xuat(stt++);
            }

            Console.WriteLine($"\nTổng tiền: {GiaTriHoaDon}");
            return GiaTriHoaDon;
        }
    }
}
