using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CongNhan : CanBo
    {
        public int Bac { get; set; }

        public CongNhan()
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            while (true)
            {
                Console.Write("Nhập bậc: ");
                if (int.TryParse(Console.ReadLine(), out int bac) && bac >= 1 && bac <= 3)
                {
                    Bac = bac;
                    break;
                }
            }
            Console.WriteLine("Bậc không hợp lệ. Nhập lại");
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Bậc: {Bac}\n";
        }
    }
}
