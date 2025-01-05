using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    public class Diem
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Diem() { }

        public Diem(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            while(true)
            {
                Console.Write("Nhập hoành độ X: ");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    X = x;
                    break;
                }
                else
                    Console.WriteLine("Không hợp lệ. Nhập lại!");
            }
            
            while(true)
            {
                Console.Write("Nhập tung độ Y: ");
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    Y = y;
                    break;
                }
                else
                    Console.WriteLine("Không hợp lệ. Nhập lại!");
            }
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine($"({X}; {Y})");
        }
    }
}
