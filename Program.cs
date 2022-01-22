// See https://aka.ms/new-console-template for more information
var rand = new Random();
Console.WriteLine("Введите рамер массива:");
int arrayLenght = Convert.ToInt32(Console.ReadLine());
int [] arrayRandom = new int [arrayLenght];
for (int i = 0; i < arrayLenght; i++)
{
    arrayRandom[i] = rand.Next(0, 50);
    Console.Write(arrayRandom[i]+" ");
}
Console.WriteLine();

Task task1 = new Task(() =>ArraySumm(arrayRandom));
Task task2 = new Task(() => ArrayMax(arrayRandom));
task1.Start();
task1.Wait();
task2.Start();

 int ArraySumm(int [] array)
{
    int summ = array.Sum();
    Console.WriteLine("cумма чисел массива {0}",summ);
    return summ;
}
int ArrayMax(int[] array)
{
    int max = array.Max();
    Console.WriteLine("максимальное число массива {0}", max);
    return max;
}
