using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class MaximumValue
    {

        public MaximumValue()
        {

        }

        ~MaximumValue()
        {

        }

        public void getMaximumValue(int[] array)
        {
            int max = Int32.MinValue;
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] >= max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Element with the highest value is: " + max);
        }
    }
}
