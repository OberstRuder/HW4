using System;

namespace GitHW
{
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
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

            for (int i = 0; i < arrayA.Length; i++)
            {
                int numb = new Random().Next(1, 26);
                arrayA[i] = numb;

            }
           
            Console.WriteLine();

            for (int i = 0; i < arrayB.Length; i++)
            {
                int numb = new Random().Next(1, 26);
                if (numb % 2 == 0){
                    numb++;
                    arrayB[i] = numb;
                } 
                else {
                   arrayB[i] = numb; 
                }

                Console.Write(arrayB[i] + " ");
            }

            Console.WriteLine();

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
                Console.Write(arrayC[i] + " ");
            }

            Console.WriteLine();

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
                for (int num = 0; num < 27; num++)
                {
                    if (Convert.ToInt32(arrayC[i]) == num)
                    {
                        tempArray[i] = alphabet[num - 1];
                    }
                }
                arrayC[i] = tempArray[i];
            }




        }
    }
}