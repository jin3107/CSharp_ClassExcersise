using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Phong
    {
        public string LoaiPhong { get; set; }
        public int GiaPhong { get; set; }

        public Phong()
        {
        }

        public Phong(string loaiPhong, int giaPhong, int soNgayThue)
        {
            LoaiPhong = loaiPhong;
            GiaPhong = giaPhong;
        }
    }   
}
