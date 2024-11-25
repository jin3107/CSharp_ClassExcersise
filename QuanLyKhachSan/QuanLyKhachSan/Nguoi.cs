using System;
using System.Text;

namespace QuanLyKhachSan
{
    internal class Nguoi
    {
        private string hoTen;
        private int tuoi;
        private string cmnd;
        private Phong phongThue; // Thông tin phòng thuê
        private int soNgayThue;  // Số ngày thuê phòng

        public Nguoi(string hoTen, int tuoi, string cmnd, Phong phongThue, int soNgayThue)
        {
            this.HoTen = hoTen;
            this.Tuoi = tuoi;
            this.Cmnd = cmnd;
            this.PhongThue = phongThue;
            this.SoNgayThue = soNgayThue;
        }

        public Nguoi() { }

        public string HoTen
        {
            get => hoTen;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    hoTen = value.Trim();
                else
                    throw new ArgumentException("Họ tên không được để trống.");
            }
        }

        public int Tuoi
        {
            get => tuoi;
            set
            {
                if (value >= 1)
                    tuoi = value;
                else
                    throw new ArgumentException("Tuổi là số nguyên dương.");
            }
        }

        public string Cmnd
        {
            get => cmnd;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    cmnd = value.Trim();
                else
                    throw new ArgumentException("CMND không được để trống.");
            }
        }

        internal Phong PhongThue
        {
            get => phongThue;
            set => phongThue = value;
        }

        public int SoNgayThue
        {
            get => soNgayThue;
            set
            {
                if (value > 0)
                    soNgayThue = value;
                else
                    throw new ArgumentException("Số ngày thuê phải là số nguyên dương.");
            }
        }

        // Nhập thông tin khách
        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Họ tên: ");
            HoTen = Console.ReadLine();

            while (true)
            {
                Console.Write("Nhập tuổi: ");
                if (int.TryParse(Console.ReadLine(), out int tuoi) && tuoi > 0)
                {
                    Tuoi = tuoi;
                    break;
                }
                Console.WriteLine("Tuổi là một số nguyên dương.");
            }

            Console.Write("Nhập CMND: ");
            Cmnd = Console.ReadLine();

            Console.Write("Chọn loại phòng (A, B, C): ");
            string loaiPhong = Console.ReadLine().ToUpper();
            switch (loaiPhong)
            {
                case "A":
                    PhongThue = new Phong("A", 500);
                    break;
                case "B":
                    PhongThue = new Phong("B", 300);
                    break;
                case "C":
                    PhongThue = new Phong("C", 100);
                    break;
                default:
                    throw new ArgumentException("Loại phòng không hợp lệ.");
            }

            while (true)
            {
                Console.Write("Nhập số ngày thuê: ");
                if (int.TryParse(Console.ReadLine(), out int soNgay) && soNgay > 0)
                {
                    SoNgayThue = soNgay;
                    break;
                }
                Console.WriteLine("Số ngày thuê phải là số nguyên dương.");
            }
        }

        // Hiển thị thông tin khách
        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tên: {HoTen}, Tuổi: {Tuoi}, CMND: {Cmnd}");
            Console.WriteLine($"Phòng: {PhongThue.LoaiPhong}, Giá: {PhongThue.GiaPhong}, Số ngày thuê: {SoNgayThue}");
            Console.WriteLine($"Tổng tiền: {PhongThue.GiaPhong * SoNgayThue}\n");
        }
    }
}
