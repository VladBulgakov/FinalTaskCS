using System;

namespace EducationalCenter
{
    class Administrator: Person, IEmployee
    {
        private string AdministratorLabName;
        private DateTime AdministratorHiredDate;
        private static int AdministratorBasicSalary = 35000;

        public int Experience()
        {
            int exp = DateTime.Now.Year - AdministratorHiredDate.Year;
            return exp;
        }

        public decimal CalculateSalary()
        {
            return AdministratorBasicSalary + 1500 * Experience();
        }

        public Administrator(string name, string surname, string patronymic, DateTime birthdate, string administratorLabName, DateTime administratorHiredDate) : base(name, surname, patronymic, birthdate)
        {
            AdministratorLabName = administratorLabName;
            AdministratorHiredDate = administratorHiredDate;
        }

        public string PerformOfficialDuties(object Input)
        {
            return $"<Наводит порядок в лабратории {AdministratorLabName}>";
        }

        public override string ToString()
        {
            return $"АДМИНИСТРАТОР\nИмя: {Name} Фамилия: {Surname} Отчество: {Patronymic}\nДата рождения: {BirthDate}\nЛаборатория: {AdministratorLabName}\nНачал работать: {AdministratorHiredDate} (стаж {this.Experience()} лет)\nСейчас имеет зарплату {CalculateSalary()} рублей";
        }
    }
}
