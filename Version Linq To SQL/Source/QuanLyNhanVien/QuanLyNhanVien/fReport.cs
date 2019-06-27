using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void btnReportAccount_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucReportAccount());
            pnlMoveButton.Left = btnReportAccount.Left + 5;
            pnlMoveButton.Width = btnReportAccount.Width - 1;
        }

        private void btnReportDepatment_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucReportDepartment());
            pnlMoveButton.Left = btnReportDepartment.Left + 5;
            pnlMoveButton.Width = btnReportDepartment.Width - 1;
        }

        private void btnReportCity_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucReportCity());
            pnlMoveButton.Left = btnReportCity.Left + 5;
            pnlMoveButton.Width = btnReportCity.Width - 1;
        }

        private void btnReportFamily_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucReportFamily());
            pnlMoveButton.Left = btnReportFamily.Left + 5;
            pnlMoveButton.Width = btnReportFamily.Width - 1;
        }

        private void btnReportProject_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucReportProject());
            pnlMoveButton.Left = btnReportProject.Left + 5;
            pnlMoveButton.Width = btnReportProject.Width - 1;
        }

        private void fReport_Load(object sender, EventArgs e)
        {
            btnReportAccount.Enabled = false;
            btnReportCity.Enabled = false;
            btnReportDepartment.Enabled = false;
            btnReportFamily.Enabled = false;
            btnReportProject.Enabled = false;

            pnlShow.Visible = false;
            bunifuTileButton4.Enabled = false;
            panel5.Visible = true;
            panel5.Left = pnlShow.Left;
            timer1.Start();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f = new fMain();
            f.Show();
        }

        private void btnExitHeader_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nếu phần mềm bị lỗi vui lòng thử lại.Hoặc liên hệ \nSố điện thoại: XXX.XXX.XXX |\tE-Mail: XXX@gmail.com");

        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm được viết bởi nhóm X.\nNgười hướng dẫn Y.");

        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            pnlShow.Visible = false;
            bunifuTileButton4.Enabled = false;
            panel5.Visible = true;
            panel5.Left = pnlShow.Left;
            btnReportAccount.Enabled = false;
            btnReportCity.Enabled = false;
            btnReportDepartment.Enabled = false;
            btnReportFamily.Enabled = false;
            btnReportProject.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucReportAccount());
            pnlMoveButton.Left = btnReportAccount.Left + 5;
            pnlMoveButton.Width = btnReportAccount.Width - 1;
            for (int i = 0; i < 10000; i++)
            {
                if (i == 9999)
                {
                    timer1.Stop();
                    pnlShow.Visible = true;
                    panel5.Visible = false;
                    panel5.Left = 1015;
                    btnReportAccount.Enabled = true;
                    btnReportCity.Enabled = true;
                    btnReportDepartment.Enabled = true;
                    btnReportFamily.Enabled = true;
                    btnReportProject.Enabled = true;
                    break;
                }
            }
        }
    }
}
