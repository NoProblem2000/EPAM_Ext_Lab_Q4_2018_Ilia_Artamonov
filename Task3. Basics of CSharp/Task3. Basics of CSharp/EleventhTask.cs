using System;
using System.Linq;
namespace Task3.Basics_of_CSharp
{
    // ki. модификаторы доступа надо указывать явно всегда- это в большинстве соглашений о кодировании прописано
    public class EleventhTask
    {
        private static readonly Lazy<EleventhTask> LazyInstance =
            new Lazy<EleventhTask>(() => new EleventhTask());

        public static EleventhTask Instance => LazyInstance.Value;

        private int LenghthOneWord;
        // ki. везде вижу этот момент - не обязательно и не нужно инициализировать переменные значениями по умолчанию
        private int CountWords = 0;
        private double Average;
        private double Sum = 0;

        // ki. отделаяй пустыми  строками логически не связанные блоки кода. так легче читать.
        public void AverageLengthWord()
        {
            while (true)
            {
                Console.WriteLine("Input the sentence");
                string originStr = Console.ReadLine();
                if (String.IsNullOrEmpty(originStr))
                {
                    Console.WriteLine("You don't enter nothing");
                    continue;
                }
                bool isDigitPresent = originStr.Any(char.IsDigit);
                if (isDigitPresent)
                {
                    Console.WriteLine("You entered the sentence, which contains numbers. UInput the sentence only with words");
                    continue;
                }

                char[] array = originStr.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    if (char.IsSeparator(array[i]) || char.IsPunctuation(array[i]))
                    {
                        Sum += LenghthOneWord;
                        if (LenghthOneWord == 0)
                        {
                            continue;
                        }
                        CountWords++;
                        LenghthOneWord = 0;
                        continue;
                    }

                    if ((!char.IsSeparator(array[i]) || char.IsPunctuation(array[i])) && i == array.Length)
                    {
                        Sum += LenghthOneWord;
                        CountWords++;
                    }
                    LenghthOneWord++;
                }

                if (Sum == 0)
                {
                    Sum = array.Length;
                    CountWords = 1;
                }
                Average = Sum / CountWords;
                Console.WriteLine($"The average sum of sentence is {Average}");
                Console.WriteLine("Press enter\n\n");
                Console.ReadKey();
                break;
            }
        }
    }

}