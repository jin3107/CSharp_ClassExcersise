using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHinhHoc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            QuanLyHinhHoc quanLyHinhHoc = new QuanLyHinhHoc();
            quanLyHinhHoc.NhapDanhSachHinh();
            quanLyHinhHoc.XuatDanhSachHinh();
        }
    }
}
