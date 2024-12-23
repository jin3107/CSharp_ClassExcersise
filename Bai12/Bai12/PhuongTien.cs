using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class PhuongTien
    {
        private string id;
        private string hangSanXuat;
        private int namSanXuat;
        private double giaBan;
        private string mauXe;

        public PhuongTien(string id, string hangSanXuat, int namSanXuat, double giaBan, string mauXe)
        {
            this.id = id;
            this.hangSanXuat = hangSanXuat;
            this.namSanXuat = namSanXuat;
            this.giaBan = giaBan;
            this.mauXe = mauXe;
        }

        public string Id { get => id; set => id = value; }
        public string HangSanXuat { get => hangSanXuat; set => hangSanXuat = value; }
        public int NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public string MauXe { get => mauXe; set => mauXe = value; }

        public PhuongTien()
        {
        }

        public virtual void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập ID: ");
            id = Console.ReadLine();

            Console.Write("Nhập hãng sản xuất: ");
            hangSanXuat = Console.ReadLine();

            Console.Write("Nhập năm sản xuất: ");
            namSanXuat = int.Parse(Console.ReadLine());

            Console.Write("Nhập giá bán: ");
            giaBan = double.Parse(Console.ReadLine());

            Console.Write("Nhập màu xe: ");
            mauXe = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"ID: {id}, Hãng sản xuất: {hangSanXuat}, Năm sản xuất: {namSanXuat}, Giá bán: {giaBan}, Màu xe: {mauXe}";
        }
    }
}
