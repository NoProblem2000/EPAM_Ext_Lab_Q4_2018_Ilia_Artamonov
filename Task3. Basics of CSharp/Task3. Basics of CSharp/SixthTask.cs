using System;
using System.Collections.Generic;

namespace Task3.Basics_of_CSharp
{
    class SixthTask
    {
        public static SixthTask Instance => LazyInstance.Value;

        private static readonly Lazy<SixthTask> LazyInstance =
            new Lazy<SixthTask>(()=> new SixthTask());

        List<string> ChoosenTypesSelection = new List<string>();
        
        public enum TypesSelection
        {
            bold = 1,
            italic = 2,
            underline = 3
        }

        private int Input;

        private void SelectType(TypesSelection type)
        {
            if (ChoosenTypesSelection.Contains(type.ToString()))
            {
                ChoosenTypesSelection.Remove(type.ToString());
            }
            else
            {
                ChoosenTypesSelection.Add(type.ToString());
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

                var type = (TypesSelection) Input;
                SelectType(type);


            }
        }
    }
}