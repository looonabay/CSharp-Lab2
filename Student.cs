using System;

namespace Lab2
{
    internal class Student
    {
        private string name;
        private int[] grades;
        
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int[] Grades
        {
            get { return this.grades; }
            set { this.grades = value; }
        }

        
        public Student(string name)
        {
            this.name = name;
            this.grades = new int[0];
        }

        
        public override string ToString()
        {
            return this.name + ": [" + string.Join(", ", 
                this.grades) + "]";
        }
    }
}