using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;


namespace FinalProjectMidSemeter
{
    public class Transform : Components
    {

        public Transform(GameObject gameObject)
        {
            GameObjectP = gameObject;
            TransformP = this;
            Name = gameObject.Name;

            Position = new Vector2(0, 0);
            Scale = new Vector2(1, 1);

            Console.WriteLine($"New Transform{this}");
        }

        public Transform(GameObject gameObject, Vector2 position, Vector2 scale)
        {
            GameObjectP = gameObject;
            TransformP = this;
            Name = gameObject.Name;

            Position = position;
            Scale = scale;

            Console.WriteLine(Environment.NewLine + $"New Transform{this}" + Environment.NewLine);
        }



        public enum MoveDirection
        {
            Up,
            Down,
            Right,
            Left,
            UpperRight,
            LowerRight,
            UpperLeft,
            LowerLeft
        }




        Vector2 _position, _scale;
        Vector2 _xAxis = new Vector2(1, 0);
        Vector2 _yAxis = new Vector2(0, 1);

        public Vector2 Position { get => _position; set => _position = value; }
        public Vector2 Scale { get => _scale; set => _scale = value; }
        public Vector2 XAxis => _xAxis;
        public Vector2 YAxis => _yAxis;
    }
}

