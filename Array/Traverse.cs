using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Traverse
    {
        // 0 - Generated array:
        // 1 - Static array after update:
        // 2 - Generated dynamic array:
        // 3 - Dynamic array after update:
        // 4 - Static array after insertion:
        // 5 - Array after deletion: 


        public string[] stringCase = { "Generated array: ", "Array after update: ", "Generated dynamic array: ", 
                                       "Dynamic array after update: ", "Array after insertion: ", "Array after deletion: " };
        public Traverse()
        {

        }

        ~ Traverse()
        {

        }

        public void printArray(int[] array,int x)
        {

            Console.Write(stringCase[x]);
            for(int i = 0; i<array.Length; i++)
            {
                Console.Write(" ["+array[i]+"] ");
            }
            Console.WriteLine();
        }
    }
}
