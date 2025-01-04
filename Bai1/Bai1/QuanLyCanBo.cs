using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class QuanLyCanBo
    {
        public List<CanBo> DanhSachCanBo { get; set; } = new List<CanBo>();

        public QuanLyCanBo()
        {
        }

        public void ThemCanBo()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n--- Nhập thông tin cán bộ ---\n");
            while (true)
            {
                Console.WriteLine("1. Công nhân\n2. Kỹ sư\n3. Nhân viên\n4. Thoát");
                Console.Write("Lựa chọn của bạn: ");
                if (!int.TryParse(Console.ReadLine(), out int loai))
                {
                    Console.WriteLine("Lựa chọn không đúng định dạng. Nhập lại!\n");
                    continue;
                }

                CanBo canBo;
                switch (loai)
                {
                    case 1:
                        canBo = new CongNhan(); break;
                    case 2:
                        canBo = new KySu(); break;
                    case 3:
                        canBo = new NhanVien(); break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.\n");
                        continue;
                }

                try
                {
                    canBo.Nhap();
                    DanhSachCanBo.Add(canBo);
                }
                catch (Exception ex)
                { 
                    Console.WriteLine($"Lỗi: {ex.Message}"); 
                }
            }
        }

        public void HienThiCanBo()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (DanhSachCanBo.Count == 0)
            {
                Console.WriteLine("\nKhông có cán bộ trong danh sách");
                return;
            }
            Console.WriteLine("\n--- Thông tin cán bộ ---");
            foreach (var canBo in DanhSachCanBo)
            {
                Console.WriteLine(canBo.ToString());
            }
        }

        public void TimKiemTheoTen(string ten)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            var ketQua = DanhSachCanBo.Where(cb => cb.HoTen == ten)
                .ToList();
            if (ketQua.Count > 0)
            {
                Console.WriteLine($"\nTìm thấy cán bộ có tên {ten}");
                foreach (var canBo in ketQua)
                {
                    Console.WriteLine(canBo.ToString());
                }
            }
            else
            {
                Console.WriteLine($"Không tìm thấy cán bộ có tên {ten}");
            }
        }
    }
}
