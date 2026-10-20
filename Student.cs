using System;

namespace Lab2
{
    internal class Student
    {
        private string _name;
        private int[] _grades;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public int[] Grades
        {
            get
            {
                return this._grades;
            }
            set
            {
                this._grades = value;
            }
            
        }

        public Student(string name)
        {
            this._name = name;
            this._grades = new int[0];
        }

        public override string ToString()
        {
            return this._name + ": [" + string.Join(", ",
                this._grades) + "]";
        }
    }
}
