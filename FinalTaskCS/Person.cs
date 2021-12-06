using System;

namespace EducationalCenter
{
    abstract class Person
    {
        private string PersonName;
        private string PersonSurname;
        private string PersonPatronymic;
        private DateTime PersonBirthDate;

        public string Name
        {
            get { return PersonName; }
        }

        public string Surname
        {
            get { return PersonSurname; }
        }

        public string Patronymic
        {
            get { return PersonPatronymic; }
        }

        public DateTime BirthDate
        {
            get { return PersonBirthDate; }
        }

        public Person(string name, string surname, string patronymic, DateTime birthdate)
        {
            PersonName = name;
            PersonSurname = surname;
            PersonPatronymic = patronymic;
            PersonBirthDate = birthdate;
        }

        public override string ToString()
        {
            string stInfo = string.Format($"ЧЕЛОВЕК\nИмя: {Name} Фамилия: {Surname} Отчество: {Patronymic}\nДата рождения: {BirthDate}");
            return stInfo;
        }
    }

    interface IEmployee
    {
        int Experience();
        void PerformOfficialDuties(object Input);

        decimal CalculateSalary();
    }
}