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
        bool _isEnable = false;
        public List<Components> _components = new List<Components>();

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

        public void GetComponet(int comp)
        {
            throw new System.NotImplementedException();
        }
    }
}