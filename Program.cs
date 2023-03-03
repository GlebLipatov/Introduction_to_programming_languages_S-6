Console.WriteLine("Задача 41\n");

PositiveNumbers();

Console.WriteLine("\nЗадача 43\n");

CrossPoint();

Console.WriteLine("\nЗадача 42\n");



// ====================== \\

void PositiveNumbers()
{
    int countM = 0;
    int temp = 0;
    int result = 0;
    bool isNumber = false;
    List<int> numbers = new List<int>();

    Console.Write("Введите кол-во чисел, которое хотите ввести:");
    
    while(!isNumber)
    {
        isNumber = int.TryParse(Console.ReadLine(), out countM);
        if (!isNumber)
        {
            Console.WriteLine("Необходимо ввести целое число!");
        }
    }

    Console.WriteLine($"\nВведите {countM} целых числа:");
    
    while(countM > 0)
    {
        isNumber = int.TryParse(Console.ReadLine(), out temp);

        if (!isNumber)
        {
            Console.WriteLine("Необходимо ввести целое число!");
        }
        else
        {
            numbers.Add(temp);
            countM--;
            if (countM > 0) Console.WriteLine($"Необходимо ввести еще {countM} целых числа:");
        }
    }
    foreach (int n in numbers)
    {
        if (n > 0) result++;
    }
    Console.WriteLine($"В массиве numbers из {numbers.Count} чисел {result} положительных.");
}

void CrossPoint()
{
    
}