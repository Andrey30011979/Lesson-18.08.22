﻿Console.WriteLine("Please, input your number:");
string numberStr;
numberStr = Console.ReadLine();

int number = int.Parse(numberStr);

Console.WriteLine(number*number);
//1. Напишите программу, которая на вход принимает два 
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 25, b = 5 → да
//a = 2, b = 10 → нет
//a = 9, b = -3 → да
//a = -3, b = 9 → нет