using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTongHop.Models
{
    internal class DanhSachKhachHang
    {
        List<KhachHang> listKH = new List<KhachHang> ();
        public void ThemKH(KhachHang kh)
        {
            listKH.Add (kh);
        }

        public int TongKH
        {
            get
            {
                return listKH.Count;
            }
        }

        public int TongSV
        {
            get
            {
                int dem = 0;
                foreach(KhachHang kh in listKH) 
                    if(kh.LaSinhVien == true)
                        dem++;
                    return dem;
            }
        }

        public double TongDoanhThu
        {
            get
            {
                double s  = 0;
                foreach (KhachHang kh in listKH)
                    s += kh.TinhTien;
                return s;
            }
        }

    }
}
