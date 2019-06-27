using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace QuanLyNhanVien
{
    public partial class ucReportAccount : UserControl
    {
        public ucReportAccount()
        {
            InitializeComponent();
        }

        AccountBUS account = new AccountBUS();

        private void ucReportAccount_Load(object sender, EventArgs e)
        {
            EmployeeBindingSource.DataSource = account.GetAllAccount();
            this.reportViewer1.RefreshReport();
        }
    }
}
