
namespace ArraySort.codeFolder
{
    public static class CustomSort
    {
        public static void Sort2DArray(int[,] array)
        {
            int counter = 0;

            int[] sort = array.Cast<int>().ToArray();

            Array.Sort(sort);
            
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = sort[counter];
                    counter++;
                }
            }
        }
        public static void Print2DArrayInConsole(int[,] arr)
        {
            int counter = 0;
            foreach (int i in arr)
            {
                counter++;
                Console.Write($"{i} ");
                if (counter % arr.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
