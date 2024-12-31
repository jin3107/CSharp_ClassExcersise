using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_118
{
    public class Lop
    {
        public string tenLop { get; set; }

        public Lop() { }

        public Lop(string tenLop)
        {
            this.tenLop = tenLop;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên lớp: ");
            tenLop = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tên lớp: {tenLop}");
        }
    }
}
