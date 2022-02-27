using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomagochi
{
    class Scale
    {
        public int current_value;
        public int max_value;

        public Scale()
        {

        }

        public Scale(int current_value)
        {
            this.current_value = current_value;
            max_value = 100;
        }

        public Scale(int current_value , int max_value)
        {
            this.current_value = current_value;
            this.max_value = max_value;
        }
        public Scale  add_value(int add_value)
        {
            current_value += add_value;
            if (current_value > max_value)
            {
                current_value = max_value;
            }
            return this;
        }
        public Scale sub_value(int sub_value)
        {
            current_value -= sub_value;
            if (current_value < 0)
            {
                current_value = 0;

            }
            return this;
        }
    }
}
