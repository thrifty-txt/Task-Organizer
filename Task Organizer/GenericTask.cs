﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Organizer {
    public class GenericTask {
        public string Name { get; set; }
        public string Description { get; set; }
        // Must be updated whenever task is moved around the tree!
        public GenericTask(string name, string description = "") {
            Name = name;
            Description = description;
        }
        /*private int DetermineDepth() {
            int d = 0;
            for (GenericTask node = Parent; node != null; node = node.Parent)
                d++;
            return d;
        }*/
        public override String ToString() {
            string output = Name;
            if (!string.IsNullOrEmpty(Description)) {
                output += $": {Description}";
            }
            return output.Trim();
        }
        private string SanitizeString(string str) {
            var splitStr = str.Split(',');
            for(int i = 0; i < splitStr.Length - 1; i++) {
                splitStr[i] += "\\,";
            }
            return string.Join(null, splitStr);
        }
        public String Serialize() {
            return $"{SanitizeString(Name)},{SanitizeString(Description)}";
        }
    }
}
