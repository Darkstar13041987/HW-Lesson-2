﻿// Задача 13: cd ..

Console.WriteLine("Введите число"); // Выводим сообщение для пользователя
int number = int.Parse(Console.ReadLine()); // int Числовой считываем данные введеные пользователем

int GetThirdDigit(int number) //заводим пременную
{

    int secondDigit = number % 10;
    return secondDigit;
}
if (number < 100)      // проверяет 3 цифру если ее нет.если число меньше 100 третей цифры нет
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(GetThirdDigit(number));
