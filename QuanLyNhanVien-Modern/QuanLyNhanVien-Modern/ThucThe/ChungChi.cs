using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.ThucThe
{
    internal class ChungChi
    {
        private string ma;
        private string ten;
        private DateTime ngayCap;
        private string xepLoai;

        public ChungChi()
        {
        }

        public ChungChi(string ma, string ten, DateTime ngayCap, string xepLoai)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.NgayCap = ngayCap;
            this.XepLoai = xepLoai;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgayCap { get => ngayCap; set => ngayCap = value; }
        public string XepLoai { get => xepLoai; set => xepLoai = value; }
    }
}
