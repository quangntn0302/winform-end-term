using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace CoffeeManager
{
    public partial class ucFoodCategory : UserControl
    {
        BindingSource foodcategoryList = new BindingSource();
        public FoodCategory fc;
        public ucFoodCategory()
        {
            InitializeComponent();
        }
        void LoadFoodCategory()
        {
            foodcategoryList.DataSource = FoodCategoryDAO.Instance.GetListFoodCategoy();
        }

        void AddFoodCategoryBinding()
        {
            txbIDFoodCategory.DataBindings.Add(new Binding("Text", dtgvFoodCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbName.DataBindings.Add(new Binding("Text", dtgvFoodCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        private void ucFoodCategory_Load(object sender, EventArgs e)
        {
            dtgvFoodCategory.DataSource = foodcategoryList;
            LoadFoodCategory();
            AddFoodCategoryBinding();
        }

        void AddFoodCategory(string userName)
        {
            if (FoodCategoryDAO.Instance.InsertFoodCategory(userName))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            LoadFoodCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;

            AddFoodCategory(name);
        }

        void DeleteFood(int id)
        {
            if (FoodCategoryDAO.Instance.DeleteFoodCategory(id) == true)
            {
                MessageBox.Show("xóa thất bại");
            }
            else
            {
                MessageBox.Show("xóa thành công");
            }
            LoadFoodCategory();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            
            int id = Convert.ToInt32(txbIDFoodCategory.Text);

            if (FoodCategoryDAO.Instance.UpdateFoodCategory(name, id))
            {
                MessageBox.Show("Sửa món thành công");
                LoadFoodCategory();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbIDFoodCategory.Text;
            int id1 = Convert.ToInt32(id);
            DeleteFood(id1);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        

    }
}
