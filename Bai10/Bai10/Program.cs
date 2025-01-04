using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VanBan vanBan = new VanBan();
            vanBan.Nhap();
            vanBan.Xuat();
            vanBan.DemSoTuVanBan();
            vanBan.DemSoLuongKyTuA();
            vanBan.ChuanHoaVanBan();
        }
    }
}