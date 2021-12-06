using System;

namespace EducationalCenter
{
    class Student : Person
    {
        private string StudentFaculty;
        private int StudentGroupNumber;
        private decimal StudentScholarship;

        public Student(string name, string surname, string patronymic, DateTime birthdate, string faculty, int groupNumber, decimal scholarship) : base(name, surname, patronymic, birthdate)
        {
            StudentGroupNumber = groupNumber;
            StudentScholarship = scholarship;
            StudentFaculty = faculty;
        }

        public string SayHi()
        {
            string stSay = string.Format($"\"Привет. Меня зовут {Surname} {Name}, я студент\nВ свободное время я хожу в кино на стипендию, она у меня {StudentScholarship} рублей\"");
            return stSay;
        }

        public Homework DoHomework()
        {
            Console.WriteLine("\"Надо написать домашнюю работу...\"");
            string input = Console.ReadLine();
            Console.WriteLine("\"Сделал!\"");
            Homework hw = new Homework(this,input);
            return hw;
        }

        public override string ToString()
        {
            string stInfo = string.Format($"СТУДЕНТ\nИмя: {Name} Фамилия: {Surname} Отчество: {Patronymic}\nДата рождения: {BirthDate}\nФакультет: {StudentFaculty} Номер группы: {StudentGroupNumber}\nСтипендия: {StudentScholarship}");
            return stInfo;
        }
    }
}
