using System;
using System.Security.AccessControl;


namespace Task3.Basics_of_CSharp
{
    public class Program
    {
        private const string ListTasks = " - 1\n" +
                                         " - 2\n" +
                                         " - 3\n" +
                                         " - 4\n" +
                                         " - 5\n" +
                                         " - 6\n" +
                                         " - 7\n" +
                                         " - 8\n" +
                                         " - 9\n" +
                                         " - 10\n" +
                                         " - 11\n" +
                                         " - 12\n" +
                                         "- 13\n" +
                                         "- 0\n\n\n\n";

        #region Properties, fields

        public static bool Exit { get; set; }

        #endregion Properties, fields

        static void Main(string[] args)
        {
            while (!Exit)
            {
                Console.WriteLine(
                    "Choose the task. The number entered corresponds to the task number. Enter the number and press enter.");
                Console.WriteLine("To exit from application press 0");
                Console.WriteLine(ListTasks);

                bool successfullyParsed = int.TryParse(Console.ReadLine(), out var enteredNumberTask);
                if (!successfullyParsed)
                {
                    Console.WriteLine("Wrong input!!! Enter the number!!\n\n\n\n");
                }
                else
                {
                    switch (enteredNumberTask)
                    {
                        case 0:
                        {
                            Exit = true;
                            break;
                        }
                        case 1:
                        {
                            FirstTask.Instance.CalculateSquare();
                            break;
                        }
                        case 2:
                        {
                            SecondTask.Instance.ViewStars();
                            break;
                        }
                        case 3:
                        {
                            ThirdTask.Instance.ViewStars();
                            break;
                        }
                        case 4:
                        {
                            FourthTask.Instance.ViewStars();
                            break;
                        }
                        case 5:
                        {
                            FifthTask.Instance.SumOfNaturalNumbers();
                            break;
                        }
                        case 6:
                        {
                            SixthTask.Instance.LabelSelection();
                            break;
                        }
                        case 7:
                        {
                            SeventhTask.Instance.Sort();
                            break;
                        }
                        case 8:
                        {
                            EighthTask.Instance.InvertPositiveValues();
                            break;
                        }
                        case 9:
                        {
                            NinthTask.Instance.SumPositiveElements();
                            break;
                        }
                        case 10:
                        {
                            TenthTask.Instance.SumOdevityElements();
                            break;
                        }
                        case 11:
                        {
                            EleventhTask.Instance.AverageLengthWord();
                            break;
                        }
                        case 12:
                        {
                            TwelthTask.Instance.DoubleLetter();
                            break;
                        }
                        case 13:
                        {
                            ThirteenthTask.Instance.CalculateTimeExecution();
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("You entered a number of task, which not exist!\n\n\n\n");
                            break;
                        }
                    }
                }

            }
        }
    }
}