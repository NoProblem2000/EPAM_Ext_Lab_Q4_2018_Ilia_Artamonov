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

        // ki: публичными могут быть только свойства. Не забываем про принцип инкапсуляции. 
        public static bool Exit { get; set; }

        #endregion Properties, fields

        static void Main(string[] args)
        {
            while (!Exit)
            {
                Console.WriteLine("Choose the task. The number entered corresponds to the task number. Enter the number and press enter.");
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
                                // ki. Я бы не создавал экземпляр класса каждый раз, чтобы не засорять память, которую сборщик мусора отчистит далеко не сразу
                                // для экономии ресурсов я бы использовал паттерн Одиночка. Это уже продвинутый уровень разработки, но твои задания сделаны очень качественно
                                // и я считаю, что тебя уже можно начать с этим знакомить.
                                FirstTask.Instance.CalculateSquare();
                                break;
                            }
                        case 2:
                            {
                                new SecondTask().ViewStars();
                                break;
                            }
                        case 3:
                            {
                                new ThirdTask().ViewStars();
                                break;
                            }
                        case 4:
                            {
                                new FourthTask().ViewStars();
                                break;
                            }
                        case 5:
                            {
                                new FifthTask().SumOfNaturalNumbers();
                                break;
                            }
                        case 6:
                            {
                                new SixthTask().LabelSelection();
                                break;
                            }
                        case 7:
                            {
                                new SeventhTask().Sort();
                                break;
                            }
                        case 8:
                            {
                                new EighthTask().InvertPositiveValues();
                                break;
                            }
                        case 9:
                            {
                                new NinthTask().SumPositiveElements();
                                break;
                            }
                        case 10:
                            {
                                new TenthTask().SumOdevityElements();
                                break;
                            }
                        case 11:
                            {
                                new EleventhTask().AverageLengthWord();
                                break;
                            }
                        case 12:
                            {
                                new TwelthTask().DoubleLetter();
                                break;
                            }
                        case 13:
                            {
                                new ThirteenthTask().CalculateTimeExecution();
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