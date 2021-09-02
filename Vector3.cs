using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace FinalProjectMidSemeter
{

    public struct Vector3
    {
        //testc TEST 
        float x;
        float y;
        float z;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }

        public Vector3(float x1, float y2, float z3)
        {
            x = x1;
            y = y2;
            z = z3;

        }
        public Vector3 Add(Vector3 first, Vector3 second)
        {
            Vector3 _newvector = new Vector3(first.X + second.X, first.Y + second.Y, first.Z + second.Z);
            return _newvector;
        }
        public Vector3 Minus(Vector3 first, Vector3 second)
        {
            Vector3 _newvector = new Vector3(first.X - second.X, first.Y - second.Y, first.Z - second.Z);
            return _newvector;
        }


    }
}