using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalProjectMidSemeter
{
    public class Scene
    {
        private List<Tree> Hierarchy { get; set; }
        string name { get; set; }
        int lvlcounter = 0;
        public Scene (string name = "new Scene")
        {
            this.name = name;
            lvlcounter = 0;
        }
        public void AddGameObjectRoot()
        {
            Console.WriteLine("Give your game object a name ");
            string gameobjectname = Console.ReadLine();
            Hierarchy[lvlcounter].Root = (new TreeNode(new GameObject(gameobjectname), null));
            lvlcounter++;
        }

    }
}