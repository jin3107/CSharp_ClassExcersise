using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai9
{
    public class QuanLyBienLai
    {
        private List<BienLai> danhSachBienLai = new List<BienLai>();

        public void ThemBienLai()
        {
            BienLai bienLai = new BienLai();
            try
            {
                bienLai.Nhap();
                danhSachBienLai.Add(bienLai);
                Console.WriteLine("\nThêm biên lai thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        public void XoaBienLai(string maCongTo)
        {
            var bienLai = danhSachBienLai.FirstOrDefault(bl => bl.KhachHang.MaSoCongToDien == maCongTo);
            if (bienLai != null)
            {
                danhSachBienLai.Remove(bienLai);
                Console.WriteLine("\nXóa biên lai thành công!");
            }
            else
            {
                Console.WriteLine("\nKhông tìm thấy biên lai với mã công tơ điện này.");
            }
        }

        public void SuaThongTinBienLai(string maCongTo)
        {
            var bienLai = danhSachBienLai.FirstOrDefault(bl => bl.KhachHang.MaSoCongToDien == maCongTo);
            if (bienLai != null)
            {
                Console.WriteLine("\nNhập thông tin mới cho biên lai:");
                bienLai.Nhap();
                Console.WriteLine("\nCập nhật thông tin thành công!");
            }
            else
            {
                Console.WriteLine("\nKhông tìm thấy biên lai với mã công tơ điện này.");
            }
        }

        public void HienThiDanhSachBienLai()
        {
            if (danhSachBienLai.Count == 0)
            {
                Console.WriteLine("\nDanh sách biên lai trống.");
                return;
            }

            Console.WriteLine("\n--- Danh sách biên lai ---");
            foreach (var bienLai in danhSachBienLai)
            {
                Console.WriteLine(bienLai.ToString());
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
