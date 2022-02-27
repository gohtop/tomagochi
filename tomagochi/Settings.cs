using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomagochi
{
    class Settings
    {
        public static Scale eat; 
        public static Scale sleep;
        public static Scale clear;
        public static Scale happy;
        public static Scale hp;
        public static int sub;
        public static int add;

        public static bool is_gameover;
        public static int speed;
        public static int default_sub;

        public Settings()
        {
            eat = new Scale(100);
            sleep = new Scale(100);
            clear = new Scale(100);
            happy = new Scale(100);
            hp = new Scale(100);
            sub = 15;
            add = 10;

            is_gameover = false;
            speed = 2;
            default_sub = 50;
        }
    }
}
