using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    internal class QLS
    {
        private List<TaiLieu> danhSachSach = new List<TaiLieu>();

        public void Input()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nNhập thông tin tài liệu.");
            int loai;

            while(true)
            {
                Console.WriteLine("1. Sách, 2. Tạp chí, 3. Báo");
                Console.Write("nhập lựa chọn của bạn: ");
                if (int.TryParse(Console.ReadLine(), out loai) && loai >= 1 && loai <= 3)
                {
                    break;
                }
                Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại 1, 2 hoặc 3.\n");
            }

            TaiLieu taiLieu;
            switch (loai)
            {
                case 1:
                    taiLieu = new Sach();
                    break;
                case 2:
                    taiLieu = new TapChi();
                    break;
                case 3:
                    taiLieu = new Bao();
                    break;
                default:
                    Console.WriteLine("\nKhông hợp lệ.");
                    return;
            }

            try
            {
                taiLieu.Nhap();
                danhSachSach.Add(taiLieu);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi nhập dữ liệu: {ex.Message}");
            }
        }

        public void Output()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (danhSachSach.Count == 0)
            {
                Console.WriteLine("\nKhông có Tài liệu nào trong danh sách.");
                return;
            }

            Console.WriteLine("\n--- Thông tin Tài liệu ---");
            foreach (var taiLieu in danhSachSach)
            {
                taiLieu.Xuat();
            }
        }

        public bool XoaTaiLieu(string id)
        {
            var taiLieu = danhSachSach.FirstOrDefault(x => x.MaTaiLieu == id);
            if (taiLieu == null)
                return false;
            danhSachSach.Remove(taiLieu);
            return true;
        }

        public void TimSach()
        {
            danhSachSach.OfType<Sach>().ToList().ForEach(x => x.Xuat());
        }

        public void TimTapChi()
        {
            danhSachSach.OfType<TapChi>().ToList().ForEach(x => x.Xuat());
        }

        public void TimBao()
        {
            danhSachSach.OfType<Bao>().ToList().ForEach(x => x.Xuat());
        }
    }
}
