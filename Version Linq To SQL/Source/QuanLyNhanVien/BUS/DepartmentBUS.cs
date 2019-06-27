using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DepartmentBUS
    {
        QLNVDataContext DTS = new QLNVDataContext();
        public IEnumerable<Department> GetAllDepartment()
        {
            IEnumerable<Department> department = (from dt in DTS.Departments
                                             select dt);
            return department;
        }
        public bool CheckDepartmentExits(string departmentcode)
        {
            int department = (from ac in DTS.Departments
                           where ac.DepartmentCode == departmentcode
                           select ac).Count();
            if (department == 1)
                return false;
            else
                return true;
        }
        public void AddDepartment(string departmentcode, string departmentname, string managercode)
        {
            Department department = new Department();
            department.DepartmentCode = departmentcode;
            department.NameDepartment = departmentname;
            department.ManagerCode = managercode;
            DTS.Departments.InsertOnSubmit(department);
            DTS.SubmitChanges();
        }
        public void EditDepartment(string departmentcode, string departmentname, string managercode)
        {
            Department department = (from ac in DTS.Departments
                                     select ac).Single(a => a.DepartmentCode == departmentcode);
            department.DepartmentCode = departmentcode;
            department.NameDepartment = departmentname;
            department.ManagerCode = managercode;
            DTS.SubmitChanges();
        }
        public void DeleteDepartment(string departmentcode)
        {
            Department department = (from ac in DTS.Departments
                                     select ac).Single(a => a.DepartmentCode == departmentcode);
            DTS.Departments.DeleteOnSubmit(department);
            DTS.SubmitChanges();
        }
    }
}
