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

            Console.WriteLine("Nhập thông tin cán bộ.");
            Console.WriteLine("Nhập 1: Công Nhân, 2: Kỹ Sư, 3: Nhân Viên");
            int loai = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("Không hợp lệ.");
                    return;
            }

            canBo.Nhap();
            danhSachCanBo.Add(canBo);
        }

        public void Output()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Thông tin các cán bộ:");
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
                Console.WriteLine($"Tìm thấy {result.Count()} cán bộ có tên chứa '{name}':");
                foreach (var canBo in result)
                {
                    canBo.Xuat();
                }
            }
            else
            {
                Console.WriteLine($"Không tìm thấy cán bộ nào có tên chứa '{name}'.");
            }
        }
    }
}
