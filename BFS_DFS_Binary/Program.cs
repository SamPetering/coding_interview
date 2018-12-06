using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_DFS_Binary
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Node tree = sample_tree();
            Console.WriteLine("BFS:");
            bfs_traversal(tree);

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("DFS:");
            dfs_traversal(tree);
            Console.ReadKey();
        }

        static Node sample_tree()
        {
            Node root =
                new Node("A", new Node("B", new Node("C"), new Node("D")),
                    new Node("E", new Node("F"), new Node("G", new Node("H"), null)));
            return root;
        }
    }
}
