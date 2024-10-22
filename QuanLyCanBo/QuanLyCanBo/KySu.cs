using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class KySu : CanBo
    {
        private string nganhDaoTao;

        public KySu() { }

        public KySu(string ten, int tuoi, string gioiTinh, string diaChi, string nganhDaoTao) : base(ten, tuoi, gioiTinh, diaChi)
        {
            this.nganhDaoTao = nganhDaoTao;
        }

        public string NganhDaoTao 
        {
            get => nganhDaoTao;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nganhDaoTao = value.Trim();
                else
                    throw new ArgumentException("Ngành Đào Tạo không được để trống");
            }
        }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Nhap();
            Console.Write("Nhập ngành đào tạo: ");
            NganhDaoTao = Console.ReadLine();
        }

        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Xuat();
            Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}\n");
        }
    }
}
