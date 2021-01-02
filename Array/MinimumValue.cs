using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class MinimumValue
    {
        //Constructor
        public MinimumValue()
        {

        }

        //Deconstructor
        ~MinimumValue()
        {

        }
        public int getMinimumValue(int[] array)
        {
            int minimum = Int32.MaxValue;
            for(int i=0; i<array.Length; i++)
            {
                if(array[i]<minimum)
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }
    }
}
