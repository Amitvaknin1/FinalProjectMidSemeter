using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;        

namespace FinalProjectMidSemeter
{
    
    public class Rigidbody : Components
    {
        
        bool _useGravity = false;
        float _gravityScale;
        public bool UseGravity { get => _useGravity; set => _useGravity = value; }

        public void ApplyGravity()
        {
            Vector2 position = TransformP.Position;
            position = new Vector2(position.X, position.Y - Physics.Gravity);

            //need to add another condition for checking collision from the bottom
            if (UseGravity)
                TransformP.Position = position;
        }

        public void ApplyConstantForce(float flotat, Vector2 _vector)
        {
           
        }
    }
}