using System;

namespace Task3.Basics_of_CSharp
{
    public class SeventhTask
    {
        private int[] InitArray(int[] Array)
        {
            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(-100, 100);
            }

            return Array;
        }

        public void Sort()
        {
            Console.WriteLine("This task sort array with random elements");
            Console.WriteLine("Choose the type of sort\n" +
                              "1 - descending\n" +
                              "2 - ascending");
            int typeSort = 0;
            while (!int.TryParse(Console.ReadLine(), out typeSort))
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
            // ki опять хардкод. можно вновь применить enum
            // сами сортировки я бы вынес в два отдельных метода.
            if (typeSort == 2)
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
            else
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