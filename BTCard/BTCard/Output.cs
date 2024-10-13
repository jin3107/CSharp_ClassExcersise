using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCard
{
    internal static class Output
    {
        public static void HienThiDanhSach(List<Card> danhSach)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("\n----- DANH SÁCH CUỐN SÁCH -----\n");

            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.WriteLine($"-- Thông tin cuốn sách thứ {i + 1} --");
                HienThiSach(danhSach[i]);
            }

            Console.WriteLine("\n");
        }

        public static void HienThiSach(Card card)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine($"Tựa đề: {card.TuaDe}");
            Console.WriteLine($"Tác giả: {card.TacGia}");
            Console.WriteLine($"Số Lượng Bán: {card.SoLuongBan}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
