using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.NgoaiLe
{
    public class NgoaiLeHoTen : Exception
    {
        public NgoaiLeHoTen(string message) : base(message)
        {
        }
    }

}
