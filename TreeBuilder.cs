using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalProjectMidSemeter
{
    class TreeBuilder
    {
        public Tree tree;
        public TreeBuilder(int allSize, int maxChildrenSize)
        {
            tree = new Tree(new TreeNode(new GameObject() { Name = "Root" }));
            int counter = 0;
            Random rand = new Random();
            Stack<TreeNode> _cache = new Stack<TreeNode>();
            _cache.Push(tree.Root);

            while (_cache.Count != 0 && counter < allSize)
            {
                var node = _cache.Pop();
                var max = rand.Next(0, maxChildrenSize);
                Thread.Sleep(10);
                for (int i = 0; i < max; i++)
                {
                    var child = new TreeNode(new GameObject() { Name = $"{node?.Value?.Name}/{counter}" }, parent: node);
                    counter++;
                    _cache.Push(child);
                }
            }
        }
    }
}

