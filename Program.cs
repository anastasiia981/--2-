// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



class Program

{
    static void Main(string[] args)
    {

        int[,] array = new int[3, 4]
         {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        int first = array.GetLength(0);
        int second = array.GetLength(1);

        for (int i = 0; i < second; i++)
        {
            int temp = array[0, i];
            array[0, i] = array[first - 1, i];
            array[first - 1, i] = temp;
        }

        for (int i = 0; i < first; i++)

        {
            for (int j = 0; j < second; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

  }   
 }
























































