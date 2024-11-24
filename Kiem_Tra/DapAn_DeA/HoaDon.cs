using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapAn_DeA
{
    internal class HoaDon
    {
        private double giaTriHd = 0;
        private List<MatHang> arr = new List<MatHang>();

        public HoaDon()
        {
            
        }

        public HoaDon(double giaTriHd, List<MatHang> arr)
        {
            this.GiaTriHd = giaTriHd;
            this.Arr = arr;
        }

        public double GiaTriHd { get => giaTriHd; set => giaTriHd = value; }
        internal List<MatHang> Arr { get => arr; set => arr = value; }

        public void Nhap()
        {
            bool tt = true;
            do
            {
                try
                {
                    MatHang mh = new MatHang();
                    mh.Nhap();
                    Arr.Add(mh);
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

            Console.WriteLine("\n{0,-10} {1,-20} {2,-10} {3,-10} {4,-15}", "Mã Hàng", "Tên Hàng", "Số Lượng", "Đơn Giá", "Thành Tiền");
            Console.WriteLine(new string('-', 65));
            foreach (MatHang mh in Arr)
            {
                GiaTriHd += mh.TienHang();
                mh.Xuat();
            }
            Console.WriteLine($"\nTổng tiền: {GiaTriHd}");
            return GiaTriHd;
        }
    }
}
