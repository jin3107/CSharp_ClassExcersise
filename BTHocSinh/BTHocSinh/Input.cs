using System;
using System.Text;

namespace BTHocSinh
{
    internal static class Input
    {
        public static int NhapSoLuongSinhVien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int number;
            while (true)
            {
                Console.Write("Nhập số lượng Sinh viên: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                    break;
                else
                    Console.WriteLine("Số lượng Sinh viên không hợp lệ! Vui lòng nhập lại.\n");
            }
            return number;
        }

        public static HocSinh NhapThongTinHocSinh(int stt)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            HocSinh hocSinh = new HocSinh();
            Console.WriteLine($"\n-- Nhập thông tin cho Sinh viên thứ {stt} --");

            while (true)
            {
                Console.Write("Nhập Họ tên Sinh viên: ");
                string hoTen = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(hoTen))
                {
                    try
                    {
                        hocSinh.HoTen = hoTen.Trim();
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    Console.WriteLine("Họ tên không được để trống! Vui lòng nhập lại.\n");
            }

            while (true)
            {
                Console.Write("Nhập Lớp học: ");
                string lopHoc = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lopHoc))
                {
                    try
                    {
                        hocSinh.LopHoc = lopHoc.Trim();
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    Console.WriteLine("Lớp học không được để trống! Vui lòng nhập lại.\n");
            }

            hocSinh.DToan = NhapDiem("Toán");
            hocSinh.DLy = NhapDiem("Lý");
            hocSinh.DHoa = NhapDiem("Hóa");

            return hocSinh;
        }

        private static double NhapDiem(string monHoc)
        {
            double diem;
            string prompt = $"Nhập Điểm {monHoc}: ";

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out diem))
                {
                    if (diem >= 0 && diem <= 10)
                        break;
                    else
                    {
                        Console.WriteLine("\nĐiểm không hợp lệ! Vui lòng nhập lại (0 - 10).\n");
                        prompt = $"Nhập lại Điểm {monHoc}: ";
                    }
                }
                else
                {
                    Console.WriteLine("\nĐiểm không hợp lệ! Vui lòng nhập lại (0 - 10).\n");
                    prompt = $"Nhập lại Điểm {monHoc}: ";
                }
            }
            return diem;
        }
    }
}
