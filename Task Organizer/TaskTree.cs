using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Organizer {
    class TaskTree {
        public GenericTask Root { get; }
        public TaskTree() {
            //Create the root task of the Tree with no parent.
            Root = new GenericTask("root", null);
        }
    }
}
