using System;

namespace CaseStudy3and4
{
    internal class Student
    {
        private int id;
        private string name;
        private DateTime now;

        public Student(int id, string name, DateTime now)
        {
            this.id = id;
            this.name = name;
            this.now = now;
        }
    }
}