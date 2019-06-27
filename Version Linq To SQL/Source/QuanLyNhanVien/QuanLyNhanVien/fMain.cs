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

namespace QuanLyNhanVien
{
    public partial class fMain : Form
    {
        AccountBUS account = new AccountBUS();
        public fMain()
        {
           InitializeComponent();
           
           lblDisplayName.Text = account.Getabc(fLogin.GetDisplayName());
            MessageBox.Show(account.Getabc(fLogin.GetDisplayName()));
            
        }
        Boolean flag;
        int x, y;

        private void fMain_Load(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucEmployee());
            pnlMoveButton.Left = btnEmployee.Left + 5;
            pnlMoveButton.Width = btnEmployee.Width - 1;
        }

        #region Method

        #endregion

        #region Events
        private void picAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm được viết bởi nhóm X.\nNgười hướng dẫn Y.");

        }
        private void picSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nếu phần mềm bị lỗi vui lòng thử lại.Hoặc liên hệ \nSố điện thoại: XXX.XXX.XXX |\tE-Mail: XXX@gmail.com");
        }
        private void btnExitHeader_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin f = new fLogin();
            f.Show();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlMoveButton.Left = btnEmployee.Left + 5;
            pnlMoveButton.Width = btnEmployee.Width - 1;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucEmployee());
        }
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            pnlMoveButton.Left = btnDepartment.Left + 5;
            pnlMoveButton.Width = btnDepartment.Width - 1;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucDepartment());
        }
        private void btnCity_Click(object sender, EventArgs e)
        {
            pnlMoveButton.Left = btnCity.Left + 5;
            pnlMoveButton.Width = btnCity.Width - 1;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucCIty());
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            pnlMoveButton.Left = btnFamily.Left + 5;
            pnlMoveButton.Width = btnFamily.Width - 1;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucFamily());
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            pnlMoveButton.Left = btnProject.Left + 5;
            pnlMoveButton.Width = btnProject.Width - 1;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucProject());
        }
        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin f = new fLogin();
            f.Show();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucEmployee());
            pnlMoveButton.Left = btnEmployee.Left + 5;
            pnlMoveButton.Width = btnEmployee.Width - 1;
        }

        private void lblDisplayName_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fFunction f = new fFunction();
            f.Show();
        }
        #endregion
    }
}
