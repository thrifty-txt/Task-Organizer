using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Organizer {
    public class GenericTask {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TaskType { get; } = "Generic";
        public GenericTask(string name, string description = "") {
            Name = name;
            Description = description;
        }
        public override String ToString() {
            string output = Name;
            if (!string.IsNullOrEmpty(Description)) {
                output += $": {Description}";
            }
            return output.Trim();
        }
        public String[] Serialize() {
            return new string[] { TaskType, Name, Description };
        }
    }
}
