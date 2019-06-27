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
    public partial class ucFunctionEmployee : UserControl
    {
        QLNVDataContext NhanViens = new QLNVDataContext();
        public ucFunctionEmployee()
        {
            InitializeComponent();
        }

        AccountBUS account = new AccountBUS();
        
        private void ucFunctionEmployee_Load(object sender, EventArgs e)
        {
            dtgvLoadEmployee.DataSource = account.GetAllAccount();
        }


        private void txbCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSearchCodeEmpolyee_Click(object sender, EventArgs e)
        {
            dtgvLoadEmployee.DataSource = account.GetFindAccount(txbCode.Text);

        }

        private void btnSumSalary_Click_1(object sender, EventArgs e)
        {
            float sum = 0;
            for (int i = 0; i < dtgvLoadEmployee.Rows.Count; i++)
                sum += (float)Convert.ToDouble(dtgvLoadEmployee.Rows[i].Cells[5].Value);
            txbSumSalary.Text = sum.ToString();

            int count = dtgvLoadEmployee.Rows.Count;
            double avg = sum / count;
            MessageBox.Show(avg.ToString());
        }
    }
}
