using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Modern.NgoaiLe
{
    public class NgoaiLeNgaySinh : Exception
    {
        public NgoaiLeNgaySinh(string message) : base(message)
        {
        }
    }
}
