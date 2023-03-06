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

    while (!isNumber)
    {
        isNumber = int.TryParse(Console.ReadLine(), out countM);
        if (!isNumber)
        {
            Console.WriteLine("Необходимо ввести целое число!");
        }
    }

    Console.WriteLine($"\nВведите {countM} целых числа:");

    while (countM > 0)
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

// =============== \\

void CrossPoint()
{
    const int LINE1 = 1;
    const int LINE2 = 2;

    double[] line1 = Line(LINE1);
    double[] line2 = Line(LINE2);
    
    if (isCross(line1, line2))
    {
        double[] coordinates = Coordinates(line1, line2);

        Console.WriteLine($"Точка пересечения линий имеет координаты ( {coordinates[0]}, {coordinates[1]} ).");
    }
}


double InputPoint(string name)
{
    Console.Write($"Введите координату {name}: ");
    double coordinate = 0;
    while (!double.TryParse(Console.ReadLine(), out coordinate))
    {
        Console.WriteLine("Необходимо ввести число!");
        Console.Write($"Введите координату {name}: ");
    }
    return coordinate;
}

double[] Line(int lineNumber)
{
    return new double[] { InputPoint($"b{lineNumber}"), InputPoint($"k{lineNumber}") };
}

double[] Coordinates(double[] line1, double[] line2)
{
    double x = (line1[1] - line2[1]) / (line2[0] - line1[0]);
    double y = line1[1] * x + line1[1];

    return new double[] { x, y };
}

bool isCross(double[] line1, double[] line2)
{
    if (line1[0] == line2[0])
    {
        if (line1[1] == line2[1])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые паралельны");
            return false;
        }
    }
    return true;
}