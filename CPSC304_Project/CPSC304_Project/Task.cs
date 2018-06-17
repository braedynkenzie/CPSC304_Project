using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC304_Project
{
    class Task
    {
        private string taskName;
        private string taskDescription;
        private List<int> assignedUsers = new List<int> ();

        public Task(string name, string description)
        {
            taskName = name;
            taskDescription = description;
        }

        public string GetName()
        {
            return taskName;
        }

        internal object GetDescription()
        {
            return taskDescription;
        }
    }
}
