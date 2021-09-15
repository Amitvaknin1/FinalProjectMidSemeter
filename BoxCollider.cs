using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;


namespace FinalProjectMidSemeter
{
    public class BoxCollider : Components
    {
        Vector2 _scale;
     
        float _centerhorizontal;
        float _centervertical;

        float _collisionTimer = 0;
        bool _isEnabled = true;
        bool _isColliding = false;
        public Vector2 Scale { get => _scale; set => _scale = value; }
        public float CX { get => _centerhorizontal; set => _centerhorizontal = value; }
        public float CY { get => _centervertical; set => _centervertical = value; }
        public float BoxLeft => TransformP.Position.X - CX;
        public float BoxRight => TransformP.Position.X + CX;
        public float BoxTop => TransformP.Position.Y - CY;
        public float BoxBottom => TransformP.Position.Y + CY;
        public float CollisionTimer { get => _collisionTimer; set => _collisionTimer = value; }
        public bool IsEnabled { get => _isEnabled; set => _isEnabled = value; }
        public bool IsColliding { get => _isColliding; set => _isColliding = value; }

        public BoxCollider(GameObject gameObject)
        {
            GameObjectP = gameObject;
            TransformP = gameObject.GetComponent<Transform>();
            Name = gameObject.Name;
            Physics.BoxColliders.Add(this);

        }
        public void CollidesWith(BoxCollider anotherCollider)
        {
            OnCollision?.Invoke(anotherCollider);
            IsColliding = true;
        }

        public void StartCollidingWith(BoxCollider anotherCollider)
        {
            OnCollisionStart?.Invoke(anotherCollider);
            IsColliding = true;
            DeltaTime.ContinueTimer(CollisionTimer);
        }

        public void FinishedCollidingWith(BoxCollider anotherCollider)
        {
            OnCollisionEnd?.Invoke(anotherCollider);
            IsColliding = true;
            DeltaTime.StopTimer(CollisionTimer);
        }

        public event Action<BoxCollider> OnCollision; 
        public event Action<BoxCollider> OnCollisionStart; 
        public event Action<BoxCollider> OnCollisionEnd;


    }
}