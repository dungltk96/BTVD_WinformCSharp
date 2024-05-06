using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLySerializeFile.Models
{
    [Serializable]
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public DateTime NgaySX  { get; set; }

        public override string ToString()
        {
            return MaSP + "-" + TenSP + "-" + NgaySX.ToString("MM/dd/yyyy");
        }
    }
}
