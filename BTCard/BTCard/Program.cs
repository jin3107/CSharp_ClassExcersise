using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            try
            {
                int soLuongCuonSach = Input.NhapSoLuongSach();
                List<Card> listCard = new List<Card>();

                for (int i = 1; i <= soLuongCuonSach; i++)
                {
                    Card card = Input.NhapThongTinSach(i);
                    listCard.Add(card);
                }

                Output.HienThiDanhSach(listCard);
                Options.HienThiSachCoSoLuongBanNhieuNhat(listCard);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
