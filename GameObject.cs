using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalProjectMidSemeter
{
    public class GameObject
    {
        string _name;
        bool _isEnable;
        public List<Components> _components = new List<Components>();
        private bool _isEnabled;
        private TreeNode _treeNode;


        public string Name { get => _name; set => _name = value; }
        public bool IsEnabled { get => _isEnabled; set => _isEnabled = value; }

        public GameObject Parent
        {
            get
            {
                if (_treeNode.Parent == null)
                {
                    return null;
                }
                else
                {
                    return _treeNode.Parent.Value;
                }
            }
        }
        public List<GameObject> Children
        {
            get
            {
                List<GameObject> list = new List<GameObject>();
                foreach (var child in treeNode.Children)
                {
                    list.Add(child.Value);
                }
                return list;
            }

        }
        internal TreeNode treeNode { get => _treeNode; set => _treeNode = value; }
        public GameObject(string name)
        {
            Name = name;
            _isEnable = true;
            Transform transform = new Transform(this);


        }

        public GameObject()
        {
        }

        public void Disabale()
        {
            throw new System.NotImplementedException();
        }

        public void Enable()
        {
            throw new System.NotImplementedException();
        }

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        public void OnDisable()
        {
            throw new System.NotImplementedException();
        }

        public void AddComponet(Components components)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveComponet(Components componentss)
        {
            throw new System.NotImplementedException();
        }

       
        public T GetComponent<T>() where T : Components
        {
            Console.WriteLine("Trying to get component");
            if (typeof(T) == null)
            {
                Console.WriteLine("Did not find component");
                Console.WriteLine();
            }

            //SearchComponent
            foreach (Components item in _components)
            {
                if (item.GetType() == typeof(T))
                {
                    Console.WriteLine($"Found component {item}");
                    return item as T;
                }
            }

            return null;
        }
    }
}