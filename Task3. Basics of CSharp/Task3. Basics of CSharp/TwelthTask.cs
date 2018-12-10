using System;
using System.Linq;
using System.Text;

namespace Task3.Basics_of_CSharp
{
    class TwelthTask
    {
        public void DoubleLetter()
        {
            while (true)
            {
                StringBuilder finalString = new StringBuilder();
                Console.WriteLine("This task double letters in string on equality you input string");
                Console.WriteLine("Input original sentence");
                string originString = Console.ReadLine();
                char[] arrayOriginString = originString.ToCharArray();

                if (originString == "")
                {
                    Console.WriteLine("You entered empty string");
                    continue;
                }

                Console.WriteLine("Input the sentence which double letters in origin sentence");
                string strForDoubled = Console.ReadLine();
                if (strForDoubled == "")
                {
                    Console.WriteLine("You entered empty string");
                    continue;
                }

                //char[] arrayForDoubled = strForDoubled.ToCharArray();
                for (int i = 0; i < arrayOriginString.Length; i++)
                {
                    if (strForDoubled.Contains(arrayOriginString[i]) && !char.IsPunctuation(arrayOriginString[i]) && !char.IsSeparator(arrayOriginString[i]))
                    {
                        finalString.Append(String.Concat(Enumerable.Repeat(arrayOriginString[i], 2)));
                    }
                    else
                    {
                        finalString.Append(arrayOriginString[i]);
                    }
                }
                Console.WriteLine("Final string sentence " + finalString + "\n");
                Console.WriteLine("Press enter to exit to main menu");
                Console.ReadKey();
                break;
            }
        }
    }
}