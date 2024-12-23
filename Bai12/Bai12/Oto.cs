using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Oto : PhuongTien
    {
        private int soChoNgoi;
        private string kieuDongCo;

        public Oto(string id, string hangSanXuat, int namSanXuat, double giaBan, string mauXe, int soChoNgoi, string kieuDongCo) : base(id, hangSanXuat, namSanXuat, giaBan, mauXe)
        {
            this.soChoNgoi = soChoNgoi;
            this.kieuDongCo = kieuDongCo;
        }

        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }
        public string KieuDongCo { get => kieuDongCo; set => kieuDongCo = value; }

        public Oto()
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số chỗ ngồi: ");
            soChoNgoi = int.Parse(Console.ReadLine());

            Console.Write("Nhập kiểu động cơ: ");
            kieuDongCo = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSố chỗ ngồi: {soChoNgoi}\nKiểu động cơ: {kieuDongCo}";
        }
    }
}
