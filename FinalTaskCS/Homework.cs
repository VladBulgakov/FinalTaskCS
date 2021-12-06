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

        public void Check(Person checkedBy, bool Result)
        {
            if (checkedBy is not Teacher)
            {
                Console.WriteLine("Домашнее задание должен проверять учитель!");
            }
            else IsOk = Result;
        }

        public override string ToString()
        {
            string stInfo = string.Format($"Домашнее задание. Автор - {MadeBy.Name} {MadeBy.Surname}\n{HomeworkText}\nПроверено и принято: {IsOk}");
            return stInfo;
        }
    }
}
