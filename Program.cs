﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число, и мы покажем его вторую цифру, number = ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000)
//     {
//     int num = (number - (number / 100) * 100 - number % 10) / 10;
//     Console.WriteLine($"Вторая цифра этого числа: {num}");
//     }
// else Console.Write("Это не трёхзначное число");





// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число, и мы покажем его третью цифру, либо скажем, что её нет: ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number > 999)
// {
//     number = number / 10;
// }

// if (number > 99 && number < 1000)
// {
//     Console.WriteLine($"Третья цифра этого числа: {number % 10}");
// }

// if (number < 99)
// {
//     Console.WriteLine("Это число не имеет третью цифру");
// }





// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите число: ");
// int dayOff = Convert.ToInt32(Console.ReadLine());

// if(dayOff == 6 || dayOff == 7) Console.WriteLine("Этот день выходной");
// if(dayOff == 1 || dayOff == 2 || dayOff == 3 || dayOff == 4 || dayOff == 5) Console.WriteLine("Этот день НЕ выходной");
// if(dayOff < 1 || dayOff > 7) Console.WriteLine("Таких дней в неделе нет");