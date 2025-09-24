using System;
using System.Security.Cryptography;
using System.Linq;

// Задание 1
string[] obj = ["sword", "shield", "potion", "sword", "potion", "potion"];

// Задание 2
int[] num = [2, 4, 5, 6, 2, 1];
int n_sum = num.Sum();
Console.WriteLine(n_sum);

// Задание 3
int[] num1 = [2, 3, 4, 5, 6];
int maxx = num1[0];

for (int i = 1; i < num1.Length; i++) {
    if (num1[i] > maxx) {
        maxx = num1[i];
    }
}
Console.WriteLine(maxx);

// Задание 4
int[] num2 = [1, 2, 3, 4, 5,];
int chetnoe = 0;
int nechentoe = 0;

foreach (int i in num2) {
    if (i % 2 == 0) {
        chetnoe++;
    }
    else {
        nechentoe++;
    }
}
Console.WriteLine($"чётные: {chetnoe}\nне чётные: {nechentoe}");

// Здание 5
int[] num3 = [120, 95, 110, 105, 100];
int faster = num3.Min();
Console.WriteLine(faster);

// Задание 6
string[] t = ["win", "loss", "win", "win", "loss"];
int kw = 0;
int kl = 0;

foreach (string h in t) {
    if (h == "win") {
        kw++;
    }
    else {
        kl++;
    }
}
Console.WriteLine($"побед: {kw}\nпоражений: {kl}");

// Задание 7
int[] num4 = [15, 20, 25, 30, 10];
double aver = num4.Average();
Console.WriteLine(aver);

// Задание 8
string[] t2 = {"Меч", "Ласточка", "Бомба", "Зелье", "Гром", "Ласточка"};
for (int i = 0; i < t2.Length; i++)
{
    if (t2[i] == "Ласточка")
    {
        t2[i] = t2[i].Replace("Ласточка", "Кошка");
    }
}
Console.WriteLine(string.Join(", ", t2));

// Задание 9
string[] minon = { "Garrus", "Tali", "Mordin", "Grunt", "Jack"};
string[] roles = { "Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка" };

if (minon.Length != roles.Length)
{
    Console.WriteLine("error");
    return;
}

for (int i = 0; i < minon.Length; i++)
{
    Console.WriteLine($"{roles[i]}: {minon[i]}");
}