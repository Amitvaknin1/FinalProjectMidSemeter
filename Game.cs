using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalProjectMidSemeter
{
    public class Game
    {
         
        public int _deltatime
        {
            get => default;
            set
            {
            }
        }

        public bool Run()
        {
            throw new System.NotImplementedException();
        }

        public bool LoadScene(Scene scene1)
        {
            if (scene1.IsSceneActive())
            {
                return false;
            }
            else scene1.LoadScene( scene1);
            return true;
        }

        public void NewGame(Scene scene1) { }
        

        public void ActiveScene(Scene scene1)
        {
            if (scene1.IsSceneActive() == true)
            {
                Console.WriteLine("there is an active Scene");
            }
        }
    }
}