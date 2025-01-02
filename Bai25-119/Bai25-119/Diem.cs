using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25_119
{
    public class Diem
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Diem()
        {
        }

        public Diem(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập hoành độ X: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    X = x;
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập sai định dạng, vui lòng nhập lại.\n");
                }
            }

            Console.Write("Nhập tung độ Y: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double y))
                {
                    Y = y;
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập sai định dạng, vui lòng nhập lại.\n");
                }
            }
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tọa độ: ({X}, {Y})");
        }

        public static double KhoangCach(Diem A, Diem B)
        {
            double khoangCach = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return khoangCach;
        }
    }
}
