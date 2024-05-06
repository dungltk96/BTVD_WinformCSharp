using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile.Models
{
    public class Files
    {
        // Hàm ghi (lưu) file
        public static bool LuuFile(List<SanPham> ds, string path)
        {
            try
            {
                // Đối tượng ghi file
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);

                foreach (SanPham itemSP in ds)
                {
                    string line = itemSP.ToString();

                    sw.WriteLine(line);
                }

                sw.Close();
                return true;

            }catch (Exception ex)
            {
                throw ex;
            }
        }

        // Ham doc file
        public static List<SanPham> DocFile(string path)
        {
            List<SanPham> ds = new List<SanPham> ();
            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();

                while (line != null)
                {
                    string[] arr = line.Split('-');
                    if(arr.Length == 3)
                    {
                        SanPham sp = new SanPham ();
                        sp.MaSP = arr[0].Trim();
                        sp.TenSP = arr[1].Trim();
                        string[] item = arr[2].Trim().Split('/');
                        sp.NgaySX = new DateTime(int.Parse(item[2]), int.Parse(item[0]), int.Parse(item[1]));
                        ds.Add(sp);
                    }
                    
                    // Chuyển đầu đọc sang dòng tiếp theo
                    line = sr.ReadLine();
                }
                sr.Close();

            }catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

    }
}
