using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC304_Project
{
    class Project
    {
        private string projectName;
        private List<ProjectList> projectLists = new List<ProjectList> ();
        private List<int> userIDs = new List<int> ();

        public Project(string name, List<ProjectList> lists, List<int> users)
        {
            projectName = name;
            projectLists = lists;
            userIDs = users;
        }
    }
}
