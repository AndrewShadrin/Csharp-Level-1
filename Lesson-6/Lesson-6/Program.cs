/// <summary>
/// 3. Переделать программу «Пример использования коллекций» для решения следующих задач:
/// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
/// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
/// в) отсортировать список по возрасту студента;
/// г) * отсортировать список по курсу и возрасту студента;
/// д) разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.
/// Выполнил Шадрин Андрей
/// </summary>

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int MyDelegat(Student st1, Student st2) 
    {
        return String.Compare(st1.firstName, st2.firstName); 
    }

    /// <summary>
    /// Сравнивает 2 студента по возрасту
    /// </summary>
    /// <param name="st1">1 студент</param>
    /// <param name="st2">2 студент</param>
    /// <returns>число согласно порядку сортировки</returns>
    static int SortAge(Student st1, Student st2)
    {
        if (st1.age < st2.age)
        {
            return -1;
        }
        else if (st1.age > st2.age)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// Сравнивает 2 студента по курсу и возрасту
    /// </summary>
    /// <param name="st1">1 студент</param>
    /// <param name="st2">2 студент</param>
    /// <returns>число согласно порядку сортировки</returns>
    static int SortCourseAge(Student st1, Student st2) 
    {
        if (st1.course<st2.course)
        {
            return -1;
        }
        else if (st1.course>st2.course)
        {
            return 1;
        }
        else
        {
            return SortAge(st1, st2);
        }
    }

    /// <summary>
    /// Определяет студента 5-6 курса
    /// </summary>
    /// <param name="student">Студент</param>
    /// <returns>Истина, если студент 5-6 курса</returns>
    static bool Search5_6(Student student)
    {
        return student.course >= 5;
    }

    /// <summary>
    /// Выводит список студентов в консоль
    /// </summary>
    /// <param name="list">список студентов</param>
    static void PrintStudents(List<Student> list)
    {
        foreach (var v in list) Console.WriteLine($"{v.firstName} {v.lastName} курс: {v.course} возраст: {v.age}");
    }

    /// <summary>
    /// Реализует проверку студента по списку условий
    /// </summary>
    /// <param name="student">Студент</param>
    /// <param name="keys">Список условий в виде предикатов</param>
    /// <returns>Истина, если студент соответствует всем условиям</returns>
    static bool SearchParam(Student student, List<Predicate<Student>> keys)
    {
        bool res = true;
        foreach (var item in keys)
        {
            if (!item(student))
            {
                res = false;
            }
        }
        return res;
    }

    static void Main()
    {
        int bakalavr = 0;
        int magistr = 0;
        List<Student> list = new List<Student>();
        // Создаем список студентов
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("students_6.csv");
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Добавляем в список новый экземпляр класса Student
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                // Одновременно подсчитываем количество бакалавров и магистров
                if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                // Выход из Main
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            }
        }
        sr.Close();
        //list.Sort(new Comparison<Student>(MyDelegat));
        Console.WriteLine("Всего студентов:" + list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        list.Sort(SortAge);
        Console.WriteLine("Сортировка по возрасту");
        PrintStudents(list);
        Console.WriteLine($"Количество учащихся 5-6 курса: {list.FindAll(Search5_6).Count}");
        Console.WriteLine($"Количество учащихся 5-6 курса (лямбда выражение): {list.FindAll(e => e.course == 5||e.course==6).Count}");
        Console.WriteLine($"Количество учащихся 6 курса (лямбда выражение): {list.FindAll(e => e.course == 6).Count}");
        list.Sort(SortCourseAge);
        Console.WriteLine("Сортировка по курсу и возрасту");
        PrintStudents(list);
        List<Predicate<Student>> dic = new List<Predicate<Student>>();
        dic.Add((e => e.course == 3 || e.course == 4));
        dic.Add((e => e.firstName == "Василий"));
        Console.WriteLine();
        PrintStudents(list.FindAll(e => SearchParam(e, dic)));
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}