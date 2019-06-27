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
    public partial class ucProject : UserControl
    {
        ProjectBUS projectbus = new ProjectBUS();
        public ucProject()
        {
            InitializeComponent();
        }

        #region Method
        bool CheckAddProjectNull()
        {
            if (txbProjectCode.Text == "" || txbDepartment.Text == "" || txbNameProject.Text == "" || txbPlaceProject.Text == "")
            {
                MessageBox.Show("Thông tin bạn nhập vẫn chưa đủ. Vui lòng kiểm tra lại");
                return false;
            }
            else
                return true;
        }
        void ResetText()
        {
            txbDepartment.ResetText();
            txbNameProject.ResetText();
            txbPlaceProject.ResetText();
            txbProjectCode.ResetText();
            txbProjectCode.Focus();
        }
        #endregion
        #region Events
        private void ucProject_Load(object sender, EventArgs e)
        {
            dtgvProjectLoad.DataSource = projectbus.GetAllProject();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            txbDepartment.Enabled = true;
            txbNameProject.Enabled = true;
            txbPlaceProject.Enabled = true;
            txbProjectCode.Enabled = true;
        }
        private void dtgvProjectLoad_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvProjectLoad.SelectedRows[0];
            txbProjectCode.Text = dr.Cells["ProjectCode"].Value.ToString();
            txbNameProject.Text = dr.Cells["NameProject"].Value.ToString();
            txbPlaceProject.Text = dr.Cells["PlaceProject"].Value.ToString();
            txbDepartment.Text = dr.Cells["DepartmentCode"].Value.ToString();

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;

            txbDepartment.Enabled = false;
            txbNameProject.Enabled = false;
            txbPlaceProject.Enabled = false;
            txbProjectCode.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckAddProjectNull() == true)
            {
                if (projectbus.CheckProjectExits(txbProjectCode.Text) == true)
                {
                    projectbus.AddProject(txbProjectCode.Text, txbNameProject.Text, txbPlaceProject.Text,txbDepartment.Text);
                    MessageBox.Show(String.Format("Dự án {0} đã được thêm.", txbProjectCode.Text));
                    dtgvProjectLoad.DataSource = projectbus.GetAllProject();
                }
                else
                {
                    MessageBox.Show(String.Format("Mã dự án {0} đã tồn tại. Vui lòng thử lại", txbProjectCode.Text));
                }
            }
            else
                return;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;

            txbDepartment.Enabled = true;
            txbNameProject.Enabled = true;
            txbPlaceProject.Enabled = true;
            txbProjectCode.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            projectbus.DeleteProject(txbProjectCode.Text);
            MessageBox.Show(String.Format("Dự án {0} đã được xóa.", txbProjectCode.Text));
            dtgvProjectLoad.DataSource = projectbus.GetAllProject();
            ResetText();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;

            txbDepartment.Enabled = true;
            txbNameProject.Enabled = true;
            txbPlaceProject.Enabled = true;
            txbProjectCode.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckAddProjectNull() == true)
            {
                projectbus.EditProject(txbProjectCode.Text, txbNameProject.Text, txbPlaceProject.Text, txbDepartment.Text);
                MessageBox.Show(String.Format("Dự án {0} đã được sửa.", txbProjectCode.Text));
                dtgvProjectLoad.DataSource = projectbus.GetAllProject();
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
            txbProjectCode.Enabled = false;
            txbDepartment.Enabled = true;
            txbNameProject.Enabled = true;
            txbPlaceProject.Enabled = true;
            MessageBox.Show(String.Format("Dữ liệu dự án {0} đã được khởi tạo. Bây giờ bạn có thể điều chỉnh.", txbProjectCode.Text));
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database đã được reload");
            dtgvProjectLoad.DataSource = projectbus.GetAllProject();
            ResetText();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;

            txbDepartment.Enabled = true;
            txbNameProject.Enabled = true;
            txbPlaceProject.Enabled = true;
            txbProjectCode.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
