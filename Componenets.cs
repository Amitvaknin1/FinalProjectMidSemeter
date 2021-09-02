using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProjectMidSemeter
{
    public class Components :IComponent
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