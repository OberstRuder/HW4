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


            
        }
    }
}