using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Code
{
    public class FakeProjectRepository : IProjectRepository
    {
        private static Dictionary<string, Project> Projects;

        public FakeProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new Dictionary<string, Project>();
                Projects.Add("DaveBish", new Project
                {
                    ID = 1,
                    Name = "Accounting Project",
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
        public string Remove(int projectID)
        {
            string do_stuff = "do_stuff";
            return do_stuff;
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
