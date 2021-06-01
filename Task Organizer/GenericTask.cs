using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Organizer {
    public class GenericTask {
        public string Name { get; set; }
        public string Description { get; set; }
        public GenericTask Parent { get; set; }
        public List<GenericTask> Children { get; set; }
        public GenericTask(string name, GenericTask parent, string description = "") {
            Name = name;
            Description = description;
            Parent = parent;
            Children = new List<GenericTask>();
        }
        public void NewChild(string name, string description = "") {
            Children.Add(new GenericTask(name, this, description));
        }
        public override String ToString() {
            string output = $"| {Name}";
            if (!string.IsNullOrEmpty(Description)) {
                output += $": {Description}";
            }
            foreach(var child in Children) {
                output += $"{Environment.NewLine}|{child.ToString()}";
            }
            return output.Trim();
        }
    }
}
