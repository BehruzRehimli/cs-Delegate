using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_15_task
{
    internal class Student
    {
        public Student()
        {
            Count++;
            No = Count;
        }
        static double Count;
        public readonly double No;
        public string FullName;
        private Dictionary<string,int> _exams=new Dictionary<string,int>();
        public void AddExam(string str, int point)
        {
            if (_exams.ContainsKey(str))
            {
                throw new Exception();
            }
            if (point >= 0 && point <= 100)
            {
                _exams.Add(str, point);
            }
        }
        public void ShowAllExans()
        {
            foreach (var item in _exams)
            {
                Console.WriteLine($"{item.Key}-{item.Value} bal");
            }
        }
        public double AvaragePoint1()
        {
            double sum = 0;
            foreach (var item in _exams)
            {
                sum += item.Value;
            }
            return sum/_exams.Count;
        }

    }
}
