using System;
using System.Collections;
using System.Collections.Generic;

namespace EducationalCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(1997, 7, 20);
            DateTime date2 = new DateTime(1986, 9, 18);
            DateTime date3 = new DateTime(2005, 11, 23);
            DateTime date4 = new DateTime(1980, 5, 15);
            Student man1 = new Student("Вячеслав", "Петров", "Алексеевич", date1, "ИИТ", 2, 2300);
            Manager man2 = new Manager("Василий", "Иванов", "Семенович", date2, "ИКНТ", "Лаборант", date3);
            Teacher man3 = new Teacher("Сергей", "Сидоров", "Андреевич", date4, "ААА", "Схемотехник", date3);

            ArrayList People = new ArrayList();
            People.Add(man1);
            People.Add(man2);
            People.Add(man3);

            Console.WriteLine("Список людей:");
            foreach (Person p in People) Console.WriteLine(p);

            Console.WriteLine("\nСтудент делает домашнее задание:");
            Homework hw1 = man1.DoHomework();
            Console.WriteLine("\nМенеджер пробует делать домашнее задание:");
            Homework hw2 = new Homework(man2,"Какой-то текст");

            Console.WriteLine("\nСпросим менеджера, что он думает о домашнем задании:");
            man2.PerformOfficialDuties(hw1);
            Console.WriteLine("\nСпросим его, знает ли он двух людей - студента и учителя:");
            man2.PerformOfficialDuties(man1);
            man2.PerformOfficialDuties(man3);
            Console.WriteLine("\nДадим учителю <что-то>");
            man3.PerformOfficialDuties(11);
            Console.WriteLine("\nЕсть домашнее задание студента:");
            Console.WriteLine(hw1);
            Console.WriteLine("\nДадим его на проверку учителю:");
            man3.PerformOfficialDuties(hw1);
            Console.WriteLine("\nИ вот оно проверено (или нет):");
            Console.WriteLine(hw1);
        }
    }
}