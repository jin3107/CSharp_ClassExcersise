using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TamGiac tg = new TamGiac();
            tg.Nhap();
            tg.Xuat();
            tg.ToaDoTrongTam();
            tg.ToaDoTrucTam();
            tg.ToaDoTamVongTronNgoaiTiep();
        }
    }
}