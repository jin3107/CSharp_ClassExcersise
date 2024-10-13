using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCard
{
    internal class Card
    {
        private string tuaDe;
        private string tacGia;
        private int soLuongBan;

        public Card() { }

        public Card(string tuaDe, string tacGia, int soLuongBan)
        {
            this.tuaDe = tuaDe;
            this.tacGia = tacGia;
            this.soLuongBan = soLuongBan;
        }

        public string TuaDe 
        {
            get => tuaDe;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    tuaDe = value.Trim();
                else
                    throw new ArgumentException("Tựa đề không được để trống.");
            }
        }

        public string TacGia 
        {
            get => tacGia;
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    tacGia = value.Trim();
                else
                    throw new ArgumentException("Tác giả không được để trống.");
            } 
        }

        public int SoLuongBan 
        { 
            get => soLuongBan; 
            set
            {
                if (value >= 0)
                    soLuongBan = value;
                else
                    throw new ArgumentException("Số lượng bán là số dương.");
            }
        }
    }
}
