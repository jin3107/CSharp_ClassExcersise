using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class XeMay : PhuongTien
    {
        private int congXuat;
        public XeMay(string id, string hangSanXuat, int namSanXuat, double giaBan, string mauXe, int congXuat) : base(id, hangSanXuat, namSanXuat, giaBan, mauXe)
        {
            this.congXuat = congXuat;
        }
        public int CongXuat { get => congXuat; set => congXuat = value; }

        public XeMay()
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập công xuất: ");
            congXuat = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCông xuất: {congXuat}\n";
        }
    }
}
