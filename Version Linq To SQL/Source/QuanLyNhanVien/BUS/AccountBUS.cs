using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class AccountBUS
    {
        QLNVDataContext NhanViens = new QLNVDataContext();

        public bool CheckAccount(string username , string password)
        {
            int account = (from ac in NhanViens.Employees
                           where ac.EmployeesCode == username && ac.PassWord == password
                           select ac).Count();
            if (account == 1)
                return true;
            else
                return false;
        }

        public static string usernamea;
        public static string Usernamea()
        {
            return usernamea;
        }

        public IEnumerable<Employee> GetAllAccount()
        {
            IEnumerable<Employee> account = (from ac in NhanViens.Employees
                                             select ac);
            return account;
        }

        public bool CheckAccountExits(string username)
        {
            int account = (from ac in NhanViens.Employees
                           where ac.EmployeesCode == username
                           select ac).Count();
            if (account == 1)
                return false;
            else
                return true;
        }

        public string Getabc(string username)
        {
            usernamea = username;
            string acc = (from ac in NhanViens.Employees
                          where ac.EmployeesCode == username
                          select ac.FirstName).FirstOrDefault().ToString();
            return acc;
        }

        public void AddAccount(string username , string password , string firstname , string lastname , string sex , string salary , string address , string phone , string email , string phong , string managercode)
        {
            Employee account = new Employee();
            account.EmployeesCode = username;
            account.PassWord = password;
            account.FirstName = firstname;
            account.LastName = lastname;
            account.Sex = sex;
            account.Salary = (float)Convert.ToDouble(salary.ToString());
            account.Address = address;
            account.Phone = phone;
            account.Email = email;
            account.Phong = phong;
            account.ManagerCode = managercode;
            NhanViens.Employees.InsertOnSubmit(account);
            NhanViens.SubmitChanges();
        }

        public void EditAccount(string username, string password, string firstname, string lastname, string sex, string salary, string address, string phone, string email, string phong, string managercode)
        {
            Employee account = (from ac in NhanViens.Employees
                                select ac).Single(a => a.EmployeesCode == username);
            account.PassWord = password;
            account.FirstName = firstname;
            account.LastName = lastname;
            account.Sex = sex;
            account.Salary = (float)Convert.ToDouble(salary.ToString());
            account.Address = address;
            account.Phone = phone;
            account.Email = email;
            account.Phong = phong;
            account.ManagerCode = managercode;
            NhanViens.SubmitChanges();
        }
        public void DeleteAccount(string username)
        {
            Employee account = (from ac in NhanViens.Employees
                                select ac).Single(a => a.EmployeesCode == username);
            NhanViens.Employees.DeleteOnSubmit(account);
            NhanViens.SubmitChanges();
        }

        public IEnumerable<Employee> GetFindAccount(string username)
        {
            IEnumerable<Employee> account = (from ac in NhanViens.Employees
                                             where ac.EmployeesCode == username
                                             select ac);
            return account;
        }

    }
}
