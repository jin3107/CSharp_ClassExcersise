using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25_119
{
    public class HinhTron : HinhHoc
    {
        public Diem TamO { get; set; } = new Diem();
        public double BanKinh { get; set; }
        public double DienTich { get; set; }

        public HinhTron() { }

        public HinhTron(Diem tamO, double banKinh, double dienTich)
        {
            TamO = tamO;
            BanKinh = banKinh;
            DienTich = dienTich;
        }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            TenHinh = "Hình tròn";
            Console.Write("Nhập tâm hình tròn: ");
            TamO.Nhap();

            Console.Write("Nhập bán kính: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double banKinh))
                {
                    BanKinh = banKinh;
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập sai định dạng. Bán kính là số dương.\n");
                }
            }
        }

        public override void Xuat()
        {
            throw new NotImplementedException();
        }
    }

}
