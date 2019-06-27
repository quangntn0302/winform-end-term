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
    public partial class ucReportProject : UserControl
    {
        public ucReportProject()
        {
            InitializeComponent();
        }

        ProjectBUS project = new ProjectBUS();

        private void ucReportProject_Load(object sender, EventArgs e)
        {
            ProjectBindingSource.DataSource = project.GetAllProject(); 
            this.reportViewer1.RefreshReport();
        }
    }
}
