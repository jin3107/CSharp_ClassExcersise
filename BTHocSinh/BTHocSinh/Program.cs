using System;
using System.Collections.Generic;
using System.Text;

namespace BTHocSinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            try
            {
                int soLuongSinhVien = Input.NhapSoLuongSinhVien();
                List<HocSinh> listHocSinh = new List<HocSinh>();

                for (int i = 1; i <= soLuongSinhVien; i++)
                {
                    HocSinh hocSinh = Input.NhapThongTinHocSinh(i);
                    listHocSinh.Add(hocSinh);
                }

                Output.HienThiDanhSach(listHocSinh);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nĐã xảy ra lỗi: {ex.Message}");
            }

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
