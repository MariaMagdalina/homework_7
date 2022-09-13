// Данная программа задает двумерный массив из целых чисел и находит среднее арифметическое элементов в каждом столбце.
Console.Clear();
Random rand = new Random();
int row = rand.Next(2,10); // задаем количество строк
int column = rand.Next(2,10); // задаем количество столбцов
double [,] array = new double [row,column]; // создаем двумерный массив

// заполняем массив случайными числами
for(int i=0; i<row; i++)
{
   for(int j=0; j<column; j++)
   {
      array[i,j] = rand.NextDouble();
   }
}

// выводим массив  
   for(int i=0; i<row; i++)
{
   for(int j=0; j<column; j++)
   {
      Console.Write("   " + Math.Round(array[i,j],2)); 
   }
   Console.WriteLine();
}
Console.WriteLine(); // для красоты)

// осуществляем поиск среднего арифметического в каждом столбце
for(int j=0; j<column; j++) // перебираем столбцы
{
   double sum = 0; // сумма элементов в столбце 
   for(int i=0; i<row; i++) // перебираем строки
   {
     sum = sum + array[i,j]; 
   }
   double average = sum / row ; // находим среднее арифметическое в текущем столбце
   Console.WriteLine("Среднее арифметическое в столбце " + j + " = " + Math.Round(average,2));
}



 