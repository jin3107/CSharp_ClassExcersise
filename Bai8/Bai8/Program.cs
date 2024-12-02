using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyTheMuon quanLyTheMuon = new QuanLyTheMuon();

            while (true)
            {
                Console.WriteLine("\n--- Chức năng ---");
                Console.WriteLine("1. Thêm thẻ mượn");
                Console.WriteLine("2. Xóa thẻ mượn theo tên thẻ mượn");
                Console.WriteLine("3. Hiểm thị danh sách thẻ mượn");
                Console.WriteLine("4. Thoát");
                Console.Write("Lựa chọn của bạn: ");

                int chon;
                if (!int.TryParse(Console.ReadLine(), out chon) || chon < 1 || chon > 4)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập 1, 2,3 hoặc 4");
                    continue;
                }
                
                switch (chon)
                {
                    case 1:
                        quanLyTheMuon.ThemTheMuon();
                        break;
                    case 2:
                        Console.Write("\nNhập tên thẻ mượn cần xóa: ");
                        string tenTheMuon = Console.ReadLine();
                        quanLyTheMuon.XoaTheMuon(tenTheMuon);
                        break;
                    case 3:
                        quanLyTheMuon.HienThiPhieuMuon();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("\nLựa chọn không hợp lệ. Vui lòng nhập 1, 2, 3 hoặc 4");
                        return;
                }
            }
        }
    }
}
