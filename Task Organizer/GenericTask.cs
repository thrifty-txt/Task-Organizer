using System;

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
        // all of these functions can and will be overriden in sub-classes
        // used to fill TreeNode Text value
        public override string ToString() => $"{Name}".Trim();
        public string GetToolTip() => Priority > 0 ? $"{Description} | Priority: {Priority}".Trim() : Description;
        public string[] Serialize() => new string[] { TaskType, Name, Description, Priority.ToString(), DateCreated.ToString() };
    }
}
