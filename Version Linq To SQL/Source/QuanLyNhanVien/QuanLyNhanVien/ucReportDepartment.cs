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
    public partial class ucReportDepartment : UserControl
    {
        public ucReportDepartment()
        {
            InitializeComponent();
        }

        DepartmentBUS dp = new DepartmentBUS();

        private void ucReportDepartment_Load(object sender, EventArgs e)
        {
            DepartmentBindingSource.DataSource = dp.GetAllDepartment();
            this.reportViewer1.RefreshReport();
        }
    }
}
