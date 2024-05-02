using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH_QLSP.Models
{
    public class SanPham
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Origin { get; set; }
        public DateTime NgaySX { get; set; }

        public DanhMuc isDanhMuc { get; set; }
        public override string ToString()
        {
            return ID + "-" + Name + "-" + Price + "-" + Origin + "-" + NgaySX;
        }
    }
}
