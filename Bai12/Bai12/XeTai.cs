using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class XeTai : PhuongTien
    {
        private int trongTai;

        public XeTai(string id, string hangSanXuat, int namSanXuat, double giaBan, string mauXe, int trongTai) : base(id, hangSanXuat, namSanXuat, giaBan, mauXe)
        {
            this.trongTai = trongTai;
        }

        public int TrongTai { get => trongTai; set => trongTai = value; }

        public XeTai()
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập trọng tải: ");
            trongTai = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + $"\nTrọng tải: {trongTai}\n";
        }
    }
}
