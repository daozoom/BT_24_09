using System;
using System.Text;

namespace BT_24_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DanhSachSinhVien ds = new DanhSachSinhVien();

            for(int i = 0; i < 3; i++)
            {
                SinhVien sv = new SinhVien();
                Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
                sv.NhapThongTin(); ;
                ds.ThemSinhVien(sv);
            }

            ds.HienThiDanhSach();

            SinhVien svMax = ds.TinhDiemTrungBinhCaoNhat();
            if(svMax != null )
            {
                Console.WriteLine("Sinh viên có điểm trung bình cao nhất: ");
                svMax.HienThiThongTin();
            }

            Console.WriteLine("Nhập MSSV của sinh viên cần tìm: ");
            string mssv = Console.ReadLine();
            ds.TimSinhVienTheoMSSV(mssv);

            Console.ReadLine();
        }
    }
}