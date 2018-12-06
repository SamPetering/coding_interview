using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_DFS_Binary
{
    class Node
    {
        public Node left, right;
        public string data;
        public Node(string data, Node left, Node right)
        {
            this.left = left;
            this.right = right;
            this.data = data;
        }
        public Node(string data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
