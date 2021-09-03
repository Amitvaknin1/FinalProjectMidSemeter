using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace FinalProjectMidSemeter
{
    internal struct Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2(float givenX, float givenY)
        {
            X = givenX;
            Y = givenY;
        }

        public Vector2(Vector2 givenVector2Gever)
        {
            X = givenVector2Gever.X;
            Y = givenVector2Gever.Y;
        }

        public override string ToString()
        {
            return "X"+X +"Y" +Y;
        }

        public static Vector2 Zero => new Vector2(0, 0);

        public static Vector2 operator -(Vector2 first, Vector2 second)
        {
            return new Vector2(first.X - second.X, first.Y - second.Y);
        }

        public static Vector2 operator +(Vector2 first, Vector2 second)
        {
            return new Vector2(first.X + second.X, first.Y + second.Y);
        }

        public static Vector2 operator *(Vector2 vector, float scalar)
        {
            return new Vector2(vector.X * scalar, vector.Y * scalar);
        }

        public static Vector2 operator /(Vector2 vector, float scalar)
        {
            return new Vector2(vector.X / scalar, vector.Y / scalar);
        }

        public static bool operator ==(Vector2 first, Vector2 second)
        {
            return (first.X == second.X && first.Y == second.Y);
        }

        public static bool operator !=(Vector2 first, Vector2 second)
        {
            return (first.X != second.X || first.Y != second.Y);
        }

        public float DotProduct(Vector2 other)
        {
            return X * other.X + Y * other.Y;
        }

        public float Magnitude()
        {

            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public Vector2 Normalized()
        {
            return new Vector2(X / this.Magnitude(), Y / this.Magnitude());
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