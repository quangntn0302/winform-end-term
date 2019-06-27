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
    public partial class ucReportCity : UserControl
    {
        public ucReportCity()
        {
            InitializeComponent();
        }

        CityBUS city = new CityBUS();

        private void ucReportCity_Load(object sender, EventArgs e)
        {
            CityBindingSource.DataSource = city.GetAllCity();
            this.reportViewer1.RefreshReport();
        }
    }
}
