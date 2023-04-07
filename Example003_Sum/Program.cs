// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int sum = number1 + number2;
// Console.WriteLine("Сумма введенных чисел будет равна: " + sum);

// Второй пример с использованием Рандома

int number1 = new Random().Next(1, 100);
Console.WriteLine("Первое рандомное число равно: " + number1);
int number2 = new Random().Next(1, 100);
Console.WriteLine("Второе рандомное число равно: " + number2);
int sum = number1 + number2;
Console.WriteLine("Сумма введенных чисел будет равна: " + sum);