using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading;

namespace FinalProjectMidSemeter
{
     public struct Vector2apes
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2apes(float givenX, float givenY)
        {
            X = givenX;
            Y = givenY;
        }

        public Vector2apes(Vector2apes givenVector2Gever)
        {
            X = givenVector2Gever.X;
            Y = givenVector2Gever.Y;
        }

        public override string ToString()
        {
            return "X"+X +"Y" +Y;
        }

        public static Vector2apes Zero => new Vector2apes(0, 0);

        public static Vector2apes operator -(Vector2apes first, Vector2apes second)
        {
            return new Vector2apes(first.X - second.X, first.Y - second.Y);
        }

        public static Vector2apes operator +(Vector2apes first, Vector2apes second)
        {
            return new Vector2apes(first.X + second.X, first.Y + second.Y);
        }

        public static Vector2apes operator *(Vector2apes vector, float scalar)
        {
            return new Vector2apes(vector.X * scalar, vector.Y * scalar);
        }

        public static Vector2apes operator /(Vector2apes vector, float scalar)
        {
            return new Vector2apes(vector.X / scalar, vector.Y / scalar);
        }

        public static bool operator ==(Vector2apes first, Vector2apes second)
        {
            return (first.X == second.X && first.Y == second.Y);
        }

        public static bool operator !=(Vector2apes first, Vector2apes second)
        {
            return (first.X != second.X || first.Y != second.Y);
        }

        public float DotProduct(Vector2apes other)
        {
            return X * other.X + Y * other.Y;
        }

        public float Magnitude()
        {

            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public Vector2apes Normalized()
        {
            return new Vector2apes(X / this.Magnitude(), Y / this.Magnitude());
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}