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
    public partial class ucDepartment : UserControl
    {
        DepartmentBUS dtb = new DepartmentBUS();
        public ucDepartment()
        {
            InitializeComponent();
        }

        #region Method
        bool CheckAddDepartmentNull()
        {
            if (txbDepartmentCode.Text == "" || txbDepartmentName.Text == "" || txbManagerDepartmentCode.Text == "" )
            {
                MessageBox.Show("Thông tin bạn nhập vẫn chưa đủ. Vui lòng kiểm tra lại");
                return false;
            }
            else
                return true;
        }
        void ResetText()
        {
            txbDepartmentCode.ResetText();
            txbDepartmentName.ResetText();
            txbManagerDepartmentCode.ResetText();
            txbDepartmentCode.Focus();
        }
        #endregion

        #region Events
        private void ucDepartment_Load(object sender, EventArgs e)
        {
            dtgvLoadDepartment.DataSource = dtb.GetAllDepartment();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            txbDepartmentCode.Enabled = true;
            txbDepartmentName.Enabled = true;
            txbManagerDepartmentCode.Enabled = true;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            dtb.DeleteDepartment(txbDepartmentCode.Text);
            MessageBox.Show(String.Format("Phòng ban {0} đã được xóa.", txbDepartmentCode.Text));
            dtgvLoadDepartment.DataSource = dtb.GetAllDepartment();
            ResetText();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;

            txbDepartmentCode.Enabled = true;
            txbDepartmentName.Enabled = true;
            txbManagerDepartmentCode.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database đã được reload");
            dtgvLoadDepartment.DataSource = dtb.GetAllDepartment();
            ResetText();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;

            txbDepartmentCode.Enabled = true;
            txbDepartmentName.Enabled = true;
            txbManagerDepartmentCode.Enabled = true;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckAddDepartmentNull() == true)
            {
                if (dtb.CheckDepartmentExits(txbDepartmentCode.Text) == true)
                {
                    dtb.AddDepartment(txbDepartmentCode.Text, txbDepartmentName.Text, txbManagerDepartmentCode.Text);
                    MessageBox.Show(String.Format("Phòng ban {0} đã được thêm.", txbDepartmentCode.Text));
                    dtgvLoadDepartment.DataSource = dtb.GetAllDepartment();
                }
                else
                {
                    MessageBox.Show(String.Format("Mã phòng ban {0} đã tồn tại. Vui lòng thử lại", txbDepartmentCode.Text));
                }
            }
            else
                return;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;

            txbDepartmentCode.Enabled = true;
            txbDepartmentName.Enabled = true;
            txbManagerDepartmentCode.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckAddDepartmentNull() == true)
            {
                dtb.EditDepartment(txbDepartmentCode.Text, txbDepartmentName.Text, txbManagerDepartmentCode.Text);
                MessageBox.Show(String.Format("Phòng ban {0} đã được sửa.", txbDepartmentCode.Text));
                dtgvLoadDepartment.DataSource = dtb.GetAllDepartment();
            }
            else
                return;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            ResetText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txbDepartmentCode.Enabled = false;
            txbDepartmentName.Enabled = true;
            txbManagerDepartmentCode.Enabled = true;
            MessageBox.Show(String.Format("Dữ liệu phòng ban {0} đã được khởi tạo. Bây giờ bạn có thể điều chỉnh.", txbDepartmentCode.Text));
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }
        #endregion

        private void dtgvLoadDepartment_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvLoadDepartment.SelectedRows[0];
            txbDepartmentCode.Text = dr.Cells["DepartmentCode"].Value.ToString();
            txbDepartmentName.Text = dr.Cells["NameDepartment"].Value.ToString();
            txbManagerDepartmentCode.Text = dr.Cells["ManagerCode"].Value.ToString();

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;

            txbDepartmentCode.Enabled = false;
            txbDepartmentName.Enabled = false;
            txbManagerDepartmentCode.Enabled = false;
        }
    }
}
