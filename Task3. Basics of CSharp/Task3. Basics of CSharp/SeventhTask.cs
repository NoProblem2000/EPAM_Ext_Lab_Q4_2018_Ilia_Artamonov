using System;

namespace Task3.Basics_of_CSharp
{
    public class SeventhTask
    {
        private static readonly  Lazy<SeventhTask> LazyInstance = 
            new Lazy<SeventhTask>(()=> new SeventhTask());

        public static SeventhTask Instance => LazyInstance.Value;

        private enum TypesSort
        {
            Asc,
            Desc
        }
        private int[] InitArray(int[] Array)
        {
            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(-100, 100);
            }

            return Array;
        }

        private void SortByDesc(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        private void SortByAsc(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void Sort()
        {
            Console.WriteLine("This task sort array with random elements");
            Console.WriteLine("Choose the type of sort\n" +
                              "1 - descending\n" +
                              "2 - ascending");
            int type = 0;
            while (!int.TryParse(Console.ReadLine(), out type))
            {
                Console.WriteLine("You entered not a number or not a integer");
            }

            Random random = new Random();
            int sizeOfArray = random.Next(2, 100);
            int[] array = new int[sizeOfArray];
            array = InitArray(array);
            Console.WriteLine("Origin array");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            
            var typeSort = (TypesSort) type;
            if (typeSort == TypesSort.Desc)
            {
                SortByDesc(ref array);
            }
            else
            {
                SortByAsc(ref array);
            }
            Console.WriteLine("Sorted array");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("Press enter\n\n");
            Console.ReadKey();
        }
    }
}