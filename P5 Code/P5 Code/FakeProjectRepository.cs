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
            Project varname = new Project();
            var result = Projects.FirstOrDefault(x => x.Value.ID == key);
            Projects.Remove(result.Value.Name);
            return "done";
            
        }
        public string Add(Project project, int outID)
        {
            string do_stuff = "do_stuff";
            return do_stuff;
        }
        public string Modify(int projectId, Project project)
        {
            string do_stuff = "do_stuff";
            return do_stuff;
        }
        public bool isDuplicateName(string projectName)
        {
            bool do_stuff = true;
            return do_stuff;
        }
    }
}
