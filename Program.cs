// //Задача 2
// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine()); 
// if (a > b) {
//     Console.Write("max a = " + a);
// }
// if (a < b) {
//     Console.Write("max b = " + b);
// }

//Задача 4
// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a > b && a > c)
// 	Console.Write(a);
// else if (b > a && b > c)
// 	Console.Write(b);
// else
// 	Console.Write(c);

//Задача 6
// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
//     Console.Write("Да");
// else 
//     Console.Write("Нет");

//Задача 8
Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++) {
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
} 
//Задача 10