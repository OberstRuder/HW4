namespace GitHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("array size: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arrayA = new int[n];

            for (int i = 0; i < arrayA.Length; i++)
            {
                int numb = new Random().Next(1, 26);
                arrayA[i] = numb;
                Console.Write(arrayA[i] + " ");
            }

            int[] arrayB = new int[n];

            Console.WriteLine();
            for (int i = 0; i < arrayB.Length; i++)
            {
                int numb = new Random().Next(1, 26);
                if (numb % 2 == 1){
                    arrayB[i] = numb;
                } 
                else {
                   numb++;
                   arrayB[i] = numb; 
                }

                Console.Write(arrayB[i] + " ");
            }

            int[] arrayC = new int[n];

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

            }

            for (int i = 0; i < arrayC.Length; i++)
            {
                string a = arrayC[i].ToString();
                a = a.Replace('1', 'a').Replace('3', 'b').Replace('5', 'v').Replace('3', 'd').Replace('3', 'l').Replace('3', 'j').Replace('3', 'g').Replace('3', 'k');
                Console.Write(a + " ");
            }

            
        }
    }
}