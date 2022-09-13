// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10

Console.Write ("Задача 2. Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine ());
int num2 = Convert.ToInt32(Console.ReadLine ());

if (num1>num2){
    Console.WriteLine($"Максимальное число {num1}");
} else {
    Console.WriteLine($"Максимальное число {num2}");
}



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("Задача 4. Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine ());
int number2 = Convert.ToInt32(Console.ReadLine ());
int number3 = Convert.ToInt32(Console.ReadLine ());
int maximum=number1;
if (number1<number2){
    maximum=number2;
} 
if (number2<number3){
    maximum=number3;
}
Console.WriteLine($"Максимальное число {maximum}");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write ("Задача 6. Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());
if (number%2==0){
    Console.WriteLine($"Число четное");
} else {
    Console.WriteLine($"Число нечетное");
}


// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write ("Задача 8. Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine ());
int count=1;
while (count <=numberN)
{
    if (count%2==0)
        Console.Write($"{count}, ");
count++;
} 
