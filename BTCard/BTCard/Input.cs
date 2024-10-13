using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCard
{
    internal static class Input
    {
        public static int NhapSoLuongSach()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int number;
            while (true)
            {
                Console.Write("Nhập số lượng cuốn sách: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                    break;
                else
                    Console.WriteLine("\nSố lượng cuốn sách không hợp lệ! Vui lòng nhập lại.");
            }
            return number;
        }

        public static Card NhapThongTinSach(int stt)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Card card = new Card();
            Console.WriteLine($"\n-- Nhập thông tin cho Cuốn sách thứ {stt} --");

            while (true)
            {
                Console.Write("Nhập Tựa đề: ");
                string tuaDe = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(tuaDe))
                {
                    try
                    {
                        card.TuaDe = tuaDe.Trim();
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    Console.WriteLine("\nTựa đề không được để trống! Vui lòng nhập lại.");
            }

            while (true)
            {
                Console.Write("Nhập Tác giả: ");
                string tacGia = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(tacGia))
                {
                    try
                    {
                        card.TacGia = tacGia.Trim();
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    Console.WriteLine("\nTác giả không được để trống! Vui lòng nhập lại.");
            }

            card.SoLuongBan = NhapSoLuong();

            return card;
        }

        private static int NhapSoLuong()
        {
            int soLuong;
            string promt = "Nhập Số lượng Bán: ";

            while (true)
            {
                Console.Write(promt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out soLuong))
                {
                    if (soLuong >= 0) break;
                    else
                    {
                        Console.WriteLine("\nSố lượng Bán không hợp lệ! Vui lòng nhập lại.\n");
                        promt = "Nhập lại Số lượng Bán: ";
                    }
                }
                else
                {
                    Console.WriteLine("\nSố lượng Bán không hợp lệ! Vui lòng nhập lại.\n");
                    promt = "Nhập lại Số lượng Bán: ";
                }
            }
            return soLuong;
        }
    }
}
