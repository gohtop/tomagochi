﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomagochi
{
    class MyStack
    {
        private int capacity;
        private int count_busy;
        private KeyValuePair<Actions, Image>?[] elements;

        public MyStack(int _capacity)
        {
            capacity = _capacity;
            count_busy = 0;
            elements = new KeyValuePair<Actions, Image>?[capacity];
        }

        public KeyValuePair<Actions, Image>?[] Elements
        {
            get
            {
                return elements;
            }
        }
        public bool Push(KeyValuePair<Actions, Image> pair)
        {
            if(count_busy == capacity)
                return false;

            elements[count_busy] = pair;
            count_busy++;
            return true;
        }
        public KeyValuePair<Actions, Image>? Pop()
        {
            if (count_busy == 0)
                return null;
            var element = elements[count_busy - 1];
            elements[count_busy - 1] = null;
            count_busy--;
            return element;
        }
    }
}
