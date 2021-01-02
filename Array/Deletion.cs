using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Deletion
    {

        public Deletion()
        {

        }

        ~Deletion()
        {

        }

        public int[] deleteElement(int[] array, int index)
        {
            int[] newArray = new int[array.Length-1];
            //Delete at the beggining
            if( index == 0)
            {
                for (int i=0; i<newArray.Length; i++)
                {
                    newArray[i] = array[i + 1];
                }
            }
            //Delete in the middle and at the end
            else if (index != 0 && index != array.Length)
            {
                for(int i = 0; i < newArray.Length; i++)
                {
                    if(i != index && i<index)
                    {
                        newArray[i] = array[i];
                    }
                    else if (i == index || i > index)
                    {
                        newArray[i] = array[i + 1];
                    }
                }
            }
            return newArray;
        }
    }
}
