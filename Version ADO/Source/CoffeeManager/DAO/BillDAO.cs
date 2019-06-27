using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    // lớp này có nhiệm vụ là lấy ra cái Bill từ cái id của Table.
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        // phải trả ra 1 cái id của bill dựa vào id của table và dựa theo status.

        // có 2 cách : trả ra id bill hoặc trả ra bill.
        public int GetUncheckBillIDByTableID(int id)
        {
            // lưu ý ở đây không thể dùng ExecuteScalar vì nếu nó có giá trị trong câu query thì được nhưng nếu nó không có giá trị trong câu query sẽ báo lỗi.
            // return (int)DataProvider.Instance.ExecuteScalar("");
            // cách giải quyết: lấy ra số lượng và xem thử nó có thành công hay không xong rồi chuyển nó thành 1 cái bill sau đó từ cái bill đó lấy id ra.
            // Câu query lấy ra danh sách bill
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");
            // nếu như nó có dòng thành công >0
            if (data.Rows.Count > 0)
            {
                // add cái dòng đầu tiên trong data (ở đây có nghĩa là id) vào billID
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            else
                // nghĩa là không có bàn nào hết.
                return -1;
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {

            string query = "UPDATE dbo.Bill SET dateCheckOut = GETDATE(), status = 1, " + " discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        // thêm Bill.
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBill @idTable ", new object[] { id });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
    }
}
