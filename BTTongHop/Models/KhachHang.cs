using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTongHop.Models
{
    internal class KhachHang
    {
        const int DONGGIA = 10000;
        public string HoTenKHang { get; set; }
        public int SoLuongMua { get; set; }
        public bool LaSinhVien { get; set; }
        public double TinhTien
        {
            // Sử dụng thuộc tính thành tiền, chỉ lấy ra nên sử dụng get
            get
            {
                if(LaSinhVien == true)
                {
                    return SoLuongMua*DONGGIA*0.95;
                }
                else
                {
                    return SoLuongMua*DONGGIA;
                }
            }
        }
    }
}
