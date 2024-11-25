using System;
using System.Text;

namespace QuanLyKhachSan
{
    internal class Phong
    {
        private string loaiPhong;
        private int giaPhong;

        public Phong() { }

        public Phong(string loaiPhong, int giaPhong)
        {
            this.LoaiPhong = loaiPhong;
            this.GiaPhong = giaPhong;
        }

        public string LoaiPhong
        {
            get => loaiPhong;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    loaiPhong = value.Trim(); // Sử dụng biến thành viên thay vì gọi thuộc tính
                else
                    throw new ArgumentException("Loại phòng không được để trống.");
            }
        }

        public int GiaPhong
        {
            get => giaPhong;
            set
            {
                if (value > 1)
                    giaPhong = value;
                else
                    throw new ArgumentException("Giá phòng là số dương và lớn hơn 0.");
            }
        }

        public Phong(string loai)
        {
            Console.OutputEncoding = Encoding.UTF8;

            switch (loai)
            {
                case "A":
                    LoaiPhong = "A";
                    GiaPhong = 500;
                    break;
                case "B":
                    LoaiPhong = "B";
                    GiaPhong = 300;
                    break;
                case "C":
                    LoaiPhong = "C";
                    GiaPhong = 100;
                    break;
                default:
                    throw new ArgumentException("Loại phòng không hợp lệ.");
            }
        }

        public override string ToString()
        {
            return $"Phong {{ LoaiPhong = {LoaiPhong}, GiaPhong = {GiaPhong} }}";
        }
    }
}
