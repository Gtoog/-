﻿//Console.WriteLine("Введите первое число");
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
using Microsoft.VisualBasic;

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
class Programm
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
}
//28
class Programm
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
}
//29
class Programm
{
    static void Main()
    {

        foreach (var drive in DriveInfo.GetDrives())
        {
                Console.WriteLine("Имя диска: " + drive.Name);
                Console.WriteLine("Файловая система: " + drive.DriveFormat);
                Console.WriteLine("Объем доступного свободного места (в байтах): " + drive.AvailableFreeSpace);
                Console.WriteLine("Готов ли диск: " + drive.IsReady);
                Console.WriteLine("Корневой каталог диска: " + drive.RootDirectory);
                Console.WriteLine("Общий объем свободного места, доступного на диске (в байтах): " + drive.TotalFreeSpace);
                Console.WriteLine("Размер диска (в байтах): " + drive.TotalSize);
                Console.WriteLine();
        }
        
    }
}
//30
class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите путь где будет работа с файлами");
        string path = Console.ReadLine();
        string newpath,file;
        int z = 0;
        while (true)
        {
            Console.WriteLine("Введите название и тип файла (пример mytest.txt)");
            file = path + '/' + Console.ReadLine();
            Console.WriteLine("Выберите действие создание/удаление/перемещение/копирование");
            string variant = Console.ReadLine();
            if (variant == "создание") File.Create(file);
            if (variant == "удаление") File.Delete(file);
            if (variant == "перемещение")
            {
                Console.WriteLine("Выберите куда переместить файл с указанием его названия и типом файла");
                newpath = Console.ReadLine();
                File.Move(file, newpath);
            }
            if (variant == "копирование") {
                File.Copy(file, file + $"({z})");
                z++;
            }
        }
    }
}
//31
using Newtonsoft.Json;
using System.Data;

class Programm
{
    static void Main()
    {
        const string json = @"[
            {""Name"":""AAA"",""Age"":""22"",""Job"":""PPP""},
            {""Name"":""BBB"",""Age"":""25"",""Job"":""QQQ""},
            {""Name"":""CCC"",""Age"":""38"",""Job"":""RRR""}
        ]";
        var table = JsonConvert.DeserializeObject<DataTable>(json);
        Console.WriteLine(table);
         foreach (DataRow row in table.Rows)
        {
            foreach (DataColumn column in table.Columns)
            {
                Console.Write($"{column.ColumnName}: {row[column]} ");
            }
            Console.WriteLine();
        }
    }
}
//32
using System.Data;
using System.IO;
using System.Text;
using System.Xml;

class HelloWorld
{
    static void Main()
    {
        string xmlFilePath = "data.xml";

        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("Id", typeof(int));
        dataTable.Columns.Add("Name", typeof(string));
        dataTable.Columns.Add("Price", typeof(string));

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlFilePath);

        XmlNodeList itemList = xmlDoc.GetElementsByTagName("Item");

        foreach (XmlNode item in itemList)
        {
            DataRow row = dataTable.NewRow();
            row["Id"] = Convert.ToInt32(item["Id"].InnerText);
            row["Name"] = item["Name"].InnerText;
            row["Price"] = Convert.ToString(item["Price"].InnerText);
            dataTable.Rows.Add(row);
        }
        Console.WriteLine("Id\tName\tPrice");
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine($"{row["Id"]}\t{row["Name"]}\t{row["Price"]}");
        }
    }
}
//33
class HelloWorld
{
    static void Main()
    {
       List<work> list = new List<work>();
        int count = 0;
        while (true)
        {
            Console.WriteLine("ВЫберите действие \n1) Добавить дело\n2) удалить дело\n3)Отметить дело\n4)Вывод всех дел");
            switch (int.Parse(Console.ReadLine())) 
            {
                case 1:
                    Console.WriteLine("Напишите ваше дело");
                    list.Add(new work());
                    list[count].Create(Console.ReadLine());
                    count++;
                    break;
                case 2:
                    Console.WriteLine("Напишите номер дела для удаления");
                    list.Remove(list[int.Parse(Console.ReadLine())]);
                    count--;
                    break;
                case 3:
                    Console.WriteLine("Напишите номер дела для отметки");
                    list[int.Parse(Console.ReadLine())].otmetka();
                    break;
                case 4:
                    for(int i = 0; i < list.Count();i++)
                    {
                        Console.WriteLine($"Задача: {list[i].quest} Статус: {list[i].status}");
                    }
                    break;
            }
        }
    }
}
class work
{
    public string quest { get; set; }
    public bool status = false;
    
    public void Create(string message)
    {
        quest = message;
        Console.WriteLine("Ваша задача добавлена");
    }
    public void otmetka()
    {
        status = true;
    }
}

//34
class HelloWorld
{
    static void Main()
    {
        string path = "oldFile.txt";
        string z = "";
        try
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
                string readText = File.ReadAllText(path);
            foreach (char s in readText)
            {
                if (s == char.ToLower(s))
                    z += char.ToUpper(s);

                if (s == char.ToUpper(s))
                    z += char.ToLower(s);
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(z);
            }
            Console.WriteLine( readText = File.ReadAllText(path));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
//35
using System;

class Progmramm
{
    static void Main()
    {

        Console.WriteLine("Текущий календарь");
        DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        int days = DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month);
        int x = 1;

        int offset = (int)firstDayOfMonth.DayOfWeek;

        string[] z = { "Пн", "Вт", "Ср", "Чт", "Пт", "Cб", "Вс" };
        string[] file = new string[days];
        int dayofweek = (int)firstDayOfMonth.DayOfWeek;
        for (int i = 0; i < z.Length; i++) Console.Write(z[i] + "\t");
        Console.WriteLine();

        for (int i = offset - 5; i <= days; i++)
        {
            if (i > 0)
            {
                Console.Write($"{i,2}  \t");
            }
            else
            {
                Console.Write("\t");
            }

            if ((i + offset - 1) % 7 == 0 && i != 0)
            {
                Console.WriteLine();
            }
        }
        bool exit = true;
        while (exit)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Выберите \n1) посмотреть заметку на день \n2) оставить заметку \n3) выйти");
                int vibor = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine("Введите день");
                int day = int.Parse(Console.ReadLine());
                switch (vibor)
                {
                    case '1':
                        if (file[day] == null)
                            Console.WriteLine("Заметки нету");
                        else
                        {
                            Console.WriteLine($"Заметка {file[day]}");
                        }
                        break;
                    case '2':
                        Console.WriteLine("Введите заметку");
                        file[day] = Console.ReadLine();
                        break;
                    case '3':
                        exit = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Такого действия нету");
            }
        }
    }
}
//36
using System;

class Progmramm
{
    static void Main()
    {
        List<student> list = new List<student>();
        int z = 0;
        bool exit = true;
        while (exit) 
        {
            Console.WriteLine("Выберите дейсвтие \n1) Добавить студента \n2) посмотреть всех студентов \n3) Выйти ");
            int chose = int.Parse(Console.ReadLine());
            switch(chose)
            {
                case 1:
                    list.Add(new student());
                    Console.WriteLine("Введите имя студента");
                    list[z].name = Console.ReadLine();
                    Console.WriteLine("Введите возраст студента");
                    list[z].age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите оценки студента чтобы прекратить ввод напишите 0");
                    while (true) 
                    {
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            if (number == 0)
                            {
                                break;
                            }
                            list[z].ochenka.Add(number);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    z++;
                    break;
                    case 2:
                    for(int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"Имя {list[i].name} \nВозраст{list[i].age}\nОценки {string.Join(", ", list[i].ochenka)}");
                    }
                    break;
                    case 3:
                    exit = false;
                    break;
            }

        }
        
    }
}
class student
{
    public string name { get; set; }
    public int age { get; set; }

    public List<int> ochenka { get; set; }
    public student()
    {
        ochenka = new List<int>();
    }
}
//37
using System;

class Progmramm
{
    static void Main()
    {
        List<Number> list = new List<Number>();
        bool exit = true;
        int del = 0;
        int z = 0;
        while (exit) 
        {
            Console.WriteLine("Выбери опцию \n1) Добавить\n2) удалить контакт\n3)редактироение контакта\n4)поиск контакта\n5)Выйти");
            int chose = int.Parse(Console.ReadLine());
            switch(chose)
            {
                case 1:
                    list.Add(new Number());
                    Console.WriteLine("Введите имя");
                    list[z].name = Console.ReadLine();
                    Console.WriteLine("Введите номер");
                    list[z].number = Console.ReadLine();
                    Console.WriteLine("Введите почту");
                    list[z].email = Console.ReadLine();
                    z++;
                    break;
                case 2:
                    Console.WriteLine("Введите номер контакта для удаления");
                    del = int.Parse(Console.ReadLine());
                    list.Remove(list[del]);
                    z--;
                    break;
                case 3:
                    Console.WriteLine("Введите номер контакта для изменения");
                    del = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите имя");
                    list[del].name = Console.ReadLine();
                    Console.WriteLine("Введите номер");
                    list[del].number = Console.ReadLine();
                    Console.WriteLine("Введите почту");
                    list[del].email = Console.ReadLine();
                    z++;
                    break;
                case 4:
                    Console.WriteLine("Введите фразу для поиска:");
                    string searchKeyword = Console.ReadLine();
                    List<Number> searchResults = list.FindAll(s =>
                        s.name.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase) ||
                        s.number.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase) ||
                        s.email.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase));

                    if (searchResults.Count > 0)
                    {
                        Console.WriteLine("Найденные контакты:");
                        foreach (Number result in searchResults)
                        {
                            Console.WriteLine($"Имя: {result.name}, Телефон: {result.number}, Email: {result.email}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Контакты не найдены.");
                    }
                    break;
                case 5:
                    exit = false;
                    break;
            }
        }
        
    }
}
class Number
{
    public string name {  get; set; }
    public string number { get; set; }
    public string email { get; set; }
}
using System;
//38
class Progmramm
{
    static void Main()
    {
        Pole pole = new Pole();
        bool exit = true;
        bool player = true;
        while (exit)
        {
            pole.vivod();
            pole.hod(player);
            player = !player;
            if(pole.cheak() == 5)
            {
                if(player)
                    Console.WriteLine("Выйграл игрок 1");
                else
                    Console.WriteLine("Выйграл игрок 1");
                exit = false;
            }
            if (pole.IsBoardFull())
            {
                Console.WriteLine("Никто не выйграл");
                exit = false;
            }
        }
    }
}
class Pole
{
    public int[,] z { get; set; }

    public Pole()
    {
        z = new int[,]
        {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 },
        };
    }
    public void vivod()
    {
        for(int i = 0; i < z.GetLength(0); i++)
        {
            for(int j = 0; j < z.GetLength(1); j++)
            {
                Console.Write("|  ");
                if (z[i, j] == 1)
                    Console.Write(" ");
                else if (z[i, j] == 0)
                    Console.Write("X");
                else if (z[i,j] == 2)
                    Console.Write("0");
                Console.Write("   |");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    public void hod(bool player)
    {
        Console.WriteLine("Выберите ваш ход при помощи координатов");
        int row = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        if (z[row, cols] == 1)
        {
            if (player)
                z[row, cols] = 0;
            else
                z[row, cols] = 2;
        }
        else
        {
            Console.WriteLine("Выбранное место уже занято выберите другое");
            hod(player);
        }
    }
    public int cheak()
    {
        for (int row = 0; row < 3; row++)
        {
            if (z[row, 0] != 1 && z[row, 0] == z[row, 1] && z[row, 1] == z[row, 2])
            {
                return 5; 
            }
        }

        for (int col = 0; col < 3; col++)
        {
            if (z[0, col] != 1 && z[0, col] == z[1, col] && z[1, col] == z[2, col])
            {
                return 5; 
            }
        }

        if (z[0, 0] != 1 && z[0, 0] == z[1, 1] && z[1, 1] == z[2, 2])
        {
            return 5; 
        }

        if (z[0, 2] != 1 && z[0, 2] == z[1, 1] && z[1, 1] == z[2, 0])
        {
            return 5; 
        }
        return 0; 
    }
    public bool IsBoardFull()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (z[row, col] == 1)
                {
                    return false;
                }
            }
        }
        return true;
    }
}

using System;
//39
class Programm
{
    static void Main()
    {
        Random random = new Random();
        string number = Convert.ToString(random.Next(1000, 9999)); 
        bool exit = true;
        string z = "";

        while (exit)
        {
            int buk = 0, korova = 0; 
            Console.WriteLine("Введите ваше число");
            z = Console.ReadLine();

            bool[] usedInBulls = new bool[4]; 
            bool[] usedInCows = new bool[4];   

           
            for (int i = 0; i < 4; i++)
            {
                if (z[i] == number[i])
                {
                    buk++;
                    usedInBulls[i] = true;  
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (!usedInBulls[i])  
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i != j && !usedInBulls[j] && !usedInCows[j] && z[i] == number[j])
                        {
                            korova++;
                            usedInCows[j] = true;  
                            break;  
                        }
                    }
                }
            }

            Console.WriteLine($"Быков: {buk}, Коров: {korova}");

            if (z == number)
            {
                Console.WriteLine("Поздравляю с победой!");
                exit = false;
            }
        }
    }
}
