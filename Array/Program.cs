using System;



namespace Array
{
    class Program
    {
        public static int[] createArray()
        {
            Console.Write("Enter size of an array: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Random rn = new Random();
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = rn.Next(1, 21);
            }
            return array;
        }

        // Use only for case 1!!!
        public static void traverse()
        {
            Traverse print = new Traverse();
            print.printArray(createArray(),0);
        }
        //

        public static void updateMethodS()
        {
            //Array creation
            int[] newArray = createArray();
            //Array print
            Traverse print = new Traverse();
            print.printArray(newArray,0);
            //Update
            Console.Write("Enter index of an element you want to change: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new element: ");
            int newElement = Convert.ToInt32(Console.ReadLine());
            Update newInsertion = new Update();
            newInsertion.updateMethod(newArray, index, newElement);
            //Array print after insertion
            print.printArray(newArray, 1);
        }

        public static void staticInsertionMethod()
        {
            int[] array = createArray();
            Traverse print = new Traverse();
            print.printArray(array,0);
            Console.Write("At which index you want to insert new element: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new element to insert: ");
            int newElement = Convert.ToInt32(Console.ReadLine());
            StaticInsertion insert = new StaticInsertion();
            int[] newArray = insert.staticInsertion(array,index,newElement);
            print.printArray(newArray, 4);
        }

        public static void searchMethod()
        {
            int[] array = createArray();
            Traverse print = new Traverse();
            print.printArray(array, 0);
            Console.Write("Enter value for searching: ");
            int element = Convert.ToInt32(Console.ReadLine());
            Search find = new Search();
            find.search(array, element);
        }

        public static void deleteMethod()
        {
            int[] array = createArray();
            Traverse print = new Traverse();
            print.printArray(array,0);
            Console.Write("Enter index of element you want to delete: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Deletion delete = new Deletion();
            int[] newArray = delete.deleteElement(array, index);
            print.printArray(newArray, 5);
        }

        public static void minimumValue()
        {
            int[] array = createArray();
            Traverse print = new Traverse();
            print.printArray(array, 0);
            MinimumValue newMin = new MinimumValue();
            int min = newMin.getMinimumValue(array);
            Console.WriteLine("Minimal value is: " + min);
        }

        public static void maximumValue()
        {
            int[] array = createArray();
            Traverse print = new Traverse();
            print.printArray(array, 0);
            MaximumValue newMax = new MaximumValue();
            newMax.getMaximumValue(array);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays - Basic Operations" + Environment.NewLine);
            
            Console.WriteLine("1 - Traverse (print all the array elements one by one)");
            Console.WriteLine("2 - Update (updates an element at the given index)");
            Console.WriteLine("3 - Insertion (adds an element at the given index) -> static array");
            Console.WriteLine("4 - Search (searches for specified element)");
            Console.WriteLine("5 - Deletion (deletes element form array) -> static array");
            Console.WriteLine("6 - Minimum value (finds element with the lowest value)");
            Console.WriteLine("7 - Maximum value (finds element with the highest value)");
            Console.WriteLine("8 - Sum of array (returns sum of array)");

            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    traverse();
                    break;

                case 2:
                    updateMethodS();
                    break;

                case 3:
                    staticInsertionMethod();
                    break;

                case 4:
                    searchMethod();
                    break;

                case 5:
                    deleteMethod();
                    break;

                case 6:
                    minimumValue();
                    break;

                case 7:
                    maximumValue();
                    break;

                case 8:
                    //sum();
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
