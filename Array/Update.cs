using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Update
    {

        public Update()
        {

        }

        ~Update()
        {

        }

        public void updateMethod(int[] array, int index, int newElement)
        {
            array[index] = newElement;
        }
    }
}
