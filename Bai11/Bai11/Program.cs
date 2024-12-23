using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            QuanLySoPhuc quanLySoPhuc = new QuanLySoPhuc();
            while(true)
            {
                Console.WriteLine("\nChức năng");
                Console.WriteLine("1. Thêm số phức");
                Console.WriteLine("2. Hiển thị số phức ");
                Console.WriteLine("3. Cộng số phức");
                Console.WriteLine("4. Nhân số phức");
                Console.WriteLine("5. Thoát");

                Console.Write("Chọn chức năng: ");
                int chon = int.Parse(Console.ReadLine());
                
                switch(chon)
                {
                    case 1:
                        quanLySoPhuc.NhapSoPhuc();
                        break;
                    case 2:
                        quanLySoPhuc.HienThiSoPhuc();
                        break;
                    case 3:
                        quanLySoPhuc.CongSoPhuc();
                        break;
                    case 4:
                        quanLySoPhuc.NhanSoPhuc();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            }
        }
    }
}