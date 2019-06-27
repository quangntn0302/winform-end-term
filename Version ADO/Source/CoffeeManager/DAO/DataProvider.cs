using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        // Vấn đề đặt ra ở đây là làm thế nào để trong 1 lần chỉ có duy nhất 1 connection kết nối đến cơ sở dữ liệu => singleton.
        // =>singleton: làm sao tại 1 thời điểm chỉ duy nhất 1 instance(thể hiện) của thằng nào đó được tạo ra
        // Chú ý:
        // static : bất cứ thằng nào là static thì nó là thằng duy nhất được tạo ra trong suốt vòng đời của chương trình.
        // bản chất của static là chỉ có thể gọi thông qua tên hàm và được khởi tạo một lần duy nhất.
        // tạo singleton.
        private static DataProvider instance; // tạo một đối tượng từ khóa là static và là DataProvider. => nếu bất cứ cài gì thông qua instance để mà lấy ra thì nó là duy nhât bời vì là static.

        // đóng gói dữ liệu
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } // bên ngoài chỉ có thể lấy nó ra để sài và không được thay đổi dữ liệu.
        }

        // Hàm dựng đảm bảo bên ngoài không thể tác động vào được chỉ có thể lấy ra sài không sửa được.
        private DataProvider() { }

        private string connectionSTR = "Data Source=DESKTOP-GS1I3Q1\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"; // chuỗi kết nối.

        // trả ra 1 bảng. trả ra những dòng kết quả
        public DataTable ExecuteQuery(string query, object[] parameter = null) // dữ liệu trả ra là DataTable và cần biết thực hiện câu query nào + mảng object parameter. object parameter có thể null (trong câu dtgvAccount.DataSource = provider.ExecuteQuery(query,"quang") có thể bỏ quang (quang chính là 1 parameter)). 
        {
            DataTable data = new DataTable(); // lấy dữ liệu đỗ vào DataTable.

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // trung gian. using (khi khối lệnh thực hiện xong thì connection tự giải phóng).
            {
                connection.Open(); // mở chuỗi kết nối.

                SqlCommand command = new SqlCommand(query, connection); // exec câu query trên của connection.

                //command.Parameters.AddWithValue("@userName", id); // truyền parameters với value là "@userName" + id VD. "@userName = "quang"" (quang chính là id). ==> đối với 1 parameter.

                if (parameter != null) // nếu parameter không phải null.
                {
                    string[] listPara = query.Split(' '); // nó sẽ splip theo khoảng trắng. VD: EXEC USP_GetAccountByUserName @userName. query.Split(theo khoảng trắng trong câu query). Nó sẽ toàn bộ chữ trước và sau khoảng trắng.

                    int i = 0;

                    foreach (string item in listPara) // mỗi item (chữ và trước khoảng trẳng trong câu query) ở trong listpara.
                    {
                        if (item.Contains('@')) // kiểm tra nếu item lấy trong listpara có ký tự @
                        {
                            command.Parameters.AddWithValue(item, parameter[i]); // truyền parameter với value là từng item (@username) với từng giá trị của parameter. VD: @username, @username (2 parameter).
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command); // trung gian thực hiện câu truy vấn lấy dữ liệu ra.

                adapter.Fill(data); // đỗ dữ liệu vào data.

                connection.Close(); // đóng chuỗi kết nối.
            }

            return data;
        }

        // trả ra số dòng thành công. (thường dùng trong insert, update, delete). trả ra số dòng được thực thi
        public int ExecuteNonQuery(string query, object[] parameter = null) // dữ liệu trả ra là DataTable và cần biết thực hiện câu query nào + mảng object parameter. object parameter có thể null (trong câu dtgvAccount.DataSource = provider.ExecuteQuery(query,"quang") có thể bỏ quang (quang chính là 1 parameter)). 
        {
            int data = 0; // 0 dòng thành công.

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // trung gian. using (khi khối lệnh thực hiện xong thì connection tự giải phóng).
            {
                connection.Open(); // mở chuỗi kết nối.

                SqlCommand command = new SqlCommand(query, connection); // exec câu query trên của connection.

                //command.Parameters.AddWithValue("@userName", id); // truyền parameters với value là "@userName" + id VD. "@userName = "quang"" (quang chính là id). ==> đối với 1 parameter.

                if (parameter != null) // nếu parameter không phải null.
                {
                    string[] listPara = query.Split(' '); // nó sẽ splip theo khoảng trắng. VD: EXEC USP_GetAccountByUserName @userName. query.Split(theo khoảng trắng trong câu query). Nó sẽ toàn bộ chữ trước và sau khoảng trắng.

                    int i = 0;

                    foreach (string item in listPara) // mỗi item (chữ và trước khoảng trẳng trong câu query) ở trong listpara.
                    {
                        if (item.Contains('@')) // kiểm tra nếu item lấy trong listpara có ký tự @
                        {
                            command.Parameters.AddWithValue(item, parameter[i]); // truyền parameter với value là từng item (@username) với từng giá trị của parameter. VD: @username, @username (2 parameter).
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close(); // đóng chuỗi kết nối.
            }

            return data;
        }

        // đếm số. vd: select count(*). số lượng trả ra. ô đầu tiên trong DataSet. VD số lượng nhân viên là = 10; ô đầu tiên trong DataSet = 10.
        public object ExecuteScalar(string query, object[] parameter = null) // dữ liệu trả ra là DataTable và cần biết thực hiện câu query nào + mảng object parameter. object parameter có thể null (trong câu dtgvAccount.DataSource = provider.ExecuteQuery(query,"quang") có thể bỏ quang (quang chính là 1 parameter)). 
        {
            object data = 0; // để bằng 0 cho khỏi bị null, xác định kiểu dữ liệu.

            using (SqlConnection connection = new SqlConnection(connectionSTR)) // trung gian. using (khi khối lệnh thực hiện xong thì connection tự giải phóng).
            {
                connection.Open(); // mở chuỗi kết nối.

                SqlCommand command = new SqlCommand(query, connection); // exec câu query trên của connection.

                //command.Parameters.AddWithValue("@userName", id); // truyền parameters với value là "@userName" + id VD. "@userName = "quang"" (quang chính là id). ==> đối với 1 parameter.

                if (parameter != null) // nếu parameter không phải null.
                {
                    string[] listPara = query.Split(' '); // nó sẽ splip theo khoảng trắng. VD: EXEC USP_GetAccountByUserName @userName. query.Split(theo khoảng trắng trong câu query). Nó sẽ toàn bộ chữ trước và sau khoảng trắng.

                    int i = 0;

                    foreach (string item in listPara) // mỗi item (chữ và trước khoảng trẳng trong câu query) ở trong listpara.
                    {
                        if (item.Contains('@')) // kiểm tra nếu item lấy trong listpara có ký tự @
                        {
                            command.Parameters.AddWithValue(item, parameter[i]); // truyền parameter với value là từng item (@username) với từng giá trị của parameter. VD: @username, @username (2 parameter).
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar(); ;

                connection.Close(); // đóng chuỗi kết nối.
            }

            return data;
        }
    }
}
