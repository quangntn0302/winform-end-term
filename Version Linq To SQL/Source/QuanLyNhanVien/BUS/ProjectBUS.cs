using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class ProjectBUS
    {
        QLNVDataContext pr = new QLNVDataContext();
        public IEnumerable<Project> GetAllProject()
        {
            IEnumerable<Project> pro = (from prs in pr.Projects
                                       select prs);
            return pro;
        }
        public bool CheckProjectExits(string projectcode)
        {
            int project = (from prs in pr.Projects
                           where prs.ProjectCode == projectcode
                           select prs).Count();
            if (project == 1)
                return false;
            else
                return true;
        }
        public void AddProject(string projectcode, string name, string place, string departmentcode)
        {
            Project project = new Project();
            project.ProjectCode = projectcode;
            project.NameProject = name;
            project.PlaceProject = place;
            project.DepartmentCode = departmentcode;
            pr.Projects.InsertOnSubmit(project);
            pr.SubmitChanges();
        }
        public void EditProject(string projectcode, string name, string place, string departmentcode)
        {
            Project project = (from pro in pr.Projects
                               select pro).Single(a => a.ProjectCode == projectcode);
            project.ProjectCode = projectcode;
            project.NameProject = name;
            project.PlaceProject = place;
            project.DepartmentCode = departmentcode;
            pr.SubmitChanges();
        }
        public void DeleteProject(string projectcode)
        {
            Project project = (from pro in pr.Projects
                               select pro).Single(a => a.ProjectCode == projectcode);
            pr.Projects.DeleteOnSubmit(project);
            pr.SubmitChanges();
        }
    }
}
