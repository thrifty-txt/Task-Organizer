using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Organizer {
    class GenericTask {
        public string Name { get; set; }
        public string Description { get; set; }
        public GenericTask Parent { get; set; }
        public List<GenericTask> Children { get; set; }
    }
}
