using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        School school1 = new School();
        school1._name = "Brigham Young University Idaho";
        school1._numStudents = 25000;
        school1._numTeachers = 1000;

        Student student1 = new Student();
        student1._name = "Bill Alexander";
        school1._students = new List<Student>();
        school1._students.Add(student1);

        school1.ShowDetails();

        School school2 = new School();
        school2._name = "Brigham Young University";
        school2._numStudents = 45000;
        school2._numTeachers = 2000;
        school2.ShowDetails();
    }
}