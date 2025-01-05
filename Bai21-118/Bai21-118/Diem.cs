using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_118
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

        while (true)
        {
            Console.Write("Nhập hoành độ: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                X = x;
                break;
            }
            else
                Console.WriteLine("Không đúng định dạng. Nhập lại!\n");
        }

        while (true)
        {
            Console.Write("Nhập tung độ: ");
            if (double.TryParse(Console.ReadLine(), out double y))
            {
                Y = y;
                break;
            }
            else
                Console.Write("Không đúng định dạng. Nhập lại!\n");
        }
    }

    public void Xuat()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine($"({X}; {Y})");
    }
}
}
