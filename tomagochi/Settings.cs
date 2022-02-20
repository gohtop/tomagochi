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
        public static Scale xp;
        public static int sub;
        public static int add;

        public Settings()
        {
            eat = new Scale(100);
            sleep = new Scale(100);
            clear = new Scale(100);
            happy = new Scale(100);
            xp = new Scale(100);
            sub = 10;
            add = 5;
        }
    }
}
