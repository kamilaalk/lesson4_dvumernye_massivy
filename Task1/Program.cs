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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] SearchAndChangeIndex (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;j < array.GetLength(1);j++)
        {
            if ( i%2==0 && j%2==0)
            {
                array[i,j] *= array[i,j];
            }
        }
    }
return array;
}

Console.Clear();

Console.WriteLine("input min value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input rows count:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input cols count:");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dArray(min, max, rows, cols);
Show2dArray(array);
Console.WriteLine();
Show2dArray(SearchAndChangeIndex(array));