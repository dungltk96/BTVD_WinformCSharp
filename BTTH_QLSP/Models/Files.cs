using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace BTTH_QLSP.Models
{
    public class Files
    {
        // Hàm lưu file
        public static bool LuuFile(List<DanhMuc> ListDM, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter(); 
                bf.Serialize(fs, ListDM);
                fs.Close();
                return true;

            }catch (Exception ex)
            {
                throw ex;
            }
        }

        // Hàm đọc file
        public static List<DanhMuc> DocFile(string path)
        {
            List<DanhMuc> ds = new List<DanhMuc>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                ds = data as List<DanhMuc>;
                fs.Close();
            }catch (Exception ex)
            {
                throw ex;
            }


            return ds;
        }
    }
}
