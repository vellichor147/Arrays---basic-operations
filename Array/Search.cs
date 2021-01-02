using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Search
    {
        public int indexSuccessful;

        public Search()
        {

        }

        ~Search()
        {

        }

        public void search(int[] array, int element)
        {
            bool found = false;
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] == element)
                {
                    Console.WriteLine("[" + element + "]" + " found at index of " + "'" + i + "'");
                    found = true;
                    indexSuccessful = i;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("There is no " + "[" + element + "]" + " in array.");
            }
        }
    }
}
