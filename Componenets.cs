using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalProjectMidSemeter
{
    public abstract class Components :IComponent
    {
        
        private GameObject go;
        protected GameObject daddy;
        public Components(GameObject go)
        {
          
            daddy = go;
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void OnEnable()
        {
            throw new System.NotImplementedException();
        }

        public void OnDisable()
        {
            throw new System.NotImplementedException();
        }

        public void Update(float delatatime)
        {
            throw new NotImplementedException();
        }
    }
}