using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace CoffeeManager
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        #region Method
        BindingSource accountList = new BindingSource();
        void LoadData()
        {
            dtgvAccount.DataSource = accountList;

            LoadAccount();

            AddAccountBinding();

            btnAccount.Enabled = true;
            btnEditAccount.Enabled = true;
            btnDeleteAccount.Enabled = false;
            btnSaveAccount.Enabled = false;
            btnShowAccount.Enabled = true;
            btnReportAccount.Enabled = false;
            txbDisplayName.Enabled = true;
        }
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Reset mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            LoadAccount();
        }
        void DeleteAccount(string userName)
        {
            if (fLogin.Abc().Equals(userName))
            {
                MessageBox.Show("Tài khoản đang login không thể xóa");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            LoadAccount();
        }
        void SaveAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            LoadAccount();
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            LoadAccount();
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #region Events
        private void fAdmin_Load(object sender, EventArgs e)
        {
            panel7.Height = btnBill.Height - 1;
            panel7.Top = btnBill.Top + 55;

            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucBill());
            pnlAccount.Left = 917;
            pnlShow.Left = 228;
            LoadData();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            panel7.Height = btnBill.Height - 1;
            panel7.Top = btnBill.Top + 55;

            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucBill());
            pnlAccount.Left = 917;
            pnlShow.Left = 228;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            panel7.Height = btnFood.Height - 1;
            panel7.Top = btnFood.Top + 55;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucFood());
            pnlAccount.Left = 917;
            pnlShow.Left = 228;

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panel7.Height = btnAccount.Height - 1;
            panel7.Top = btnAccount.Top + 55;
            pnlShow.Controls.Clear();
            pnlAccount.Left = 228;
            pnlShow.Left = 917;
        }

        private void btnFoodCategory_Click(object sender, EventArgs e)
        {
            panel7.Height = btnFoodCategory.Height - 1;
            panel7.Top = btnFoodCategory.Top + 55;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucFoodCategory());
            pnlAccount.Left = 917;
            pnlShow.Left = 228;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            panel7.Height = btnTable.Height - 1;
            panel7.Top = btnTable.Top + 55;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucTableFood());
            pnlAccount.Left = 917;
            pnlShow.Left = 228;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Account loginAccount = AccountDAO.Instance.GetAccountByUserName(fLogin.Abc());
            panel7.Height = btnGoBack.Height - 1;
            panel7.Top = btnGoBack.Top + 55;
            fTableManager f = new fTableManager(loginAccount);
            this.Hide();
            f.Show();
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btnAddAccount_Click_1(object sender, EventArgs e)
        {

            if (AccountDAO.Instance.CheckAccountExits(txbUserName.Text)==false)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }
            else
            {
                string userName = txbUserName.Text;
                string displayName = txbDisplayName.Text;
                int type = (int)nmAccountType.Value;
                AddAccount(userName, displayName, type);
            }        
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;
            SaveAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            DeleteAccount(userName);
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            ResetPass(userName);
        }
    }
}
