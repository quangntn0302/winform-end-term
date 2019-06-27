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
    public partial class ucEmployee : UserControl
    {
        public ucEmployee()
        {
            InitializeComponent();
        }

        AccountBUS accountbus = new AccountBUS();

        #region Method
        bool CheckAddAccountNull()
        {
            if (txbUser.Text == "" || txbPass.Text == "" || txbFirstName.Text == "" || txbLastName.Text == "" || ckbFemale.Checked == false && ckbMale.Checked == false || txbSalary.Text == "" || txbAddress.Text == "" || txbPhone.Text == "" || txbMail.Text == "" || txbRoom.Text == "" || txbManager.Text == "")
            {
                MessageBox.Show("Thông tin bạn nhập vẫn chưa đủ. Vui lòng kiểm tra lại");
                return false;
            }
            else
                return true;       
        }

        void ResetText()
        {
            txbUser.ResetText();
            txbPass.ResetText();
            txbFirstName.ResetText();
            txbLastName.ResetText();
            txbSalary.ResetText();
            txbAddress.ResetText();
            txbPhone.ResetText();
            txbRoom.ResetText();
            txbMail.ResetText();
            txbManager.ResetText();
            ckbMale.Checked = false;
            ckbFemale.Checked = false;
            txbUser.Focus();
        }
        #endregion
        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (ckbMale.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";
            if (CheckAddAccountNull() == true)
            {
                accountbus.EditAccount(txbUser.Text, txbPass.Text, txbFirstName.Text, txbLastName.Text, sex, txbSalary.Text, txbAddress.Text, txbPhone.Text, txbMail.Text, txbRoom.Text, txbManager.Text);
                MessageBox.Show(String.Format("Tài khoản {0} đã được sửa.", txbUser.Text));
                dtgvLoadEmployee.DataSource = accountbus.GetAllAccount();
            }
            else
                return;
            btnDeleteEmployee.Enabled = false;
            btnSave.Enabled = false;
            btnAddEmployee.Enabled = true;
            btnEditEmployee.Enabled = false;
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
        private void ucEmployee_Load(object sender, EventArgs e)
        {
            dtgvLoadEmployee.DataSource = accountbus.GetAllAccount();
            dtgvLoadEmployee.Columns["PassWord"].Visible = false;
            btnDeleteEmployee.Enabled = false;
            btnEditEmployee.Enabled = false;
            btnSave.Enabled = false;
            btnAddEmployee.Enabled = true;
            txbUser.Enabled = true;
            txbPass.Enabled = true;
            txbFirstName.Enabled = true;
            txbLastName.Enabled = true;
            txbSalary.Enabled = true;
            txbPhone.Enabled = true;
            txbManager.Enabled = true;
            txbMail.Enabled = true;
            txbAddress.Enabled = true;
            txbRoom.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (ckbMale.Checked == true)
                sex = "Nam";
            else
                sex = "Nữ";
            if (CheckAddAccountNull() == true)
            {
                if (accountbus.CheckAccountExits(txbUser.Text) == true)
                {
                    accountbus.AddAccount(txbUser.Text, txbPass.Text, txbFirstName.Text, txbLastName.Text, sex, txbSalary.Text, txbAddress.Text, txbPhone.Text, txbMail.Text, txbRoom.Text, txbManager.Text);
                    MessageBox.Show(String.Format("Tài khoản {0} đã được thêm.",txbUser.Text));
                    dtgvLoadEmployee.DataSource = accountbus.GetAllAccount();
                }
                else
                {
                    MessageBox.Show(String.Format("Mã nhân viên {0} đã tồn tại. Vui lòng thử lại", txbUser.Text));
                }
            }
            else
                return;

            btnDeleteEmployee.Enabled = false;
            btnEditEmployee.Enabled = false;
            btnSave.Enabled = false;

            txbUser.Enabled = true;
            txbPass.Enabled = true;
            txbFirstName.Enabled = true;
            txbLastName.Enabled = true;
            txbSalary.Enabled = true;
            txbPhone.Enabled = true;
            txbManager.Enabled = true;
            txbMail.Enabled = true;
            txbAddress.Enabled = true;
            txbRoom.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
        }
        private void dtgvLoadEmployee_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvLoadEmployee.SelectedRows[0];
            txbUser.Text = dr.Cells["EmployeesCode"].Value.ToString();
            txbPass.Text = dr.Cells["PassWord"].Value.ToString();
            txbFirstName.Text = dr.Cells["FirstName"].Value.ToString();
            txbLastName.Text = dr.Cells["LastName"].Value.ToString();
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
            txbSalary.Text = dr.Cells["Salary"].Value.ToString();
            txbAddress.Text = dr.Cells["Address"].Value.ToString();
            txbPhone.Text = dr.Cells["Phone"].Value.ToString();
            txbMail.Text = dr.Cells["Email"].Value.ToString();
            txbRoom.Text = dr.Cells["Phong"].Value.ToString();
            txbManager.Text = dr.Cells["ManagerCode"].Value.ToString();

            btnDeleteEmployee.Enabled = true;
            btnEditEmployee.Enabled = true;
            btnAddEmployee.Enabled = false;

            txbUser.Enabled = false;
            txbPass.Enabled = false;
            txbFirstName.Enabled = false;
            txbLastName.Enabled = false;
            txbSalary.Enabled = false;
            txbPhone.Enabled = false;
            txbManager.Enabled = false;
            txbMail.Enabled = false;
            txbAddress.Enabled = false;
            txbRoom.Enabled = false;
            ckbMale.Enabled = false;
            ckbFemale.Enabled = false;
        }
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            txbUser.Enabled = false;
            txbPass.Enabled = true;
            txbFirstName.Enabled = true;
            txbLastName.Enabled = true;
            txbSalary.Enabled = true;
            txbPhone.Enabled = true;
            txbManager.Enabled = true;
            txbMail.Enabled = true;
            txbAddress.Enabled = true;
            txbRoom.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
            MessageBox.Show(String.Format("Dữ liệu tài khoản {0} đã được khởi tạo. Bây giờ bạn có thể điều chỉnh.", txbUser.Text));
            btnSave.Enabled = true;
            btnAddEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = false;
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            accountbus.DeleteAccount(txbUser.Text);
            MessageBox.Show(String.Format("Tài khoản {0} đã được xóa.", txbUser.Text));
            dtgvLoadEmployee.DataSource = accountbus.GetAllAccount();
            ResetText();
            btnDeleteEmployee.Enabled = false;
            btnSave.Enabled = false;
            btnAddEmployee.Enabled = true;
            btnEditEmployee.Enabled = false;

            txbUser.Enabled = true;
            txbPass.Enabled = true;
            txbFirstName.Enabled = true;
            txbLastName.Enabled = true;
            txbSalary.Enabled = true;
            txbPhone.Enabled = true;
            txbManager.Enabled = true;
            txbMail.Enabled = true;
            txbAddress.Enabled = true;
            txbRoom.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database đã được reload");
            dtgvLoadEmployee.DataSource = accountbus.GetAllAccount();
            ResetText();
            btnDeleteEmployee.Enabled = false;
            btnEditEmployee.Enabled = false;
            btnSave.Enabled = false;
            btnAddEmployee.Enabled = true;

            txbUser.Enabled = true;
            txbPass.Enabled = true;
            txbFirstName.Enabled = true;
            txbLastName.Enabled = true;
            txbSalary.Enabled = true;
            txbPhone.Enabled = true;
            txbManager.Enabled = true;
            txbMail.Enabled = true;
            txbAddress.Enabled = true;
            txbRoom.Enabled = true;
            ckbMale.Enabled = true;
            ckbFemale.Enabled = true;
        }
        #endregion


    }
}
