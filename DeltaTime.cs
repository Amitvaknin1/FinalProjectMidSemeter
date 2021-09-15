using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProjectMidSemeter
{
    public static class DeltaTime
    {
        static float _deltatime = DeltaTimeAsFloat();
        static bool _freezeGame = false;
        static public float Deltatime => _deltatime;
        static public bool FreezeGame { get => _freezeGame; set => _freezeGame = value; }
        public static void DeltaTimeAsDateTime()
        {
            DateTime time1 = DateTime.Now;
            DateTime time2 = DateTime.Now;

            while (true)
            {
                time2 = DateTime.Now;
                float deltaTime = (time2.Ticks - time1.Ticks) / 10000000f;
                Console.WriteLine(deltaTime);
                Console.WriteLine(time2.Ticks - time1.Ticks);
                time1 = time2;
            }
        }

        public static float DeltaTimeAsFloat()
        {
            DateTime time1 = DateTime.Now;
            DateTime time2 = DateTime.Now;

            while (true)
            {
                time2 = DateTime.Now;
                float deltaTime = (time2.Ticks - time1.Ticks) / 10000000f;
                return deltaTime;
            }
        }
        public static void RestartTimer(float timer)
        {
            timer = 0;
            timer = timer + (1 * Deltatime);
        }

        public static void ContinueTimer(float timer)
        {
            timer = timer + (1 * Deltatime);
        }

        public static void StopTimer(float timer)
        {
            if (timer > 0)
            {
                float tempTimer = timer;
                timer = tempTimer;
            }
        }

        public static void ResetTimer(float timer)
        {
            if (timer > 0)
            {
                timer = 0;
            }
        }
    }
}