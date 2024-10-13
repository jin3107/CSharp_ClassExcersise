using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTCard
{
    internal static class Options
    {
        public static void HienThiSachCoSoLuongBanNhieuNhat(List<Card> danhSach)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách sách trống!");
                return;
            }

            int maxSoLuongBan = danhSach.Max(sach => sach.SoLuongBan);
            List<Card> sachCoSoLuongBanNhieuNhat = danhSach.Where(sach => sach.SoLuongBan == maxSoLuongBan).ToList();

            Console.WriteLine("\n---- SÁCH CÓ SỐ LƯỢNG BÁN NHIỀU NHẤT ----");
            foreach (var sach in sachCoSoLuongBanNhieuNhat)
            {
                Output.HienThiSach(sach);
            }
        }
    }
}
