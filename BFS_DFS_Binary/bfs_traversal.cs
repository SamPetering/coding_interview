using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_DFS_Binary
{
    partial class Program
    {
        public static void bfs_traversal(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while(q.Count > 0)
            {
                node = q.Dequeue();
                Console.WriteLine(node.data + " ");

                if (node.left != null)
                    q.Enqueue(node.left);

                if (node.right != null)
                    q.Enqueue(node.right);
            }
        }
    }
}
