using System;

namespace BTHocSinh
{
    internal class HocSinh
    {
        private string hoTen;
        private string lopHoc;
        private double dToan;
        private double dLy;
        private double dHoa;

        public HocSinh() { }

        public HocSinh(string hoTen, string lopHoc, double dToan, double dLy, double dHoa)
        {
            this.HoTen = hoTen;
            this.LopHoc = lopHoc;
            this.DToan = dToan;
            this.DLy = dLy;
            this.DHoa = dHoa;
        }

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

        public string LopHoc
        {
            get => lopHoc;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    lopHoc = value.Trim();
                else
                    throw new ArgumentException("Lớp học không được để trống.");
            }
        }

        public double DToan
        {
            get => dToan;
            set
            {
                if (value >= 0 && value <= 10)
                    dToan = value;
                else
                    throw new ArgumentException("Điểm Toán phải nằm trong khoảng 0 đến 10.");
            }
        }

        public double DLy
        {
            get => dLy;
            set
            {
                if (value >= 0 && value <= 10)
                    dLy = value;
                else
                    throw new ArgumentException("Điểm Lý phải nằm trong khoảng 0 đến 10.");
            }
        }

        public double DHoa
        {
            get => dHoa;
            set
            {
                if (value >= 0 && value <= 10)
                    dHoa = value;
                else
                    throw new ArgumentException("Điểm Hóa phải nằm trong khoảng 0 đến 10.");
            }
        }

        public double DiemTB()
        {
            return (DToan + DLy + DHoa) / 3.0;
        }
    }
}