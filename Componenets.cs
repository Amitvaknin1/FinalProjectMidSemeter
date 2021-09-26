using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalProjectMidSemeter
{
    public abstract class Components : IComponent
    {

        GameObject _gameObject;
        Transform _transform;
        string _name;
        public GameObject GameObjectP { get => _gameObject; set => _gameObject = value; }
        public Transform TransformP { get => _transform; set => _transform = value; }
        public string Name { get => _name; set => _name = value; }


        public void Start() { }
        public void OnEnable() { }
        public void OnDisable() { }
        public void Update() { }

        public virtual void Unsubscribe() { }
        public override string ToString()
        {
            return $"{Name}" + Environment.NewLine;
        }
        
    }
}