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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            Init_Data();
        }

        #region Paramater
        public static string abc;
        public static string Abc()
        {
            return abc;
        }
        Boolean flag;
        int x, y;
        #endregion

        #region Method
        // kiểm tra tài khoản login.
        bool CheckTextBox(string userName,string passWord)
        {
            if (txbUserName.Text == "" || txbPassWord.Text == "")
                return false;
            else
                return true;
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
        // tạo hàm lưu tài khoản. nếu check sẽ lưu 2 thuộc tính là user và pass ngược lại lưu user.
        void Init_Data()
        {
            if (Properties.Settings.Default.userName != string.Empty)
            {
                if (Properties.Settings.Default.rememberMe == "yes")
                {
                    txbUserName.Text = Properties.Settings.Default.userName;
                    txbPassWord.Text = Properties.Settings.Default.passWord;
                    ckhCheck.Checked = true;
                }
                else
                {
                    txbUserName.Text = Properties.Settings.Default.userName;
                }
            }
        }
        // tạo hàm lưu tài khoản. nếu check sẽ lưu 2 thuộc tính là user và pass ngược lại lưu user.
        void Save_Data()
        {
            if (ckhCheck.Checked == true)
            {
                Properties.Settings.Default.userName = txbUserName.Text;
                Properties.Settings.Default.passWord = txbPassWord.Text;
                Properties.Settings.Default.rememberMe = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.userName = txbUserName.Text;
                Properties.Settings.Default.passWord = "";
                Properties.Settings.Default.rememberMe = "no";
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        #region Events
        private void fLogin_Load(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlCheck.Visible = false;
        }
        // bắt sự kiện của formclosing.
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // xét sự kiện đăng nhập.
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txbUserName.Text;
                string passWord = txbPassWord.Text;

                if (CheckTextBox(userName, passWord) == true)
                {
                    if (Login(userName, passWord))
                    {
                        abc = userName;
                        Save_Data();
                        pnlShow.Visible = false;
                        pnlCheck.Visible = true;
                        pnlCheck.Left = pnlShow.Left;
                        timer1.Start();

                    }
                    else
                    {
                        pnlShow.Visible = false;
                        pnlCheck.Visible = true;
                        pnlCheck.Left = pnlShow.Left;
                        timer2.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống tài khoản hoặc password", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }
        // bắt sự kiện di chuyển form.
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }
        // bắt sự kiện di chuyển form.
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            for (int i = 0; i < 1000000; i++)
            {
                if (i == 999999)
                {
                    Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    fTableManager f = new fTableManager(loginAccount);
                    //fTableManager f = new fTableManager();
                    timer1.Stop();
                    this.Hide();
                    f.ShowDialog();
                    break;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                if (i == 9999)
                {
                    timer2.Stop();
                    pnlShow.Visible = true;
                    pnlCheck.Visible = false;
                    pnlCheck.Left = 803;
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.Vui lòng thử lại.","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;
                }
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // bắt sự kiện di chuyển form.
        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        #endregion
    }
}
