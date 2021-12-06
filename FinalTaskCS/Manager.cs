using System;

namespace EducationalCenter
{
    class Manager : Person, IEmployee
    {
        private string ManagerFaculty;
        private string ManagerPosition;
        private DateTime ManagerHiredDate;
        private static int ManagerBasicSalary = 40000;

        public int Experience()
        {
            int exp = DateTime.Now.Year - ManagerHiredDate.Year;
            return exp;
        }

        public decimal CalculateSalary()
        {
            return ManagerBasicSalary + 1000 * Experience();
        }

        public Manager(string name, string surname, string patronymic, DateTime birthdate, string teacherFaculty, string teacherPosition, DateTime teacherHiredDate) : base(name, surname, patronymic, birthdate)
        {
            ManagerFaculty = teacherFaculty;
            ManagerPosition = teacherPosition;
            ManagerHiredDate = teacherHiredDate;
        }

        public void PerformOfficialDuties(object Input)
        {
            if (Input is Person)
            {
                Person person = (Person)Input;
                Console.WriteLine($"\"Я знаю этого человека! Это {person.Surname} {person.Name}. {((person is IEmployee)? "Он из персонала" : "")}\"");
                //if (person is IEmployee) Console.WriteLine("Он из нашего коллектива");
            }
            else
            {
                Console.WriteLine("\"Ну что тут скажешь...\"");
            }
        }

        public override string ToString() //Переопределение метода для вывода информации
        {
            string stInfo = string.Format($"МЕНЕДЖЕР\nИмя: {Name} Фамилия: {Surname} Отчество: {Patronymic}\nДата рождения: {BirthDate}\nФакультет: {ManagerFaculty} Должность: {ManagerPosition}\nНачал работать: {ManagerHiredDate} (стаж {this.Experience()} лет)\nСейчас имеет зарплату {CalculateSalary()} рублей");
            return stInfo;
        }
    }
}
