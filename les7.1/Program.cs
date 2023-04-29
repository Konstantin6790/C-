int[,] array = new int[4, 4];

FillArray(array);
PrintArray(array);

int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
	int[,] array = new int[firstLength, secondLength];

	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			array[i, j] = new Random().Next(0, 10);

	return array;
}

void FillArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
		for (int j = 0; j < array.GetLength(1); j++)
			array[i, j] = new Random().Next(0, 10);
}


void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			Console.Write($"{array[i, j]} ");
		Console.WriteLine();
	}
}