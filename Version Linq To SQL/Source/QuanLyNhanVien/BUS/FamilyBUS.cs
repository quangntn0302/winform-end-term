using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class FamilyBUS
    {
        QLNVDataContext FAB = new QLNVDataContext();
        public IEnumerable<Family> GetAllFamily()
        {
            IEnumerable<Family> fal = (from fa in FAB.Families
                                      select fa);
            return fal;
        }
        public bool CheckFamilyExits(string username)
        {
            int family = (from fa in FAB.Families
                          where fa.EmployeesCode == username
                          select fa).Count();
            if (family == 1)
                return false;
            else
                return true;
        }
        public void AddFamily(string username, string name, string sex, string relationship)
        {
            Family family = new Family();
            family.EmployeesCode = username;
            family.NameFamily = name;
            family.Sex = sex;
            family.Relationship = relationship;
            FAB.Families.InsertOnSubmit(family);
            FAB.SubmitChanges();
        }
        public void EditFamily(string username, string name, string sex, string relationship)
        {
            Family family = (from fa in FAB.Families
                         select fa).Single(a => a.EmployeesCode == username);
            family.EmployeesCode = username;
            family.NameFamily = name;
            family.Sex = sex;
            family.Relationship = relationship;
            FAB.SubmitChanges();
        }
        public void DeleteFamily(string username)
        {
            Family family = (from fa in FAB.Families
                             select fa).Single(a => a.EmployeesCode == username);
            FAB.Families.DeleteOnSubmit(family);
            FAB.SubmitChanges();
        }
    }
}
