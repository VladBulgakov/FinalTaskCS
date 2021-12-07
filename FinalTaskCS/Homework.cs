using System;

namespace EducationalCenter
{
    class Homework
    {
        public Person MadeBy { get; }
        public string HomeworkText { get; }
        private bool IsOk = false;

        public Homework(Person madeBy, string homeworkText)
        {
            if (madeBy is not Student)
            {
                Console.WriteLine("Домашнее задание должен делать ученик!");
            }
            else
            {
                MadeBy = madeBy;
                HomeworkText = homeworkText;
            }
        }

        public string Check(Person checkedBy, bool Result)
        {
            if (checkedBy is not Teacher)
            {
                return "Домашнее задание должен проверять учитель!";
            }
            else
            {
                IsOk = Result;
                return "Домашнее задание проверено";
            }
        }

        public override string ToString()
        {
            return $"Домашнее задание. Автор - {MadeBy.Name} {MadeBy.Surname}\n{HomeworkText}\nПроверено и принято: {IsOk}";
        }
    }
}
