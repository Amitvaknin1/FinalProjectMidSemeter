using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FinalProjectMidSemeter
{
    public class Scene
    {
        private List<GameObject> GameObjects;
        bool isActive;

        public Scene()
        {
            GameObjects = new List<GameObject>();
        }
        public void AddGameObject(GameObject go)
        {
            GameObjects.Add(go);
            go.Enable();
        }

        public void RemoveGameObject(GameObject go)
        {
            GameObjects.Remove(go);
            go.Disable();
        }
        public void RemoveGameObjectByName(string ObjectName)
        {
            foreach (var go in GameObjects)
            {
                if (go.Name == ObjectName)
                {
                    GameObjects.Remove(go);
                    go.Disable();
                }
            }
        }
        public bool IsSceneActive()
        {
            if (isActive)
            {
                return true;
            }
            return false;
        }
        public void ActivateScene()
        {
            isActive = true;
        }
        public void DisableScene()
        {
            isActive = false;
        }
        public void LoadScene(Scene scene)
        {
              scene.ActivateScene();
        }
        public void UnloadScene(Scene scene)
        {
            scene.DisableScene();
        }
    }
}