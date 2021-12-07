using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace FinalProjectMidSemeter
{
    public class Game
    {
        private Scene _activeScene;
        public Scene ActiveScene { get { return _activeScene; } set { _activeScene = value; } }

        private float _deltaTime = 1;
        public float DeltaTime { get { return _deltaTime; } set { _deltaTime = value; } }

        public static bool IsGameRunning;

        private static System.Timers.Timer _gameTimer = new System.Timers.Timer(1000);


        public Game(Scene scene = null)
        {
            if (scene == null)
            {
                scene = new Scene("Default Scene");
                ActiveScene = scene;
            }
            else
                ActiveScene = scene;
        }

        public bool Run()
        {
            if (ActiveScene != null)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" --- Active Scene: '" + ActiveScene.Name + "'. Press Enter to RUN ---");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();

                if (!IsGameRunning)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("START():");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    IsGameRunning = true;

                    ActiveScene.Start(); // Actual start method
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("UPDATE():");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                ActivateGameTimer(); // Update() is inside this method 
                return true;
            }
            else
            {
                Console.WriteLine("Error. Could not find Active Scene.");
                return false;
            }
        }

        public bool LoadActiveScene(Scene scene)
        {
            if (scene != null)
            {
                UnloadActiveScene();
                ActiveScene = scene;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ActiveScene.Name + " is loaded.");
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.WriteLine("Error. Could not load the requested scene.");
                return false;
            }
        }

        void UnloadActiveScene()
        {
            if (ActiveScene != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ActiveScene.Name + " was unloaded.");
                Console.ForegroundColor = ConsoleColor.White;
                ActiveScene = null;
            }
            else
                Console.WriteLine("There isn't an Active Scene");
        }

        void ActivateGameTimer() // Youtube tutorial "C# How to use timers". Implemented for Update()
        {
            _gameTimer.Elapsed += GameTimer_Elapsed;
            _gameTimer.Enabled = true;
            _gameTimer.AutoReset = true;
            _gameTimer.Start();
        }

        void GameTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DeltaTime++;
            ActiveScene.Update();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Seconds Passed: " + DeltaTime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}