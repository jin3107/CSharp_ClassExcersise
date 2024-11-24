using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapAn_DeA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuaHang ch = new CuaHang();
            ch.Nhap();
            ch.Xuat();
            Console.ReadLine();
        }
    }
}
