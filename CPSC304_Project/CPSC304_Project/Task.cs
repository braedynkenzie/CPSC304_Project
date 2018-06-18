using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC304_Project
{
    public class Task
    {
        private int id;
        private string taskName;
        private string taskDescription;
        private int listId;
        private int projectId;
        
        private List<int> assignedUsers = new List<int> ();

        public Task( int id, string name, string description, int listId, int projectId )
        {
            this.id = id;
            taskName = name;
            taskDescription = description;
            this.listId = listId;
            this.projectId = projectId;
        }

        public int ListId
        {
            get => listId;
            set => listId = value;
        }
        public int ProjectId
        {
            get => projectId;
            set => projectId = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
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
