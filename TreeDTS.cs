using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMidSemeter
{
    
        class Tree : IEnumerable<TreeNode>
        {
            public TreeNode Root { get;  set; }

            public Tree(TreeNode root)
            {
                Root = root;
            }

            public IEnumerator<TreeNode> GetEnumerator()
            {
                return new TreeEnumerator(this);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }

        class TreeEnumerator : IEnumerator<TreeNode>
        {
            TreeNode _current = null;
            Tree _tree;
            Stack<int> _cache;
            bool _reachedEnd = false;

            public TreeNode Current => _current;

            object IEnumerator.Current => this._current;

            public TreeEnumerator(Tree collection)
            {
                _tree = collection;
                _cache = new Stack<int>(120);
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (_reachedEnd)
                    return false;

                // we're at the beginning
                if (_cache.Count == 0)
                {
                    _current = _tree.Root;
                    _cache.Push(0);
                    return true;
                }

                var context = _cache.Pop();

                while (context >= _current.Children.Count)
                {
                    _current = _current.Parent;

                    if (_current == null)
                    {
                        _reachedEnd = true;
                        return false;
                    }

                    context = _cache.Pop();
                }

                _current = _current.Children[context++];
                _cache.Push(context);
                _cache.Push(0);
                return true;
            }

            public void Reset()
            {
                _reachedEnd = false;
                _current = default(TreeNode);
            }
        }

        class TreeNode
        {
            public GameObject Value { get; }

            private List<TreeNode> _children;
            public ReadOnlyCollection<TreeNode> Children { get; }

            public TreeNode Parent { get; set; }

            public TreeNode(GameObject go, TreeNode parent = null)
            {
                Value = go;
                go.treeNode = this;
                _children = new List<TreeNode>(16);
                Children = new ReadOnlyCollection<TreeNode>(_children);

                if (parent != null)
                {
                    parent.AddChild(this);
                }
            }

            public void AddChild(TreeNode child)
            {
                child.Parent = this;
                _children.Add(child);
            }

            public void RemoveNode()
            {
                if (Parent == null)
                {
                    return;
                }
                else
                {
                    Parent.RemoveChild(this);
                }

            }

            private void RemoveChild(TreeNode treeNode)
            {
                _children.Remove(treeNode);
            }

        }
}
