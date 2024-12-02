using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class QuanLyTheMuon
    {
        public List<TheMuon> DanhSachTheMuon { get; set; } = new List<TheMuon>();

        public void ThemTheMuon()
        {
            TheMuon theMuon = new TheMuon();
            try
            {
                theMuon.Nhap();
                DanhSachTheMuon.Add(theMuon);
                Console.WriteLine("\nThẻ mượn thêm thành công");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        public void XoaTheMuon(string maPhieuMuon)
        {
            var ketqua = DanhSachTheMuon.FirstOrDefault(pm => pm.MaPhieuMuon == maPhieuMuon);
            if (ketqua == null)
                Console.WriteLine("Mã phiếu mượn không tồn tại");
            else
            {
                DanhSachTheMuon.Remove(ketqua);
                Console.WriteLine($"Xóa phiếu mượn có mã {maPhieuMuon} thành công");
            }
        }

        public void HienThiPhieuMuon()
        {
            if (DanhSachTheMuon.Count == 0)
            {
                Console.WriteLine("\nKhông có phiếu mượn nào trong danh sách");
                return;
            }
            Console.WriteLine("\n--- Thông tin phiếu mượn ---");
            foreach (var phieuMuon in DanhSachTheMuon)
            {
                Console.WriteLine(phieuMuon.ToString());
            }
        }
    }
}
