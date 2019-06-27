using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using System.Threading;

namespace QuanLyNhanVien
{
    public partial class fLogin : Form
    {
        public static string getDisplayName;

        
        public fLogin()
        {
            InitializeComponent();
            Init_Data();
        }
        AccountBUS accountbus = new AccountBUS();
        Boolean flag;
        int x, y;

        #region Method
        void Init_Data()
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                if(Properties.Settings.Default.Remme == "yes")
                {
                    txbUser.Text = Properties.Settings.Default.UserName;
                    txbPass.Text = Properties.Settings.Default.Password;
                    ckbRemember.Checked = true;
                }
                else
                {
                    txbUser.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        void Save_Data()
        {
            if(ckbRemember.Checked == true)
            {
                Properties.Settings.Default.UserName = txbUser.Text;
                Properties.Settings.Default.Password = txbPass.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = txbUser.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        #region Event
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }

        private void panelTotal_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void panelTotal_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }

        private void btnExitHeader_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(txbUser.Text == "Admin01" || txbUser.Text == "Admin02" || txbUser.Text == "Admin03")
            {
                if (accountbus.CheckAccount(txbUser.Text, txbPass.Text) == true)
                {
                    Save_Data();
                    getDisplayName = txbUser.Text;
                    panelTotal.Visible = false;
                    panel8.Visible = true;
                    panel8.Left = panelTotal.Left;
                    timer1.Start();
                }
                else
                {
                    panelTotal.Visible = false;
                    panel8.Visible = true;
                    panel8.Left = panelTotal.Left;
                    timer2.Start();
                }
            }
            else
            {
                panelTotal.Visible = false;
                panel8.Visible = true;
                panel8.Left = panelTotal.Left;
                timer3.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (i == 999999)
                {
                    fMain f = new fMain();
                    timer1.Stop();
                    this.Hide();
                    f.Show();
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
                    panelTotal.Visible = true;
                    panel8.Visible = false;
                    panel8.Left = 815;
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.Vui lòng thử lại.");
                    break;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                if (i == 9999)
                {
                    timer3.Stop();
                    panelTotal.Visible = true;
                    panel8.Visible = false;
                    panel8.Left = 815;
                    MessageBox.Show("Tài khoản của bạn không thể đăng nhập vào hệ thống.\nVui lòng liên hệ quản trị viên.");
                    break;
                }
            }
        }
        public static string GetDisplayName()
        {
            return getDisplayName;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panelTotal_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
        #endregion
      
    }
}
