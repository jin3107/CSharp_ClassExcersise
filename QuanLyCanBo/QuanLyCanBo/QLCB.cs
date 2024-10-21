using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCanBo
{
    internal class QLCB
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void Input()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nNhập thông tin cán bộ.");
            int loai;

            while (true)
            {
                Console.WriteLine("Nhập 1: Công Nhân, 2: Kỹ Sư, 3: Nhân Viên\n");
                if (int.TryParse(Console.ReadLine(), out loai) && loai >= 1 && loai <= 3)
                {
                    break;
                }
                Console.WriteLine("\nLựa chọn không hợp lệ, vui lòng chọn 1, 2 hoặc 3.\n");
            }

            CanBo canBo;
            switch (loai)
            {
                case 1:
                    canBo = new CongNhan();
                    break;
                case 2:
                    canBo = new KySu();
                    break;
                case 3:
                    canBo = new NhanVien();
                    break;
                default:
                    Console.WriteLine("\nKhông hợp lệ.");
                    return;
            }

            try
            {
                canBo.Nhap();
                danhSachCanBo.Add(canBo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi khi nhập dữ liệu: {ex.Message}");
            }
        }

        public void Output()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (danhSachCanBo.Count == 0)
            {
                Console.WriteLine("\nKhông có cán bộ nào trong danh sách.\n");
                return;
            }

            Console.WriteLine("\nThông tin các cán bộ:");
            foreach (var canBo in danhSachCanBo)
            {
                canBo.Xuat();
            }
        }

        public void SearchByName(string name)
        {
            var result = danhSachCanBo.Where(cb => cb.Ten.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (result.Count() > 0)
            {
                Console.WriteLine($"\nTìm thấy {result.Count()} cán bộ có tên chứa '{name}':");
                foreach (var canBo in result)
                {
                    canBo.Xuat();
                }
            }
            else
            {
                Console.WriteLine($"\nKhông tìm thấy cán bộ nào có tên chứa '{name}'.\n");
            }
        }
    }
}
