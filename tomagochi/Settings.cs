using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomagochi
{
    enum Actions
    {
        Eat,
        Sleep,
        Clear,
        Happy
    }
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

        public static MyQ q;
        public static int QSpeed;

        public static MyStack stack;


        public Settings()
        {
            eat = new Scale(100);
            sleep = new Scale(100);
            clear = new Scale(100);
            happy = new Scale(100);
            hp = new Scale(100);
            sub = 10;
            add = 15;

            is_gameover = false;
            speed = 3;
            default_sub = 50;

            q = new MyQ(6);
            QSpeed = 16;

            stack = new MyStack(6);
            
        }
    }
}
