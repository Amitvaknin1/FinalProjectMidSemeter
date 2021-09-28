using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;

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
        public List<Components> Components { get => _components; set => _components = value; }
        public GameObject(string name)
        {
            Name = name;
            IsEnabled = true;

            Transform transform = new Transform(this);
            AddComponent(transform);
            transform.GameObjectP = this;
            transform.TransformP = transform;

            Console.WriteLine($"New Game Object has been created {ToString()}");
        }
        public GameObject(string name, Vector2 position)
        {
            Name = name;
            IsEnabled = true;

            Transform transform = new Transform(this, position, new Vector2(1, 1));
            AddComponent(transform);
            transform.GameObjectP = this;
            transform.TransformP = transform;

            Console.WriteLine($"New Game Object has been created {ToString()}");
        }



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


        public void Disabale()
        {
            Console.WriteLine($"Disabling GameObject{ToString()}");
            IsEnabled = false;


            Console.WriteLine($"GameObject Disabled {ToString()}");
        }

        public void Enable()
        {
            Console.WriteLine($"Enabling GameObject {ToString()}");

            if (_isEnable == false)
            {
                Console.WriteLine($"Not enabling {ToString()}");
                return;
            }

            IsEnabled = true;



            Console.WriteLine($"GameObject Enabled {ToString()}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Destroying {this}");

            int index = _components.Count;

            for (int i = index - 1; i >= 0; i--)
            {
                _components[i].ResetList();
                _components.Remove(_components[i]);
            }

            ResetList();

            Console.WriteLine($"{Name} is Destroyed");
            Console.WriteLine();
        }
        public virtual void ResetList() { }


        public void AddComponent(Components component)
        {
            Console.WriteLine("Trying to add Componnent");

            if (component == null)
            {
                Console.WriteLine("Error in AddComponent");
                Console.WriteLine();
                return;
            }

            if (CheckForTransform(component))
            {
                Console.WriteLine("Cant Add for more than one Transform to an object");
                Console.WriteLine();
                return;
            }

            Components.Add(component);

            //component.GetSetGameObject = this;
            Console.WriteLine("Component added");
            Console.WriteLine();
        }

        public void RemoveComponet(Components components)
        {
            bool isTransform = components is Transform;

            //if the spechific component exists inside of the componnenst it will be removed
            //cant really be null but still good to check
            if (_components == null)
            {
                Console.WriteLine("ERROR Game Object Componnents Are NULL");
                Console.WriteLine();
                return;
            }

            if (components != null || isTransform != true)
            {
                Console.WriteLine("Attempting to remove Component");
                for (int i = 0; i < _components.Count; i++)
                {
                    if (_components[i] == components)
                    {
                        Console.WriteLine($"Removing Component {_components[i]}");
                        Console.WriteLine();
                        _components.Remove(components);
                        return;
                    }
                }

                Console.WriteLine("Component not found");
                Console.WriteLine();
            }

            else if (isTransform == true)
                Console.WriteLine("Transform can not be removed");

            else
                Console.WriteLine("Component is null");

            Console.WriteLine();
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
        bool CheckForTransform(Components component)
        {
            if (component is Transform)
            {
                foreach (var componnent in _components)
                {
                    if (componnent is Transform)
                        return true;
                }
            }
            return false;
        }
    }
}