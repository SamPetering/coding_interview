using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_DFS_Binary
{
    partial class Program
    {
        static void dfs_traversal(Node node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.data);
            dfs_traversal(node.left);
            dfs_traversal(node.right);

        }
    }
}
