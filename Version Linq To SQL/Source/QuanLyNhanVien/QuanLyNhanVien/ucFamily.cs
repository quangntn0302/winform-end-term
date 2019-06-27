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
    public partial class ucFamily : UserControl
    {
        FamilyBUS fa = new FamilyBUS();
        public ucFamily()
        {
            InitializeComponent();
        }

        #region Method
        bool CheckAddFamilyNull()
        {
            if (txbEmployeeCode.Text == "" || txbName.Text == "" || txbRelationship.Text == "" || ckbFemale.Checked == false && ckbMale.Checked == false)
            {
                MessageBox.Show("Thông tin bạn nhập vẫn chưa đủ. Vui lòng kiểm tra lại");
                return false;
            }
            else
                return true;
        }
        void ResetText()
        {
            txbEmployeeCode.ResetText();
            txbName.ResetText();
            txbRelationship.ResetText();
            ckbMale.Checked = false;
            ckbFemale.Checked = false;
            txbEmployeeCode.Focus();
        }
        #endregion
        #region Events
        private void ucFamily_Load(object sender, EventArgs e)
        {
            dtgvLoadFamily.DataSource = fa.GetAllFamily();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            txbEmployeeCode.Enabled = true;
            txbName.Enabled = true;
            txbRelationship.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (ckbMale.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";
            if (CheckAddFamilyNull() == true)
            {
                if (fa.CheckFamilyExits(txbEmployeeCode.Text) == true)
                {
                    fa.EditFamily(txbEmployeeCode.Text, txbName.Text, sex, txbRelationship.Text);
                    MessageBox.Show(String.Format("Thân nhân của nhân viên {0} đã được sửa.", txbEmployeeCode.Text));
                    dtgvLoadFamily.DataSource = fa.GetAllFamily();
                }
                else
                {
                    MessageBox.Show(String.Format("Mã nhân viên {0} đã tồn tại. Vui lòng thử lại", txbEmployeeCode.Text));
                }
            }
            else
                return;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;

            txbEmployeeCode.Enabled = true;
            txbName.Enabled = true;
            txbRelationship.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (ckbMale.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";

            if (CheckAddFamilyNull() == true)
            {
                fa.EditFamily(txbEmployeeCode.Text, txbName.Text, sex, txbRelationship.Text);
                MessageBox.Show(String.Format("Tài khoản {0} đã được sửa.", txbEmployeeCode.Text));
                dtgvLoadFamily.DataSource = fa.GetAllFamily();
            }
            else
                return;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ckbMale_OnChange(object sender, EventArgs e)
        {
            if (ckbMale.Checked == true)
            {
                ckbFemale.Checked = false;
            }
        }

        private void ckbFemale_OnChange(object sender, EventArgs e)
        {
            if (ckbFemale.Checked == true)
            {
                ckbMale.Checked = false;
            }
        }
        private void dtgvLoadFamily_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvLoadFamily.SelectedRows[0];
            txbEmployeeCode.Text = dr.Cells["EmployeesCode"].Value.ToString();
            txbName.Text = dr.Cells["NameFamily"].Value.ToString();
            txbRelationship.Text = dr.Cells["Relationship"].Value.ToString();
            if (dr.Cells["Sex"].Value.ToString() == "Nam")
            {
                ckbMale.Checked = true;
                ckbFemale.Checked = false;
            }
            else
            {
                ckbFemale.Checked = true;
                ckbMale.Checked = false;
            }

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;

            ckbMale.Enabled = false;
            ckbFemale.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txbEmployeeCode.Enabled = false;
            txbName.Enabled = true;
            txbRelationship.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
            MessageBox.Show(String.Format("Dữ liệu tài khoản {0} đã được khởi tạo. Bây giờ bạn có thể điều chỉnh.", txbEmployeeCode.Text));
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            fa.DeleteFamily(txbEmployeeCode.Text);
            MessageBox.Show(String.Format("Tài khoản {0} đã được xóa.", txbEmployeeCode.Text));
            dtgvLoadFamily.DataSource = fa.GetAllFamily();
            ResetText();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;

            txbEmployeeCode.Enabled = true;
            txbName.Enabled = true;
            txbRelationship.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database đã được reload");
            dtgvLoadFamily.DataSource = fa.GetAllFamily();
            ResetText();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;

            txbEmployeeCode.Enabled = true;
            txbName.Enabled = true;
            txbRelationship.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
        }
        #endregion


    }
}
