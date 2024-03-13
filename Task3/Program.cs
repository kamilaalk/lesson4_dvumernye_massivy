using System.Diagnostics.CodeAnalysis;

int [,] Create2dArray(int min, int max, int rows, int cols){
    int [,] array = new int [rows, cols];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < cols; j++){
            array[i, j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int[,] array){
        for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ShowArray(int[] array)
{
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
}

int [] GetMiddleAriphmethic(int[,] array)
{
    int[] newArr = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        newArr[i] = sum / array.GetLength(1);
    }
    return newArr;
}

int [,] array = Create2dArray(0, 50, 3, 4);
Show2dArray(array);
int [] newarr = GetMiddleAriphmethic(array);
ShowArray(newarr);