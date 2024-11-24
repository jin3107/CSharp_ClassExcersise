using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.GiaoDien
{
    internal static class MayQuet
    {
        public static string DocChuoi(string thongBao)
        {
            Console.Write(thongBao);
            return Console.ReadLine();
        }

        public static int DocSoNguyen(string thongBao)
        {
            Console.Write(thongBao);
            return int.Parse(Console.ReadLine());
        }

        public static DateTime DocNgay(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    return DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Định dạng ngày không hợp lệ. Vui lòng nhập lại theo định dạng dd/MM/yyyy.");
                }
            }
        }
    }
}
