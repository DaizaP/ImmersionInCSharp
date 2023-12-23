using ArraySort.codeFolder;

internal class Program
{
    private static void Main()
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        CustomSort.Sort2DArray(a);
        CustomSort.Print2DArrayInConsole(a);
    }
}