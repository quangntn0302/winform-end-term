using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;
        public static FoodCategoryDAO Instance
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
            private set { FoodCategoryDAO.instance = value; }
        }
        private FoodCategoryDAO() { }

        public List<FoodCategory> GetListCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();

            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodCategory category = new FoodCategory(item);
                list.Add(category);
            }

            return list;
        }
        public DataTable GetListFoodCategoy()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from dbo.FoodCategory");
        }
        public FoodCategory GetCategoryByID(int id)
        {
            FoodCategory category = null;

            string query = "select * from FoodCategory where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new FoodCategory(item);
                return category;
            }

            return category;
        }
        public bool InsertFoodCategory(string name)
        {
            string query = string.Format("exec USP_InserTableFood @name");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool UpdateFoodCategory(string name, int id)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}' WHERE id = {1}", name,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteFoodCategory(int id)
        {
            string query = "exec USP_DeleteFoodCategory @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { id });
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
