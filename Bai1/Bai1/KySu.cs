using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public KySu()
        {
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập ngành đào tạo: ");
            NganhDaoTao = Convert.ToString(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Ngành đào tạo: {NganhDaoTao}\n";
        }
    }
}
