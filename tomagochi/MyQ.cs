﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomagochi
{
    class MyQ
    {
        private int capacity;
        private int count_busy;
        private KeyValuePair<Actions, Image>?[] elements;
        private KeyValuePair<Actions, Image>?[] Elements 
        { 
            get 
            {
                return elements;
            } 
        }
        public bool EnQ(KeyValuePair<Actions, Image> pair)
        {
            if(count_busy == capacity)
            {
                return false;
            }

            elements[count_busy] = pair;
            count_busy++;
            return true;
        }
        public KeyValuePair<Actions , Image>? DeQ()
        {

        }
    }
}
