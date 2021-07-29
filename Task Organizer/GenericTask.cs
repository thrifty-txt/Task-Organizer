using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Organizer {
    public class GenericTask {
        public string Name { get; set; }
        public string Description { get; set; } = "";
        public string TaskType { get; } = "Generic";
        public int Priority { get; set; } = 0;
        public DateTime DateCreated { get; set; }
        public GenericTask(string name, string description, int priority, DateTime dateCreated) {
            Name = name;
            Description = description;
            Priority = priority;
            DateCreated = dateCreated;
        }
        public override String ToString() {
            string output = Name;
            if (!string.IsNullOrEmpty(Description)) {
                output += $": {Description}";
            }
            return output.Trim();
        }
        public String[] Serialize() {
            return new string[] { TaskType, Name, Description, Priority.ToString(), DateCreated.ToString() };
        }
    }
}
