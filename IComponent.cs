using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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