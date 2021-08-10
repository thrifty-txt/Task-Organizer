using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Organizer
{
    public class AlphaTreeNodeASort : IComparer
    {
        public int Compare(object x, object y)
        {
            var NodeX = x as TreeNode;
            var NodeY = y as TreeNode;
            return string.Compare(NodeX.Text, NodeY.Text);
        }
    }
    public class AlphaTreeNodeDSort : IComparer
    {
        public int Compare(object x, object y)
        {
            var NodeX = x as TreeNode;
            var NodeY = y as TreeNode;
            return string.Compare(NodeY.Text, NodeX.Text);
        }
    }
    public class DateTreeNodeASort : IComparer
    {
        public int Compare(object x, object y)
        {
            var NodeX = x as TreeNode;
            var NodeY = y as TreeNode;
            var TaskX = NodeX.Tag as GenericTask;
            var TaskY = NodeY.Tag as GenericTask;
            if(TaskX.DateCreated < TaskY.DateCreated)
            {
                return -1;
            }
            if(TaskY.DateCreated < TaskX.DateCreated)
            {
                return 1;
            }
            return 0;
        }
    }
    public class DateTreeNodeDSort : IComparer
    {
        public int Compare(object x, object y)
        {
            var NodeX = x as TreeNode;
            var NodeY = y as TreeNode;
            var TaskX = NodeX.Tag as GenericTask;
            var TaskY = NodeY.Tag as GenericTask;
            if(TaskX.DateCreated < TaskY.DateCreated)
            {
                return 1;
            }
            if(TaskY.DateCreated < TaskX.DateCreated)
            {
                return -1;
            }
            return 0;
        }
    }
    public class PriorityTreeNodeASort : IComparer
    {
        public int Compare(object x, object y)
        {
            var NodeX = x as TreeNode;
            var NodeY = y as TreeNode;
            var TaskX = NodeX.Tag as GenericTask;
            var TaskY = NodeY.Tag as GenericTask;
            if(TaskX.Priority < TaskY.Priority)
            {
                return -1;
            }
            if(TaskY.Priority < TaskX.Priority)
            {
                return 1;
            }
            return 0;
        }
    }
    public class PriorityTreeNodeDSort : IComparer
    {
        public int Compare(object x, object y)
        {
            var NodeX = x as TreeNode;
            var NodeY = y as TreeNode;
            var TaskX = NodeX.Tag as GenericTask;
            var TaskY = NodeY.Tag as GenericTask;
            if(TaskX.Priority < TaskY.Priority)
            {
                return 1;
            }
            if(TaskY.Priority < TaskX.Priority)
            {
                return -1;
            }
            return 0;
        }
    }
}
