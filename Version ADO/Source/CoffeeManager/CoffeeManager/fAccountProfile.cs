using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace CoffeeManager
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        #region Paramater

        #endregion
        void ChangeAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;

        }
        void UpdateAccountNew()
        {
            string displayname = txbDisplayName.Text;
            string password = txbPass.Text;
            string newpass = txbNewPass.Text;
            string reenterpass = txbRePass.Text;
            string userName = txbUserName.Text;
            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayname, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        #region Method

        #endregion

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountNew();
        }
        #endregion

        private void btnChangeDisplayName_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = true;
            pnlChangeDisplayname.Left = 1;
            pnlChangePass.Left = 497;
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void btnChangPasswordAccount_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel8.Visible = false;
            pnlChangeDisplayname.Left = 497;
            pnlChangePass.Left = 7;
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn hủy bỏ những thao tác vừa rồi?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                txbDisplayName.ResetText();
                txbNewPass.ResetText();
                txbPass.ResetText();
                txbRePass.ResetText();
                panel7.Visible = false;
                panel8.Visible = true;
                pnlChangeDisplayname.Left = 1;
                pnlChangePass.Left = 497;
            }           
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
