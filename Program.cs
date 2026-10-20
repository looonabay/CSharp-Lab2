using System;

namespace Lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Checked check = new Checked();

            Console.WriteLine("Введите номер задания 1 - 5:");
            int choice = check.ReadInt("Номер задания:");

            switch (choice)
            {
                case 1:
                {
                    // Задание 1
                    
                    Point p1 = new Point(2, 3);
                    Point p2 = new Point(-1, 5);
                    Point p3 = new Point(0, -2);

                    Console.WriteLine(p1);
                    Console.WriteLine(p2);
                    Console.WriteLine(p3);
                    
                    Console.WriteLine("Создадим свою точку!");

                    double x = check.ReadDouble
                        ("Введите координату X:");
                    double y = check.ReadDouble
                        ("Введите координату Y:");

                    Point p4 = new Point(x, y);
                    
                    Console.WriteLine(p4);

                    break;
                    
                    
                }

                case 2:
                {
                    // Задание 2

                    // Пункт 1
                    double x1 = check.ReadDouble
                        ("Введите X начала первой линии:");
                    double y1 = check.ReadDouble
                        ("Введите Y начала первой линии:");
                    double x2 = check.ReadDouble
                        ("Введите X конца первой линии:");
                    double y2 = check.ReadDouble
                        ("Введите Y конца первой линии:");

                    Point point1 = new Point(x1, y1);
                    Point point2 = new Point(x2, y2);
                    Line line1 = new Line(point1, point2);

                    // Пункт 2
                    double x3 = check.ReadDouble
                        ("Введите X начала второй линии:");
                    double y3 = check.ReadDouble
                        ("Введите Y начала второй линии:");
                    double x4 = check.ReadDouble
                        ("Введите X конца второй линии:");
                    double y4 = check.ReadDouble
                        ("Введите Y конца второй линии:");

                    Point point3 = new Point(x3, y3);
                    Point point4 = new Point(x4, y4);
                    Line line2 = new Line(point3, point4);

                    // Пункт 3
                    Line line3 = new Line(line1.Start,
                        line2.End);

                    Console.WriteLine("Созданные линии:");
                    Console.WriteLine(line1);
                    Console.WriteLine(line2);
                    Console.WriteLine(line3);

                    // Пункт 4
                    line1.Start.X = 10;
                    line1.Start.Y = 15;

                    line2.End.X = 30;
                    line2.End.Y = 20;

                    Console.WriteLine();
                    Console.WriteLine("После изменения " +
                                      "координат:");
                    Console.WriteLine(line1);
                    Console.WriteLine(line2);
                    Console.WriteLine(line3);

                    // Пункт 5
                    line1.Start = new Point(100, 100);

                    Console.WriteLine();
                    Console.WriteLine
                        ("После замены начала 1 линии:");
                    Console.WriteLine(line1);
                    Console.WriteLine(line3);

                    break;
                }

                case 3:
                {
                    // Задание 3

                    // Пункт 1
                    string name1 = check.ReadString
                        ("Введите имя первого студента:");
                    Student vasya = new Student(name1);

                    int grade1 = check.ReadGrade
                        ("Введите первую оценку:");
                    int grade2 = check.ReadGrade
                        ("Введите вторую оценку:");
                    int grade3 = check.ReadGrade
                        ("Введите третью оценку:");

                    vasya.Grades = new int[]
                        { grade1, grade2, grade3 };

                    // Пункт 2
                    string name2 = check.ReadString
                        ("Введите имя второго студента:");
                    Student petya = new Student(name2);
                    petya.Grades = vasya.Grades;

                    // Пункт 3
                    petya.Grades[0] = 5;

                    Console.WriteLine(vasya.Name + ": " + vasya);
                    Console.WriteLine(petya.Name + ": " + petya);

                    // Пункт 4
                    string name3 = check.ReadString
                        ("Введите имя третьего студента:");
                    Student andrey = new Student(name3);
                    andrey.Grades = (int[])vasya.Grades.Clone();

                    vasya.Grades[0] = 3;

                    Console.WriteLine();
                    Console.WriteLine
                        ("После изменения оценки" +
                         " первого студента:");
                    Console.WriteLine(vasya.Name + ": " + vasya);
                    Console.WriteLine(petya.Name + ": " + petya);
                    Console.WriteLine
                        (andrey.Name + ": " + andrey);

                    break;
                }

                case 4:
                {
                    // Задание 4

                    // Пункт 1
                    double x1 = check.ReadDouble
                        ("Введите X первой точки:");
                    double y1 = check.ReadDouble
                        ("Введите Y первой точки:");

                    double x2 = check.ReadDouble
                        ("Введите X второй точки:");
                    double y2 = check.ReadDouble
                        ("Введите Y второй точки:");

                    double x3 = check.ReadDouble
                        ("Введите X третьей точки:");
                    double y3 = check.ReadDouble
                        ("Введите Y третьей точки:");

                    Point point1 = new Point(x1, y1);
                    Point point2 = new Point(x2, y2);
                    Point point3 = new Point(x3, y3);

                    Console.WriteLine("Созданные точки:");
                    Console.WriteLine(point1);
                    Console.WriteLine(point2);
                    Console.WriteLine(point3);

                    // Пункт 2
                    double a1 = check.ReadDouble
                        ("Введите X начала первой линии:");
                    double b1 = check.ReadDouble
                        ("Введите Y начала первой линии:");
                    double a2 = check.ReadDouble
                        ("Введите X конца первой линии:");
                    double b2 = check.ReadDouble
                        ("Введите Y конца первой линии:");

                    Line line1 = new Line
                        (a1, b1, a2, b2);

                    double a3 = check.ReadDouble
                        ("Введите X начала второй линии:");
                    double b3 = check.ReadDouble
                        ("Введите Y начала второй линии:");
                    double a4 = check.ReadDouble
                        ("Введите X конца второй линии:");
                    double b4 = check.ReadDouble
                        ("Введите Y конца второй линии:");

                    Line line2 = new Line
                        (a3, b3, a4, b4);

                    Line line3 = new Line
                        (line1.Start, line2.End);

                    Console.WriteLine();
                    Console.WriteLine("Созданные линии:");
                    Console.WriteLine(line1);
                    Console.WriteLine(line2);
                    Console.WriteLine(line3);

                    break;
                }

                case 5:
                {
                    // Задание 5

                    double x1 = check.ReadDouble
                        ("Введите X начала линии:");
                    double y1 = check.ReadDouble
                        ("Введите Y начала линии:");
                    double x2 = check.ReadDouble
                        ("Введите X конца линии:");
                    double y2 = check.ReadDouble
                        ("Введите Y конца линии:");

                    Line line = new Line(x1, y1, x2, y2);

                    Console.WriteLine
                        ("Длина линии: " + line.Length());

                    break;
                }

                default:
                    Console.WriteLine("Такого задания нет.");
                    break;
            }
        }
    }
}
