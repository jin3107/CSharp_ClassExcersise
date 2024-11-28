using System;
using System.Text;

namespace QuanLyKhachSan
{
    public class Phong
    {
        public string LoaiPhong { get; set; }
        public int GiaPhong { get; set; }

        public Phong() { }

        public Phong(string loaiPhong, int giaPhong)
        {
            Console.OutputEncoding = Encoding.UTF8;

            switch (loaiPhong)
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
