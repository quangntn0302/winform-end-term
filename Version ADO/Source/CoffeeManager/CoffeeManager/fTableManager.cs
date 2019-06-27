using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace CoffeeManager
{
    public partial class fTableManager : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            lblDisplayName.Text = string.Format("Chào, {0}",LoginAccount.DisplayName);
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
        }
        #region Paramater
        Boolean flag;
        int x, y;
        #endregion
        #region Method
        void ChangeAccount(int type)
        {
            if(type == 0)
            {
                ExitToolStripMenuItem.Visible = true;
                UpdateInformationToolStripMenuItem1.Visible = true;
                phímTắtToolStripMenuItem.Visible = true;
                adminToolStripMenuItem.Visible = false;
            }
            if(type == 2)
            {
                ExitToolStripMenuItem.Visible = true;
                UpdateInformationToolStripMenuItem1.Visible = true;
                phímTắtToolStripMenuItem.Visible = false;
                adminToolStripMenuItem.Visible = false;
                lblDiscount.Visible = false;
                nmDiscount.Visible = false;
                btnCheckOut.Visible = false;
                txbTotalPrice.Left = nmDiscount.Left;
                label2.Left = 122;
            }
        }
        // làm sao để thêm được một món vào bill đang chọn. => thêm như thế nào?
        // các trường hợp : TH1. bill chưa có món nào hết. => tạo bill mới. => thêm bill info vào.
        // TH2. đã có bill thêm món mới vào. => không tạo bill mà chỉ thêm món mới vào.
        // TH3. đã có bill và thêm món đã tồn tại trong bill. => thay đổi số lượng của món đó và cập nhập lại số lượng và thành tiền.

        // Load theo danh sách category
        void LoadCategory()
        {
            List<FoodCategory> listCategory = FoodCategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            // dòng này dùng để xác định combobox hiển thị cái gì.
            cbCategory.DisplayMember = "name";
        }
        // load theo danh sách thức ăn theo category
        void LoadFoodListByCategoryId(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryByID(id);
            cbFood.DataSource = listFood;
            // dòng này dùng để xác định combobox hiển thị cái gì.
            cbFood.DisplayMember = "name";
        }
        // load danh sách bàn ăn theo cơ sở dữ liệu.
        // kiểu do người dùng tự định nghĩa (ở đây trong lớp Table ở folder DTO)
        void LoadTable()
        {
            flpTable.Controls.Clear();
            // kiện nghị là hiện thị danh sách lên button.
            // lấy danh sách table.
            List<Table> tablelist = TableDAO.Instance.LoadTable();

            // với mỗi table nằm bên trong tablelist ta tạo ra mỗi button
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableHeight, Height = TableDAO.TableHeight };

                // hiện thị ra tên bàn và trạng thái.
                //btn.Text = item.Name + Environment.NewLine + item.Status; // => add vào button tên bàn và status. Enviroment.NewLine dùng để xuống dòng.

                // xét event khi nhấn vào button sẽ hiện thị danh sách hóa đơn lên
                btn.Click += btn_Click;

                // tableID lấy từ đâu? => khi click vào button thì nó phải xác định được table id => dùng tag
                btn.Tag = item;

                // đổi màu bàn từ trống => không trống.
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackgroundImage = Properties.Resources.rsz_coffee_4;
                        break;
                    default:
                        btn.BackgroundImage = Properties.Resources.rsz_coffee_6;
                        break;
                }

                // add từng btn trong cái tablelist lên flpTable 
                flpTable.Controls.Add(btn);
            }
        }
        // show bill và cần phải biết show bill cho table nào => truyền vào một id
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            // phải làm sao từ id Table có thể lấy ra được id của Bill và từ Bill lấy ra được BillInfo.
            // => hướng giải quyết : giải quyết từng cái. Đầu tiên từ table => bill => tạo class BillDAO
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenyByTable(id);
            float totalPrice = 0;

            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }
            // xử lý tiền tệ chuyển từ về tiền việt nam.
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalPrice.ToString("c");
        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTable();
            cb.DisplayMember = "name";
        }
        #endregion

        #region Events
        private void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as FoodCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as FoodCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void f_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryId((cbCategory.SelectedItem as FoodCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            FoodCategory selected = cb.SelectedItem as FoodCategory;
            id = selected.ID;

            LoadFoodListByCategoryId(id);
        }
        private void btn_Click(object sender, EventArgs e)
        {

            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if(table != null)
            {
                int id1 = (lsvBill.Tag as Table).ID;

                int id2 = (cbSwitchTable.SelectedItem as Table).ID;
                if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.SwitchTable(id1, id2);

                    LoadTable();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn hiện tại để chuyển","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // lấy ra table hiện tại.
            Table table = lsvBill.Tag as Table;
            // lấy ra id bill hiện tại.
            // lấy idbill khi click vào bàn.
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
            // nếu chưa có bill
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            // nếu bill đã tồn tại.
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if(table != null)
            {
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
                int discount = (int)nmDiscount.Value;
                double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
                double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
                if (idBill != -1)
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\nTổng tiền - (Tổng tiền / 100 x giảm giá)\n=> {1} - ({1} / 100 x {2}) = {3}", table.Name, totalPrice, discount, finalTotalPrice), "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                        ShowBill(table.ID);
                        LoadTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn bàn muốn thanh toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void UpdateInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void f_UpdateAccount(object sender, AccountEvent e)
        {
            lblDisplayName.Text = string.Format("Chào, {0}", e.Acc.DisplayName);
        }

        private void picLic_Click(object sender, EventArgs e)
        {

        }

        private void picSup_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fAdmin f = new fAdmin();
            
            f.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin f = new fLogin();
            
            f.Show();    
        }
        #endregion
    }
}
