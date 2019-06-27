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
    public partial class ucTableFood : UserControl
    {
        BindingSource tablefoodlist = new BindingSource();
        public ucTableFood()
        {
            InitializeComponent();
        }

        void LoadFoodCategory()
        {
            tablefoodlist.DataSource = TableDAO.Instance.GetListTable();
        }
        void AddFoodCategoryBinding()
        {
            txbIDTableFood.DataBindings.Add(new Binding("Text", dtgvLoadTableFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            txbNameTableFood.DataBindings.Add(new Binding("Text", dtgvLoadTableFood.DataSource, "name", true, DataSourceUpdateMode.Never));

        }

        private void ucTableFood_Load(object sender, EventArgs e)
        {
            dtgvLoadTableFood.DataSource = tablefoodlist;
            LoadFoodCategory();
            AddFoodCategoryBinding();
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            
        }
    }
}
