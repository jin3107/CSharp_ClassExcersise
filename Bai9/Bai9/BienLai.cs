using System;
using System.Text;

namespace Bai9
{
    public class BienLai
    {
        public KhachHang KhachHang { get; set; } = new KhachHang();
        public int ChiSoDienCu { get; set; }
        public int ChiSoDienMoi { get; set; }
        public int SoTienPhaiTra => (ChiSoDienMoi - ChiSoDienCu) * 5;

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            KhachHang.Nhap();

            while (true)
            {
                Console.Write("Nhập chỉ số điện cũ: ");
                if (int.TryParse(Console.ReadLine(), out int chiSoCu) && chiSoCu >= 0)
                {
                    ChiSoDienCu = chiSoCu;
                    break;
                }
                Console.WriteLine("Chỉ số điện cũ phải là số nguyên không âm.");
            }

            while (true)
            {
                Console.Write("Nhập chỉ số điện mới: ");
                if (int.TryParse(Console.ReadLine(), out int chiSoMoi) && chiSoMoi >= ChiSoDienCu)
                {
                    ChiSoDienMoi = chiSoMoi;
                    break;
                }
                Console.WriteLine("Chỉ số điện mới phải lớn hơn hoặc bằng chỉ số cũ.");
            }
        }

        public override string ToString()
        {
            return $"{KhachHang}\n" +
                $"Chỉ số điện cũ: {ChiSoDienCu}\n" +
                $"Chỉ số điện mới: {ChiSoDienMoi}\n" +
                $"Số tiền phải trả: {SoTienPhaiTra}\n";
        }
    }
}
