//  Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
Console.Clear();

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [m,n]; // создаем двумерный массив
Random rand = new Random();

// заполняем массив случайными вещественными числами
for(int i=0; i<m; i++)
{
   for(int j=0; j<n; j++)
   {
      array[i,j] = rand.NextDouble();
   }
}

 // выводим элементы массива  
   for(int i=0; i<m; i++)
   {
      for(int j=0; j<n; j++)
      {
         Console.Write("   " + Math.Round(array[i,j],2));
      }
      Console.WriteLine();
   }