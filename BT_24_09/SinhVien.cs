using System;

namespace BT_24_09
{
    public class SinhVien
    {
        public string HoTen {  get; set; }
        public string MSSV {  get; set; }
        public double DiemTrungBinh {  get; set; }

        public void NhapThongTin()
        {
            Console.Write("Nhập họ và tên sinh viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập mã số sinh viên: ");
            MSSV = Console.ReadLine();
            Console.Write("Nhập điểm trung bình: ");
            DiemTrungBinh = double.Parse(Console.ReadLine());
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen} - MSSV: {MSSV} - Điểm trung bình: {DiemTrungBinh}");
        }
    }
}
