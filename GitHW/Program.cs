// GitHW
namespace GitHW
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("array size: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrayA = new int[n];
            object[] arrayB = new object[n];
            object[] arrayC = new object[n];
            object[] tempArray = new object[n];
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] upper = { 'a', 'e', 'i', 'd', 'h', 'j' };
            int b = 0;
            int c = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                int numb = new Random().Next(1, 26);
                arrayA[i] = numb;
            }


            for (int i = 0; i < arrayB.Length; i++)
            {
                int numb = new Random().Next(1, 26);
                if (numb % 2 == 0)
                {
                    numb++;
                    arrayB[i] = numb;
                } 
                else 
                {
                   arrayB[i] = numb; 
                }
            }


            for (int i = 0; i < arrayC.Length; i++)
            {
                int numb = new Random().Next(1, 26);
                if (numb % 2 == 0)
                {
                    arrayC[i] = numb;
                }
                else
                {
                    numb++;
                    arrayC[i] = numb;
                }
            }


            for (int i = 0; i < arrayB.Length; i++)
            {
                for (int num = 0; num < 27; num++)
                {
                    if (Convert.ToInt32(arrayB[i]) == num)
                    {
                        tempArray[i] = alphabet[num - 1];
                    }
                }
                arrayB[i] = tempArray[i];
            }

            for (int i = 0; i < arrayC.Length; i++)
            {
                for (int num = 0; num < 26; num++)
                {
                    if (Convert.ToInt32(arrayC[i]) == num)
                    {
                        tempArray[i] = alphabet[num - 1];
                    }
                }
                arrayC[i] = tempArray[i];
            }

            Console.WriteLine("B:");

            for (int i = 0; i < arrayB.Length; i++)
            {
                for (int num = 0; num < 6; num++)
                {
                    if (Convert.ToChar(arrayB[i]) == upper[num])
                    {
                        arrayB[i] = Char.ToUpper(Convert.ToChar(arrayB[i]));
                    }
                }
                if (Char.IsUpper(Convert.ToChar(arrayB[i])))
                {
                    b++;
                }
                Console.Write(arrayB[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("C:");

            for (int i = 0; i < arrayC.Length; i++)
            {
                for (int num = 0; num < 6; num++)
                {
                    if (Convert.ToChar(arrayC[i]) == upper[num])
                    {
                        arrayC[i] = Char.ToUpper(Convert.ToChar(arrayC[i]));
                    }
                }
                if (Char.IsUpper(Convert.ToChar(arrayC[i])))
                {
                    c++;
                }
                Console.Write(arrayC[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            if (b > c)
            {
                Console.WriteLine("B>");
            }
            else if (b < c)
            {
                Console.WriteLine("C>");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}