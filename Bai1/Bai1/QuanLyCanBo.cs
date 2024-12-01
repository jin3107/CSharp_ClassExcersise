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
            int loai;
            while (true)
            {
                Console.WriteLine("1. Công nhân, 2. Kỹ sư, 3. Nhân viên");
                Console.Write("Lựa chọn của bạn: ");
                if (int.TryParse(Console.ReadLine(), out loai) && loai >= 1 && loai <= 3)
                { break; }
                Console.WriteLine("Lựa chọn không hợp lệ. Nhập lại!\n");
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
                default:
                    return;
            }

            try
            {
                canBo.Nhap();
                DanhSachCanBo.Add(canBo);
            }
            catch (Exception ex)
            {  Console.WriteLine($"Lỗi: {ex.Message}"); return;}
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
