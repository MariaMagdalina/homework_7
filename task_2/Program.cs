// Данная программа на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Random rand = new Random();
int row = rand.Next(2,11); // задаем количество строк
int column = rand.Next(2,11); // задаем количество столбцов
int [,] array = new int [row,column]; // создаем двумерный массив

// заполняем массив случайными числами
for(int i=0; i<row; i++)
{
   for(int j=0; j<column; j++)
   {
      array[i,j] = rand.Next();
   }
}

 // запрашиваем позиции элемента
 Console.Write("введите позиции элемента: строка ");
 int new_row = Convert.ToInt32(Console.ReadLine());
 Console.Write("столбец ");
 int new_column = Convert.ToInt32(Console.ReadLine());

 // проверяем наличие элемента в массиве и его значение
  if(new_row >= row || new_column >=column)
   Console.WriteLine("Такого элемента в данном массиве нет");
  else
   Console.WriteLine("на данной позиции находится элемент " + array[new_row,new_column]); 
 Console.WriteLine(); // для красоты)

 // выводим массив на экран для проверки 
   for(int i=0; i<row; i++)
{
   for(int j=0; j<column; j++)
   {
      Console.Write("   " + array[i,j]); 
   }
   Console.WriteLine();
}
Console.WriteLine(); // для красоты)