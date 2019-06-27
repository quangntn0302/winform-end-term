using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace CoffeeManager
{
    public partial class ucFood : UserControl
    {
        public ucFood()
        {
            InitializeComponent();
        }

        #region Parameter
        BindingSource foodList = new BindingSource();
        #endregion
        #region Method
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
            dtgvFood.DataSource = foodList;
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = FoodCategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }
        #endregion
        #region Events
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }
        #endregion

        private void ucFood_Load(object sender, EventArgs e)
        {
            btnDeleteFood.Enabled = false;
            btnEditFood.Enabled = false;
            btnSaveFood.Enabled = false;
            btnAddFood.Enabled = true;
            btnShowFood.Enabled = true;
            txbSearchFoodName.Enabled = true;
            txbFoodName.Enabled = true;
            cbFoodCategory.Enabled = true;
            nmFoodPrice.Enabled = true;
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            btnDeleteFood.Enabled = false;
            btnEditFood.Enabled = false;
            btnSaveFood.Enabled = false;
            btnAddFood.Enabled = true;
            btnShowFood.Enabled = true;
            txbSearchFoodName.Enabled = true;
            txbFoodName.Enabled = true;
            cbFoodCategory.Enabled = true;
            nmFoodPrice.Enabled = true;
            LoadListFood();
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    // lấy ra 1 cell bất kỳ trong datagridview
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    //if (Int32.TryParse(txbCategoryID.Text, out id))
                    //{
                    FoodCategory category = FoodCategoryDAO.Instance.GetCategoryByID(id);

                    cbFoodCategory.SelectedItem = category;
                    //}
                    int index = -1;
                    int i = 0;
                    foreach (FoodCategory item in cbFoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch
            {
                return;
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as FoodCategory).ID;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            btnDeleteFood.Enabled = true;
            btnEditFood.Enabled = false;
            btnSaveFood.Enabled = true;
            btnAddFood.Enabled = false;
            btnShowFood.Enabled = true;
            txbSearchFoodName.Enabled = true;
            txbFoodName.Enabled = true;
            cbFoodCategory.Enabled = true;
            nmFoodPrice.Enabled = true;

        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
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

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private void txbSearchFoodName_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dtgvFood_Click(object sender, EventArgs e)
        {
            btnDeleteFood.Enabled = false;
            btnEditFood.Enabled = true;
            btnSaveFood.Enabled = false;
            btnAddFood.Enabled = false;
            btnShowFood.Enabled = true;
            txbSearchFoodName.Enabled = false;
            txbFoodName.Enabled = false;
            cbFoodCategory.Enabled = false;
            nmFoodPrice.Enabled = false;
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            btnDeleteFood.Enabled = true;
            btnEditFood.Enabled = false;
            btnSaveFood.Enabled = true;
            btnAddFood.Enabled = false;
            btnShowFood.Enabled = true;
            txbSearchFoodName.Enabled = true;
            txbFoodName.Enabled = true;
            cbFoodCategory.Enabled = true;
            nmFoodPrice.Enabled = true;

            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as FoodCategory).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }
        private void txbSearchFoodName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbSearchFoodName.Text.Equals(null))
            {
                foodList.DataSource = FoodDAO.Instance.GetListFood();
                dtgvFood.DataSource = foodList;
            }
            else
            {
                foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
            }
        }
    }
}
