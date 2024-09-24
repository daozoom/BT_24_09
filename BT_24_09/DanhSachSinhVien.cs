using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace BT_24_09
{
    public class DanhSachSinhVien
    {
        private List<SinhVien> sinhViens = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sv)
        {
            sinhViens.Add(sv);
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("Danh sách sinh viên: ");
            foreach (var sv in sinhViens)
            {
                sv.HienThiThongTin();
            }
        }

        public void TimSinhVienTheoMSSV(string mssv)
        {
            SinhVien found = sinhViens.Find(sv => sv.MSSV == mssv);
            if(found != null)
            {
                Console.WriteLine("Thông tin sinh viên đã được tìm thấy:");
                found.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với MSSV này.");
            }
        }

        public SinhVien TinhDiemTrungBinhCaoNhat()
        {
            if (sinhViens.Count == 0)
                return null;

            SinhVien svMax = sinhViens[0];
            foreach (var sv in sinhViens)
            {
                if(sv.DiemTrungBinh > svMax.DiemTrungBinh)
                {
                    svMax = sv;
                }
            }
            return svMax;
        }
    }
}
