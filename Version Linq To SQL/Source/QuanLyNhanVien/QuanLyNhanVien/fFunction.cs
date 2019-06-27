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
    public partial class fFunction : Form
    {
        public fFunction()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucFunctionEmployee());
            pnlMoveButton.Left = btnEmployee.Left + 5;
            pnlMoveButton.Width = btnEmployee.Width - 1;
        }

        private void fFunction_Load(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(new ucFunctionEmployee());
            pnlMoveButton.Left = btnEmployee.Left + 5;
            pnlMoveButton.Width = btnEmployee.Width - 1;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f = new fMain();
            f.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReport f = new fReport();
            f.Show();
        }
    }
}
