using System;

namespace Dersde_15_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Console.WriteLine(st1.No);
            st1.FullName = "Behruz Rehimov";
            st1.AddExam("c#",85);
            st1.AddExam("intro",100);
            st1.AddExam("front",70);
            st1.AddExam(".net",60);
            Console.WriteLine(st1.AvaragePoint1());
            Group P231 = new Group() {GroupNo="P231" };
            P231.Students.Add(st1);
            P231.Students.Add(new Student() { FullName="Mubariz Ismayilov"});
            P231.Students.Add(new Student() { FullName="Faiq Veliyev"});
            P231.Students.Add(new Student() { FullName="Rehim Rehimli"});
            P231.Students[1].AddExam("into",95);
            P231.Students[1].AddExam("front",90);
            P231.Students[1].AddExam("c#",80);
            P231.Students[1].AddExam("back",75);
            P231.Students[2].AddExam("back",55);
            P231.Students[2].AddExam("intro",90);
            P231.Students[2].AddExam("c#",75);
            P231.Students[2].AddExam("front",60);
            P231.Students[3].AddExam("back",80);
            P231.Students[3].AddExam("front",95);
            P231.Students[3].AddExam("c#",90);
            P231.Students[3].AddExam("intro",100);


            Func<double, bool> coparisonstate = x => x>1;
            P231.telebe(coparisonstate);
            foreach (var item in P231.telebe(coparisonstate))
            {
                Console.WriteLine(item.FullName+"--"+item.AvaragePoint1());
            }


        }
    }
}
