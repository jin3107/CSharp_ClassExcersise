using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang_DeB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CuaHang cuaHang = new CuaHang();
            cuaHang.Nhap();
            cuaHang.Xuat();
            Console.ReadLine();
        }
    }
}
