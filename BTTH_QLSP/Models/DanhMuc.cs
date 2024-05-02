using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH_QLSP.Models
{
    public class DanhMuc
    {
        public string ID { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }

        // Danh sách để chứa các SP
        public List<SanPham> ListSP { get; set; }

        // Hàm khởi tạo
        public DanhMuc() 
        {
            // Khởi tạo 1 ds rỗng
            ListSP = new List<SanPham>();   
        }

        // Xuất thông tin của 1 danh mục
        public override string ToString()
        {
            return ID + "- " + Name;
        }
    }
}
