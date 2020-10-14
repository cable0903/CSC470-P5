using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_Code
{
    public class FakeProjectRepository //: IProjectRepository
    {
        public static Dictionary<string, Project> Projects;

        public FakeProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new Dictionary<string, Project>();
                Projects.Add("Accounting Project", new Project
                {
                    Name = "Accounting Project",
                    ID = 1,
                });
                Projects.Add("Quality Assurance Project", new Project
                {
                    Name = "Quality Assurance Project",
                    ID = 2,
                });
                Projects.Add("Reports Project", new Project
                {
                    Name = "Reports Project",
                    ID = 3,
                });
            }
        }
        public List<Project> GetAll()
        {
            List<Project> Name = new List<Project>();
            foreach (KeyValuePair<string, Project> project in Projects)
            {
                Name.Add(project.Value);
            }
            return Name;
        }
        public static string Removeproj(int key)
        {
            var result = Projects.FirstOrDefault(x => x.Value.ID == key);
            Projects.Remove(result.Value.Name);
            return "done";
            
        }
        public static string Add(Project project, int outID)
        {
            FakeProjectRepository.Projects.Add(project.Name, new Project
            {
                Name = project.Name,
                ID = outID,
            });
            return "done";
        }
        public string Modify(int projectId, Project project)
        {
            string do_stuff = "do_stuff";
            return do_stuff;
        }
        public static bool isDuplicateName(string projectName)
        {
            List<Project> Name = new List<Project>();
            int flag = 0;
            foreach (KeyValuePair<string, Project> project in Projects)
            {
                if(project.Key == projectName)
                {
                    flag = 1;
                }
            }

            if(flag == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
