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
    public partial class ucCIty : UserControl
    {
        CityBUS city = new CityBUS();
        public ucCIty()
        {
            InitializeComponent();
        }

        #region Method
        bool CheckAddCityNull()
        {
            if (txbCityCode.Text == "" || txbCityName.Text == "")
            {
                MessageBox.Show("Thông tin bạn nhập vẫn chưa đủ. Vui lòng kiểm tra lại");
                return false;
            }
            else
                return true;
        }
        void ResetText()
        {
            txbCityCode.ResetText();
            txbCityName.ResetText();
            txbCityCode.Focus();
        }
        #endregion
        #region Events
        private void ucCIty_Load(object sender, EventArgs e)
        {
            dtgvLoadCity.DataSource = city.GetAllCity();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            txbCityCode.Enabled = true;
            txbCityName.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckAddCityNull() == true)
            {
                if (city.CheckCitytExits(txbCityCode.Text) == true)
                {
                    city.AddCity(txbCityCode.Text, txbCityName.Text);
                    MessageBox.Show(String.Format("Thành phố {0} đã được thêm.", txbCityCode.Text));
                    dtgvLoadCity.DataSource = city.GetAllCity();
                }
                else
                {
                    MessageBox.Show(String.Format("Mã thành phố {0} đã tồn tại. Vui lòng thử lại", txbCityCode.Text));
                }
            }
            else
                return;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;

            txbCityCode.Enabled = true;
            txbCityName.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            city.DeleteCity(txbCityCode.Text);
            MessageBox.Show(String.Format("Thành phố {0} đã được xóa.", txbCityCode.Text));
            dtgvLoadCity.DataSource = city.GetAllCity();
            ResetText();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;

            txbCityCode.Enabled = true;
            txbCityName.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckAddCityNull() == true)
            {
                city.EditCity(txbCityCode.Text, txbCityName.Text);
                MessageBox.Show(String.Format("Thành phố {0} đã được sửa.", txbCityCode.Text));
                dtgvLoadCity.DataSource = city.GetAllCity();
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
            txbCityCode.Enabled = false;
            txbCityName.Enabled = true;
            MessageBox.Show(String.Format("Dữ liệu thành phố {0} đã được khởi tạo. Bây giờ bạn có thể điều chỉnh.", txbCityCode.Text));
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database đã được reload");
            dtgvLoadCity.DataSource = city.GetAllCity();
            ResetText();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;

            txbCityCode.Enabled = true;
            txbCityName.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void dtgvLoadCity_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvLoadCity.SelectedRows[0];
            txbCityCode.Text = dr.Cells["CityCode"].Value.ToString();
            txbCityName.Text = dr.Cells["NameCity"].Value.ToString();

            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;

            txbCityCode.Enabled = false;
            txbCityName.Enabled = false;
        }
    }
}
