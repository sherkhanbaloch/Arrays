namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Array
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // 2-D Array
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged Array
            int[][] arr3 = new int[3][];

            arr3[0] = new int[3] { 1, 2, 3 };
            arr3[1] = new int[1] { 2 };
            arr3[2] = new int[2] { 3, 2 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.Write(arr3[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Object Array
            object[] arr4 = { 'S', "Sher Khan", 22, true, 21.5 };
            
            foreach (object item in arr4)
            {
                Console.WriteLine(item);
            }

        }
    }
}
