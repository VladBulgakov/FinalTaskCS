using System;

namespace EducationalCenter
{
    class Teacher : Person, IEmployee
    {
        private string TeacherFaculty;
        private string TeacherPosition;
        private DateTime TeacherHiredDate;
        private static int TeacherBasicSalary = 45000;

        public int Experience()
        {
            int exp = DateTime.Now.Year - TeacherHiredDate.Year;
            return exp;
        }

        public decimal CalculateSalary()
        {
            return TeacherBasicSalary + 2500 * Experience();
        }

        public Teacher(string name, string surname, string patronymic, DateTime birthdate, string teacherFaculty, string teacherPosition, DateTime teacherHiredDate) : base(name, surname, patronymic, birthdate)
        {
            TeacherFaculty = teacherFaculty;
            TeacherPosition = teacherPosition;
            TeacherHiredDate = teacherHiredDate;
        }

        public string PerformOfficialDuties(object Input)
        {
            if (Input is Homework)
            {
                string TeacherSays = String.Empty;
                Homework hw = (Homework)Input;
                TeacherSays = $"\"Проверим домашнее задание студента {hw.MadeBy.Surname} {hw.MadeBy.Name}...\"\n\"Он пишет:\"\n\"{hw.HomeworkText}\"";
                if (hw.HomeworkText.Length>20)
                {
                    TeacherSays += "\n\"Хорошая работа!\"";
                    hw.Check(this, true);
                    return TeacherSays;
                }
                else
                {
                    TeacherSays += "\n\"Маловато, пускай еще раз попробует\"";
                    hw.Check(this, false);
                    return TeacherSays;
                }
            }
            else
            {
                return "\"Не знаю что это такое\"";
            }
        }

        public override string ToString()
        {
            return $"ПРЕПОДАВАТЕЛЬ\nИмя: {Name} Фамилия: {Surname} Отчество: {Patronymic}\nДата рождения: {BirthDate}\nФакультет: {TeacherFaculty} Должность: {TeacherPosition}\nНачал работать: {TeacherHiredDate} (стаж {this.Experience()} лет)\nСейчас имеет зарплату {CalculateSalary()} рублей";
        }
    }
}
