//Console.WriteLine("Введите первое число");
//int z = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите операцию между ними +-*/");
//switch(Console.ReadLine())
//{
//    case "+":
//        z = z + x; break;
//    case "-":
//        z = z - x; break;
//    case "*":
//        z = z * x; break;
//    case "/":
//        z = z / x; break;
//}
//Console.WriteLine($"Ваш ответ {z}");
// 1 задание

//Console.WriteLine("Введите строку");
//string z = Console.ReadLine();
//int word = 1;
//int bykva = 0;
//int pred = 1;
//foreach (char c in z)
//{
//    if (c != ' ' && c != '.')
//    {
//        bykva++;
//    }
//}
//for (int i = 0; i < z.Length; i++)
//{
//    if (z[i] != ' ' && z[i] != '.')
//    {
//        bykva++;
//    }
//    if (z[i] == ' ')
//    {
//        word++;
//    }
//    if (z[i] == '.' && z[i - 1] != '.')
//    {
//        pred++;
//    }
//}
//Console.WriteLine($"Символов: {bykva / 2}, слов: {word}, предложений: {pred}");
// 2 задание


//for(int i = 1; i < 10; i++)
//{
//    for(int j = 1; j < 10; j++)
//    {
//        Console.Write(i*j + "\t");
//    }
//    Console.WriteLine();
//}
//3

//Console.WriteLine("Введите число");
//int z = Convert.ToInt32(Console.ReadLine());
//int x = 1;
//for (int i = 1; i <= z; i++)
//{
//    x = i * x;
//}
//Console.WriteLine($"Ваш факториал: {x}");
//4

//Console.WriteLine("Введите число");
//int z = Convert.ToInt32(Console.ReadLine());
//int x = 1;
//int y = 0;
//int c = 0;
//for (int i = 0; i < z; i++)
//{
//    Console.Write(y + " ");
//    c = y;
//    y = y + x;
//    x = c;
//}
//5



//Console.WriteLine("Введите число");
//int z = Convert.ToInt32(Console.ReadLine());
//bool x = true;
//for (int i = 2; i < z; i++)
//{
//    x = true;
//    for (int j = 2; j <= Math.Sqrt(i); j++)
//    {
//        if (i % j == 0)
//        {
//            x = false;
//            break;
//        }
//    }
//    if (x) 
//        Console.WriteLine(i);
//}
//6

//Console.WriteLine("Введите число");
//int z = Convert.ToInt32(Console.ReadLine());
//Random rand = new Random();
//int x = rand.Next(0, 100);
//if (x == z)
//    Console.WriteLine($"Вы угадали {x}");
//else 
//    Console.WriteLine($"Вы не угадали {x}");
//7

//Console.WriteLine("Выберите круг, треугольник, прямоугольник");
//double z,x = 0;
//switch (Console.ReadLine())
//{
//    case "круг":
//        Console.WriteLine("Введите радиус");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Площадь круга: {Convert.ToDouble(z * z * 3.14)}");
//        break;
//    case "треугольник":
//        Console.WriteLine("Введите высоту");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите длину стороны, к которой проведена высота");
//        x = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Площадь треуагольника: {Convert.ToDouble(z * x / 2)}");
//        break;
//    case "прямоугольник":
//        Console.WriteLine("Введите длину");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите ширину");
//        x = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Площадь треуагольника: {Convert.ToDouble(z * x)}");
//        break;
//}
//8

//Console.WriteLine("Выберите вариант\n 1) Килограммы в граммы \n 2) Граммы в килограммы \n3) Километры в метры \n4) метры в километры");
//double z = 0;
//switch (Convert.ToInt32(Console.ReadLine()))
//{
//    case 1: Console.WriteLine("Введите килограммы");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Ваши граммы: {Convert.ToDouble(z*1000)}");
//        break;
//    case 2:
//        Console.WriteLine("Введите граммы");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Ваши килограммы: {Convert.ToDouble(z / 1000)}");
//        break;
//    case 3:
//        Console.WriteLine("Введите Километры");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Ваши метры: {Convert.ToDouble(z * 1000)}");
//        break;
//    case 4:
//        Console.WriteLine("Введите метры");
//        z = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Ваши Километры: {Convert.ToDouble(z / 1000)}");
//        break;
//}
//9

//Console.WriteLine("Введите число");
//double z = Convert.ToInt32(Console.ReadLine());
//for(int i = 0; i <= 100; i++)
//{
//    Console.WriteLine($"{i}% от {z} равен {Convert.ToDouble(z / 100) * i}");
//}
//10

//Console.WriteLine("Введите число");
//int z = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Выберите валюту \n 1)Рубли в доллары \n 2)Доллары в рубли");
//switch (Convert.ToUInt32(Console.ReadLine()))
//{
//    case 1:
//        Console.WriteLine(z % 90);
//        break;
//    case 2:
//        Console.WriteLine(z*90);
//        break;

//}
//11
//task 12
/*int[] numbers = { 1, 2, 3, 4, 5,6,7,8,9,10,0 };
int maxnum = numbers[0];
int minnum = numbers[0];
int indmax = 0;
int indmin = 0;
for(int i = 0; i < numbers.Length;i++)
{
    if(numbers[i] > maxnum)
    {
        maxnum = numbers[i];
        indmax = i;
    }
    if(numbers[i] < minnum) { 
        minnum = numbers[i];
        indmin = i;
    }
}
Console.WriteLine($"Максимальное: {maxnum} и его индекс {indmax}");

Console.WriteLine($"маленький опарыш: {minnum} и его индекс {indmin}");
*/
//task 13
/*int[] numbers = { 1, 2, 3, 4, 5,6,7,8,9,10,0 };
int num = 0;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            num = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = num;
        }
    }
}
foreach(int i in numbers)
{
    Console.WriteLine(i + " ");
}
Console.WriteLine("///////////////////////");
Array.Sort(numbers);
foreach(int i in numbers)
{
    Console.WriteLine(i + " ");
}*/
//task 14
/*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 };
bool z = false;
int search = int.Parse(Console.ReadLine());
for(int i = 0; i < numbers.Length; i++)
{
    if (search == numbers[i])
    {
        Console.WriteLine(i);
        z = true;
    }
}
if (!z)
{
    Console.WriteLine("Число не найдено");
}*/
//task 15
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 };
//int num = 0;
//for (int i = numbers.Length-1; i >= 0; i--)
//{
//    Console.WriteLine(numbers[i] + " ");
//}
//taski 16
/*Console.WriteLine("Введите размер матрицы AxB");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int[,] matr = new int[a,b];
int[,] matr1 = new int[a, b];
Console.WriteLine("Введите первую матрицу");
for (int i = 0; i < a; i++)
{
    for(int j = 0; j < b; j++)
    {
        matr[i,j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Введите 2 матрицу");
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        matr1[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Введите операцию * + - транспорирование");
switch (Console.ReadLine())
{
    case "+":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] + matr1[i, j];
            }
        }
        break;
    case "-":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] - matr1[i, j];
            }
        }
        break;
    case "*":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] * matr1[i, j];
            }
        }
        break;
    case "транспорирование":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr1[j, i] = matr[i, j];
            }
        }
        matr = matr1;
        break;
}
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        Console.Write(matr[i,j] + " ");
    }
    Console.WriteLine(" ");
}*/
//task17
/*Console.WriteLine("Введите ваше 10-ное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите систему счисления для перевода (2, 8, 16)");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 2:
        string result = Convert.ToString(num, 2);
        Console.WriteLine(result);
        break;
    case 8:
        string result1 = Convert.ToString(num, 8);
        Console.WriteLine(result1);
        break;
    case 16:
        string result2 = Convert.ToString(num, 16);
        Console.WriteLine(result2);
        break;
}*/
//task18
/*Console.WriteLine("Числовая пирамида");
int l = 1 + 2 * (10 - 1);
int n = 1;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(new string(' ', (int)(l - n / 2)) + new string('1', n));
    n += 2;
}*/
/*//task19
Console.WriteLine("Введите строку");
string str = Console.ReadLine();
Console.WriteLine("Введите подстроку для поиска");
string substr = Console.ReadLine();
int index = str.IndexOf(substr);
if (index == -1)
{
    Console.WriteLine("Вхождения не найдено");
}
else
{
    Console.WriteLine(index);
}*/
//task 20
/*Console.WriteLine("Удаление пробелов");
Console.WriteLine("Ваша строка");
string str = Console.ReadLine();
string str1 = "";
for (int i = 1; i < str.Length; i++)
{
    if (str[i] != ' ' || str[i - 1] != ' ')
    {
        str1 = str1 + str[i - 1];
    }
}
str1 = str1 + str[str.Length-1];
Console.WriteLine(str1);*/

//21
/*Console.WriteLine("Введите дни");
int day, mount, year;
day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц");
mount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите год");
year = Convert.ToInt32(Console.ReadLine());
DateTime date1 = new DateTime(year, mount, day);
Console.WriteLine("Введите дни");
day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц");
mount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите год");
year = Convert.ToInt32(Console.ReadLine());
DateTime date2 = new DateTime(year, mount, day);
Console.WriteLine("Разница в днях "+(date1 - date2).Days);*/

//22
/*Console.WriteLine("Введите номер телефона в формате +7XXXXXXXXX без +7");
string nomber = "";
while (true)
{
    nomber = Console.ReadLine();
    if(nomber.Length == 10)
    {
        Console.WriteLine("Номер введен верно");
        break;
    }
    else Console.WriteLine("Введите номер заново ");
}
string prav;
Console.WriteLine("Введите почту mail.ru");
while (true)
{
    nomber = Console.ReadLine();
    if (nomber.Length > 7)
    {
        prav = nomber.Substring(nomber.Length - 8);
        if (prav == "@mail.ru")
        {
            Console.WriteLine("Почта введена верно");
            break;
        }
        else Console.WriteLine("Введите почту заново ");
    }

    else Console.WriteLine("Введите почту заново ");
}*/

//23
/*Console.WriteLine("Введите длину пароля");
int len = Convert.ToInt32(Console.ReadLine());
string[] mass = ["1","2","5","A","g","a","q","y","?","!","F","T"];
Random rand = new Random();
for(int i = 0; i < len; i++)
{
    Console.Write(mass[rand.Next(0,13)]);
}*/

//24
/*Console.WriteLine("Введите сколько всего покупок в списке");
int cheslo = int.Parse(Console.ReadLine());
string[] mass = new string[cheslo];
float[] mass1 = new float[cheslo];
float sred = 0;
for(int i = 0; i < cheslo; i++)
{
    Console.WriteLine("Введите название продукта");
    mass[i] = Console.ReadLine();
    Console.WriteLine("Введите цену товара");
    mass1[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < cheslo; i++)
{
    Console.WriteLine(mass[i] + " " + mass1[i]);
    sred += mass1[i];
}
Console.WriteLine("Общая цена: "+ sred+ " из этого сумма НДС: " + sred*20/120);*/

//25
/*using System.Diagnostics.Metrics;

Console.WriteLine("Введите текс");
string stroka = Console.ReadLine();
int z = 0;
string[] mass = stroka.Split(" ");
string[] mass1 = new string[mass.Length];
int[] massnum = new int[mass.Length];
foreach (string s in mass)
{
    foreach (string s2 in mass)
    {
        if (s2 == s)
        {
            massnum[z]++;
            continue;
        }
    }
    mass1[z] = s;
    z++;
}
for (int i = 0; i < mass1.Length; i++)
{
    for (int j = i+1; j < mass1.Length; j++)
    {
        if (mass1[i] == mass1[j])
        {
            massnum[j] = 0;
        }
    }
}
Console.WriteLine($"Слова и их число использования");
for (int i = 0; i < massnum.Length; i++)
{
    if (massnum[i] != 0)
    {
        Console.WriteLine($"{mass1[i]} {massnum[i]}");
    }
}*/
//26
/*using Microsoft.VisualBasic;

Console.WriteLine("Введите часы");
int hour = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минуты");
int mints = int.Parse(Console.ReadLine());
DateTime date1 = new DateTime(0001, 1, 1, hour, mints, 0);
Console.WriteLine("Введите часы");
hour = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минуты");
mints = int.Parse(Console.ReadLine());
DateTime date2 = new DateTime(0001, 1, 1, hour, mints, 0);
Console.WriteLine("Операция + или -?");
switch (Console.ReadLine())
{
    case "-":
        date1 = date1.Subtract(date2.TimeOfDay);
        break;
    case "+":
        date1 = date1.Add(date2.TimeOfDay);
        break;
}
Console.WriteLine($"Ответ: {date1}");*/
//27
/*class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите коэфицент a");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите коэфицент b");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите коэфицент c");
        double c = Convert.ToInt32(Console.ReadLine());
        if(b*b - a*c*4 > 0)
        {
            Console.WriteLine($"Ваш первый коэфицент x равен: {(-1*b+Math.Sqrt(b * b - a * c * 4))/(2*a)} ");
            Console.WriteLine($"Ваш второй коэфицент x равен: {(-1 * b - Math.Sqrt(b * b - a * c * 4)) / (2 * a)} ");
        }
        else if(b * b - a * c * 4 == 0)
        {
            Console.WriteLine($"Ваш ответ равен: {(-1 * b )/ (2 * a)}");
        }
        else if (b * b - a * c * 4 < 0)
        {
            Console.WriteLine("Корней нету");
        }
    }
}*/
//28
/*class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите значение x");
        float x1 = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Введите значение y");
        float y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ответ");
        float z1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение x");
        float x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение y");
        float y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ответ");
        float z2 = Convert.ToInt32(Console.ReadLine());
        float obch = x1 * y2 - x2 * y1;
        float otvetX = z1 * y2 - z2 * y1;
        float otvetY = x1 * z2 - x2 * z1;
        float x = otvetX / obch;
        float y = otvetY / obch;
        Console.WriteLine($"Решение системы уравнений: x = {x}, y = {y}");
    }
}*/
//29
