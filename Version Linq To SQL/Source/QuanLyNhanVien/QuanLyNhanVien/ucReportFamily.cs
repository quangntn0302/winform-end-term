using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QuanLyNhanVien
{
    public partial class ucReportFamily : UserControl
    {
        public ucReportFamily()
        {
            InitializeComponent();
        }

        FamilyBUS family = new FamilyBUS();

        private void ucReportFamily_Load(object sender, EventArgs e)
        {
            FamilyBindingSource.DataSource = family.GetAllFamily();
            this.reportViewer1.RefreshReport();
        }
    }
}
