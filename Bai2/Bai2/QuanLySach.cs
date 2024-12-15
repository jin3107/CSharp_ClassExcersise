using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class QuanLySach
    {
        public List<TaiLieu> DanhSachSach { get; set; } = new List<TaiLieu>();

        public QuanLySach() { }

        public void ThemSach()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nNhập thông tin tài liệu.");
            int loai;

            while (true)
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
                DanhSachSach.Add(taiLieu);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi nhập dữ liệu: {ex.Message}");
            }
        }

        public void HienThiSach()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            if (DanhSachSach.Count == 0)
            {
                Console.WriteLine("\nKhông có Tài liệu nào trong danh sách.");
                return;
            }

            Console.WriteLine("\n--- Thông tin Tài liệu ---");
            foreach (var taiLieu in DanhSachSach)
            {
                Console.WriteLine(taiLieu.ToString()); ;
            }
        }

        public void XoaSach(string maTaiLieu)
        {
            var ketQua = DanhSachSach.FirstOrDefault(x => x.MaTaiLieu == maTaiLieu);
            if (ketQua == null)
                Console.WriteLine("Mã tài liệu không tồn tại");
            else
            {
                DanhSachSach.Remove(ketQua);
                Console.WriteLine($"Xóa tài liệu có mã {maTaiLieu} thành công");
            }
        }

        public void TimSach()
        {
            DanhSachSach.OfType<Sach>().ToList().ForEach(x =>
            {
                Console.WriteLine(x.ToString());
            });
        }

        public void TimTapChi()
        {
            DanhSachSach.OfType<TapChi>().ToList().ForEach(x =>
            {
                Console.WriteLine(x.ToString());
            });
        }

        public void TimBao()
        {
            DanhSachSach.OfType<Bao>().ToList().ForEach(x =>
            {
                Console.WriteLine(x.ToString());
            });
        }
    }
}
