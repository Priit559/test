using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Andmed õpilaste ja kursuste kohta
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Saima", CourseId = 101 },
            new Student { StudentId = 2, Name = "Toomas", CourseId = 102 },
            new Student { StudentId = 3, Name = "Sille", CourseId = 101 },
            new Student { StudentId = 4, Name = "John", CourseId = 103 },
            new Student { StudentId = 5, Name = "Eve", CourseId = 102 },
            new Student { StudentId = 6, Name = "Allar", CourseId = 101 },
            new Student { StudentId = 7, Name = "Vitaali", CourseId = 103 },
            new Student { StudentId = 8, Name = "Koit", CourseId = 102 },
            new Student { StudentId = 9, Name = "Siim", CourseId = 101 },
            new Student { StudentId = 10, Name = "Reelika", CourseId = 103 }
        };

        List<Course> courses = new List<Course>
        {
            new Course { CourseId = 101, CourseName = "Matemaatika" },
            new Course { CourseId = 102, CourseName = "Füüsika" },
            new Course { CourseId = 103, CourseName = "Keemia" }
        };

        // LINQ päring, mis teeb GroupJoin õpilaste ja kursuste vahel
        var result = courses.GroupJoin(
            students, // Sisendandmed õpilaste kohta
            course => course.CourseId, // Võti kursuste jaoks
            student => student.CourseId, // Võti õpilaste jaoks
            (course, studentGroup) => new // Tulemuse avaldamine
            {
                CourseName = course.CourseName,
                Students = studentGroup.Take(5) // Võtab iga kursuse kohta esimesed 5 õpilast
            });

        // Tulemuste väljastamine
        foreach (var item in result)
        {
            Console.WriteLine($"Course: {item.CourseName}");
            foreach (var student in item.Students)
            {
                Console.WriteLine($"  Student: {student.Name}");
            }
        }
    }
}