using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProjectMidSemeter
{
    public interface IComponent
    {
        void Start();
        void Update(float delatatime);
        void OnDisable();
        void OnEnable();
    }
}