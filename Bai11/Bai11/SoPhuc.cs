using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class SoPhuc
    {
        private double PhanThuc;
        private double PhanAo;

        public SoPhuc() { }

        public SoPhuc(double PhanThuc, double PhanAo)
        {
            this.PhanThuc = PhanThuc;
            this.PhanAo = PhanAo;
        }

        public void NhapSoPhuc()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập phần thực: ");
            PhanThuc = double.Parse(Console.ReadLine());

            Console.Write("Nhập phần ảo: ");
            PhanAo = double.Parse(Console.ReadLine());
        }

        public void HienThiSoPhuc()
        {
            Console.WriteLine($"{PhanThuc} + {PhanAo}i");
        }

        public SoPhuc Cong(SoPhuc sp)
        {
            return new SoPhuc(this.PhanThuc + sp.PhanThuc, this.PhanAo + sp.PhanAo);
        }

        public SoPhuc Nhan(SoPhuc sp)
        {
            double phanThuc = this.PhanThuc * sp.PhanThuc - this.PhanAo * sp.PhanAo;
            double phanAo = this.PhanThuc * sp.PhanAo + this.PhanAo * sp.PhanThuc;
            return new SoPhuc(phanThuc, phanAo);
        }
    }
}
