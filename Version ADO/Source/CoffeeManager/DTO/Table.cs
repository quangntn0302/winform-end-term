using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //lớp Table này dùng để lưu trữ những thuộc tính của thằng table trong cơ sở dữ liệu.
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        // hàm dựng xử lý chuyển từ Row => List.
        public Table(DataRow row)
        {
            // lưu ý các tên trong row phải trùng với tên trong cơ sở dữ liệu. 
            // lấy ra cái trường có tên là id trong cơ sở dữ liệu
            this.ID = (int)row["id"]; // => thằng này trả ra là 1 kiểu object.
            // lấy ra trường có tên là name trong cơ  sở dữ liệu.
            this.Name = row["name"].ToString();
            // lấy ra trường status trong cơ sở dữ liệu.
            this.Status = row["status"].ToString();
        }

        // các cột trong cở sở dữ liệu.(Lấy hết)
        private string status;
        private string name;
        private int iD;

        // Tạo đóng gói.
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
