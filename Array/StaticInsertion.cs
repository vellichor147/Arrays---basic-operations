using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class StaticInsertion
    {

        public StaticInsertion()
        {

        }

        ~StaticInsertion()
        {

        }

        public int[] staticInsertion(int[] array, int index, int newElement)
        {
            int[] newArray = new int[(array.Length + 1)];

            //Insert at the beginning (index 0)
            if (index == 0)
            {
                for(int i=0; i<newArray.Length; i++)
                {
                    if(i == index)
                    {
                        newArray[i] = newElement;
                    }
                    else
                    {
                        newArray[i] = array[i-1];
                    }
                }
            }
            //Insert in the middle
            else if (index != 0 && index != newArray.Length)
            {
                for(int i=0; i<newArray.Length; i++)
                {
                    if(i != index && i<index)
                    {
                        newArray[i] = array[i];
                    }
                    else if (i == index)
                    {
                        newArray[i] = newElement;
                    }
                    else
                    {
                        newArray[i] = array[i - 1];
                    }
                }
            }
            //Insert at the end
            else
            {
                for(int i=0; i<=newArray.Length; i++)
                {
                    if(i != index)
                    {
                        newArray[i] = array[i];
                    }
                    else
                    {
                        newArray[i] = newElement;
                    }
                }
            }
            
            return newArray;
        }
    }
}
