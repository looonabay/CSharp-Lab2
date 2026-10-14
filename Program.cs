
using System;

namespace Lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания  1 - 5:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    // Задание 1

                    Point point1 = new Point(2, 3);
                    Point point2 = new Point(-1, 5);
                    Point point3 = new Point(0, -2);

                    Console.WriteLine("Первая точка: " + point1);
                    Console.WriteLine("Вторая точка: " + point2);
                    Console.WriteLine("Третья точка: " + point3);

                    break;
                }

                case 2:
                {
                    // Задание 2

                    // Пункт 1
                    Point point1 = new Point(1, 3);
                    Point point2 = new Point(23, 8);
                    Line line1 = new Line(point1, point2);

                    // Пункт 2
                    Point point3 = new Point(5, 10);
                    Point point4 = new Point(25, 10);
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
                    Console.WriteLine("После изменения" +
                                      " координат:");
                    Console.WriteLine(line1);
                    Console.WriteLine(line2);
                    Console.WriteLine(line3);

                    // Пункт 5
                    line1.Start = new Point(100, 100);

                    Console.WriteLine();
                    Console.WriteLine("После замены начала " +
                                      "1 линии:");
                    Console.WriteLine(line1);
                    Console.WriteLine(line3);

                    break;
                }

                case 3:
                {
                    // Задание 3

                    // Пункт 1
                    Student vasya = new Student("Вася");
                    vasya.Grades = new int[] { 3, 4, 5 };

                    // Пункт 2
                    Student petya = new Student("Петя");
                    petya.Grades = vasya.Grades;

                    // Пункт 3
                    petya.Grades[0] = 5;

                    Console.WriteLine("Вася: " + vasya);
                    Console.WriteLine("Петя: " + petya);

                    // Пункт 4
                    Student andrey = new Student("Андрей");
                    andrey.Grades = (int[])vasya.Grades.Clone();

                    vasya.Grades[0] = 3;

                    Console.WriteLine();
                    Console.WriteLine("После изменения" +
                                      " оценки Васи:");
                    Console.WriteLine("Вася: " + vasya);
                    Console.WriteLine("Петя: " + petya);
                    Console.WriteLine("Андрей: " + andrey);

                    break;
                }

                
                case 4:
                {
                    // Задание 4

                    // Пункт 1
                    Point point1 = new Point(3, 5);
                    Point point2 = new Point(25, 6);
                    Point point3 = new Point(7, 8);

                    Console.WriteLine("Созданные точки:");
                    Console.WriteLine(point1);
                    Console.WriteLine(point2);
                    Console.WriteLine(point3);

                    // Пункт 2
                    Line line1 = new Line(1, 3,
                        23, 8);
                    
                    Line line2 = new Line(5, 10, 
                        25, 10);
                    
                    Line line3 = new Line(line1.Start,
                        line2.End);

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

                    Line line = new Line(1, 1,
                        10, 15);

                    Console.WriteLine("Длина линии: " + 
                                      line.Length());

                    break;
                }


                default:
                    Console.WriteLine("Такого задания нет.");
                    break;
            }
        }
    }
}
