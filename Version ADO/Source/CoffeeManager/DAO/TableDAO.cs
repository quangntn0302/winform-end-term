using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        private TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        // tạo hàm dụng LoadTableList.
        // trả ra cái gì ? => danh sách table trong cơ sở dữ liệu.
        // lưu ý : nếu mình trả ra DataTable => nó chỉ có thể hiển thị trên datagridview or combobox
        // ở đây không thể làm vậy được => cần có một lớp trung gian => dùng lớp DTO. (Để tạo ra các control)
        public List<Table> LoadTable()
        {
            // tạo ra một tableList
            List<Table> tableList = new List<Table>();

            // dùng câu này để lấy câu query trong lớp DataProvider
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetTableList");

            // đã có DataTable rồi vấn đề bây giờ là làm sao để chuyển từ DataTable => List<Table> ?
            // DataTable sẽ lấy ra 1 bảng như trong cơ sở dữ liệu (VD: select * from TableFood. thì DataTable sẽ lấy cái bảng sau khi thực hiện xong câu select * from TableFood).
            // => nó sẽ có số Row => chỉ cần chuyển từng Row thành List. => cần có 1 hàm dựng để sử lý DataRows (xử lý bên lớp Table trong folder DTO).

            // sau khi có hàm chuyển từ DataRows =>
            // cho mỗi cái item ở trong danh sách rows bên cơ sở dữ liệu. => lấy ra từng dòng.
            foreach (DataRow item in data.Rows)
            {
                // đưa vào Table là từng Rows.
                Table table = new Table(item);
                // đưa từng dòng đó add vào List<Table> => lấy được danh sách bàn.
                tableList.Add(table);
            }

            return tableList;
        }
        public List<Table> GetListTable()
        {
            List<Table> list = new List<Table>();

            string query = "SELECT * FROM dbo.TableFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
            }

            return list;
        }
    }
}
