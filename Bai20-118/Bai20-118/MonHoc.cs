using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_118
{
    public class MonHoc
    {
        public double diemToan { get; set; }
        public double diemLy { get; set; }
        public double diemHoa { get; set; }
        public double dienAnh { get; set; }
        public double diemTin { get; set; }
        public double diemSinh { get; set; }
        public double diemVan { get; set; }
        public double diemSu { get; set; }
        public double diemDia { get; set; }

        public MonHoc() { }

        public MonHoc(double diemToan, double diemLy, double diemHoa, double dienAnh, double diemTin, double diemSinh, double diemVan, double diemSu, double diemDia)
        {
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
            this.dienAnh = dienAnh;
            this.diemTin = diemTin;
            this.diemSinh = diemSinh;
            this.diemVan = diemVan;
            this.diemSu = diemSu;
            this.diemDia = diemDia;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập điểm các môn học: ");

            Console.Write("Nhập điểm Toán Học: ");
            diemToan = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Vật Lý: ");
            diemLy = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Hóa Học: ");
            diemHoa = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Tiếng Anh: ");
            dienAnh = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Tin Học: ");
            diemTin = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Sinh Học: ");
            diemSinh = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Ngữ Văn: ");
            diemVan = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Lịch Sử: ");
            diemSu = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Địa Lý: ");
            diemDia = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Điểm các môn học:");
            Console.WriteLine($"Điểm Toán Học: {diemToan}");
            Console.WriteLine($"Điểm Vật Lý: {diemLy}");
            Console.WriteLine($"Điểm Hóa Học: {diemHoa}");
            Console.WriteLine($"Điểm Tiếng Anh: {dienAnh}");
            Console.WriteLine($"Điểm Tin Học: {diemTin}");
            Console.WriteLine($"Điểm Sinh Học: {diemSinh}");
            Console.WriteLine($"Điểm Ngữ Văn: {diemVan}");
            Console.WriteLine($"Điểm Lịch Sử: {diemSu}");
            Console.WriteLine($"Điểm Địa Lý: {diemDia}");
        }

        public double DiemTB()
        {
            var avg = (diemToan + diemLy + diemHoa + dienAnh + diemTin + diemSinh + diemVan + diemSu + diemDia) / 9;
            return avg;
        }

        public List<string> MonDiemDuoi5()
        {
            var monDiemDuoi5 = new List<string>();
            if (diemToan < 5)  monDiemDuoi5.Add("Toán Học");
            if (diemLy < 5) monDiemDuoi5.Add("Vật Lý");
            if (diemHoa < 5) monDiemDuoi5.Add("Hóa Học");
            if (dienAnh < 5) monDiemDuoi5.Add("Tiếng Anh");
            if (diemTin < 5) monDiemDuoi5.Add("Tin Học");
            if (diemSinh < 5) monDiemDuoi5.Add("Sinh Học");
            if (diemVan < 5) monDiemDuoi5.Add("Ngữ Văn");
            if (diemSu < 5) monDiemDuoi5.Add("Lịch Sử");
            if (diemDia < 5) monDiemDuoi5.Add("Địa Lý");
            return monDiemDuoi5;
        }
    }
}
