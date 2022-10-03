// 
string[,] table = new string[2, 5];
// table[0, 0] ... table[0, 4]
// table[1, 0] ... table[1, 4]
table[1, 2] = "слово";

for (int row = 0; row < 2; row++)
{
    for (int col = 0; col < 5; col++)
    {
        Console.WriteLine($"-{table[row, col]}-");
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); // [1;10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);