using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProjectMidSemeter
{
    public static class Physics
    {
        public static List<BoxCollider> BoxColliders = new List<BoxCollider>();
        public static float _gravity = 9.8f;

        public static float Gravity
        {
            get
            {
                return _gravity;
            }
            set
            {
                _gravity = value;
            }
        }


    }
}