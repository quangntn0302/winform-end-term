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
    public partial class fReportBill : Form
    {
        public fReportBill()
        {
            InitializeComponent();
            lblUserName.Text = fLogin.Abc();
        }

        private void fReportBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyQuanCafeDataSet.Bill' table. You can move, or remove it, as needed.
            this.BillTableAdapter.Fill(this.QuanLyQuanCafeDataSet.Bill);

            this.reportViewer1.RefreshReport();
        }
    }
}
