using System;
using System.Collections.Generic;

namespace Task3.Basics_of_CSharp
{
    class SixthTask
    {
        List<string> ChoosenTypesSelection = new List<string>();
        // ki: для сохранения типа удобно использовать enum. тогда и от харкода можно будет избавиться.
        private readonly string[] TypeSelection = { "bold", "italic", "underline" };
        private int Input;

        private void SelectType(int type)
        {
            if (ChoosenTypesSelection.Contains(TypeSelection[type]))
            {
                ChoosenTypesSelection.Remove(TypeSelection[type]);
            }
            else
            {
                ChoosenTypesSelection.Add(TypeSelection[type]);
            }
        }

        public void LabelSelection()
        {
            Console.WriteLine("This task allow you choose the selection of text");
            while (true)
            {
                if (ChoosenTypesSelection.Count == 0)
                {
                    Console.WriteLine("Parameters text: None");
                }
                else
                {
                    Console.Write("Parameters text:");
                    foreach (var element in ChoosenTypesSelection)
                    {
                        Console.Write(element + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Input the type of selection");
                Console.WriteLine("\t1: bold\n" +
                                  "\t2: italic\n" +
                                  "\t3: underline\n" +
                                  "\t0 to exit");
                if (!int.TryParse(Console.ReadLine(), out Input) || Input > 3 || Input < 0)
                {
                    Console.WriteLine("Bad input. Enter the number showen on display\n");
                    continue;
                }
                if (Input == 0)
                {
                    break;
                }
                // ki: Хардкод. 
                SelectType(Input - 1);


            }
        }
    }
}