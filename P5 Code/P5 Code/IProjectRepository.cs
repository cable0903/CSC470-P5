using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Code
{
    public interface IProjectRepository
    {
        string Add(Project project, int outID);
        string Remove(int projectId);
        string Modify(int projectId, Project project);
        List<Project> GetAll();
        bool isDuplicateName(string projectName);
    }
}
