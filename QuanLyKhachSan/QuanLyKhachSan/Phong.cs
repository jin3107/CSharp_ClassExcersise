using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    LoaiPhong = value.Trim();
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
    }
}
