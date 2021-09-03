using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProjectMidSemeter
{
    
    public class Rigidbody : Components
    {
        
        bool _useGravity = false;
        float _gravityScale;

        public Rigidbody(GameObject go) : base(go)
        {

        }

        public void ApplyConstantForce(float flotat, Vector2 _vector)
        {
           
        }
    }
}