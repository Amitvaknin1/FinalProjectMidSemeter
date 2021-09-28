using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalProjectMidSemeter
{
    public class Game
    {
         public  Scene scene1 = new Scene();
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

        public bool LoadScene()
        {
            if (scene1.IsSceneActive())
            {
                return false;
            }
            else scene1.LoadScene(scene1);
            return true;
        }

        public void NewGame()
        {
            throw new System.NotImplementedException();
        }

        public void ActiveScene()
        {
            if (scene1.IsSceneActive() == true)
            {
                Console.WriteLine("there is an active Scene");
            }
        }
    }
}