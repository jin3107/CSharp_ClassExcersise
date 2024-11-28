using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    public class CongNhan : CanBo
    {
        public int Bac { get; set; }

        public CongNhan() { }

        public override void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Nhap();
            while (true)
            {
                Console.Write("Nhập bậc: ");
                if (int.TryParse(Console.ReadLine(), out int bac) && bac >= 0)
                {
                    Bac = bac;
                    break;
                }
                else
                    Console.WriteLine("\nBậc không hợp lệ! Vui lòng nhập lại.\n");
            }
        }

        public override void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            base.Xuat();
            Console.Write($"Bậc: {Bac}\n");
        }
    }
}
