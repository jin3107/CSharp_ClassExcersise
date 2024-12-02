using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class TheMuon
    {
        public string MaPhieuMuon { get; set; }
        public string NgayMuon { get; set; }
        public string HanTra { get; set; }
        public string SoHieuSach { get; set; }
        public SinhVien SinhVien { get; set; } = new SinhVien();

        public TheMuon()
        {
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập mã phiếu mượn: ");
            MaPhieuMuon = Convert.ToString(Console.ReadLine());
            
            Console.Write("Nhập ngày mượn: ");
            NgayMuon = Convert.ToString(Console.ReadLine());
            
            Console.Write("Nhập hạn trả: ");
            HanTra = Convert.ToString(Console.ReadLine());
            
            Console.Write("Nhập số hiệu sách: ");
            SoHieuSach = Convert.ToString(Console.ReadLine());

            Console.WriteLine("-- Nhập thông tin sinh viên mượn sách --");
            SinhVien.Nhap();
        }

        public override string ToString()
        {
            return $"Mã phiếu mượn: {MaPhieuMuon}\n" +
                $"Ngày mượn: {NgayMuon}\n" +
                $"Hạn trả: {HanTra}\n" +
                $"Số hiệu sách: {SoHieuSach}\n" +
                $"-- Thông tin sinh viên --\n" +
                $"{SinhVien}\n";
        }
    }
}
