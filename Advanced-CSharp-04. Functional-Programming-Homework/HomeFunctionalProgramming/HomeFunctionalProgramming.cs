using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeFunctionalProgramming
{
    class HomeFunctionalProgramming
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Ivanov", 21, "1230014", "0288887", "pesho@abv.bg",
                    new List<int>() {2, 2}, 1, "Shalala"),
                new Student("Gosho", "Dimov", 25, "1247000", "03592584523", "gosho@abv.bg",
                    new List<int>() {6, 2, 2}, 2, "Heiii"),
                new Student("Tedi", "Ivanova", 28, "8516414", "+359 2182146", "tedi@yahoo.bg",
                    new List<int>() {5, 6, 6}, 3, "Shalala"),
                new Student("Mariika", "Dimova", 21, "4115871", "0847770277", "mari@mail.bg",
                    new List<int>() {2, 4, 3}, 2, "Ieee"),
                new Student("Desi", "Sosi", 15, "8745112", "0888451001", "des@mail.bg",
                    new List<int>() {2, 2, 2}, 2, "Heiii"),
                new Student("Tedi", "Vanova", 21, "8745245", "+3592541222", "tediiv@abv.bg",
                    new List<int>() {5, 3, 5}, 1, "Ieee"),
            };

           List<StudentSpecialty> studentSpecialty = new List<StudentSpecialty>()
           {
               new StudentSpecialty("Web Developer", "1230014"),
               new StudentSpecialty("PHP Developer", "1247000"),
               new StudentSpecialty("Web Developer", "8516414"),
               new StudentSpecialty("QA Engineer", "4115871"),
               new StudentSpecialty("QA Engineer", "8745112"),
               new StudentSpecialty("PHP Developer", "8745245")
           };

            /*2. Задача*/
            var studentsByGroup =
                from student in students
                where student.GroupNumber == 2
                select new {student.FirstName, student.LastName, student.GroupNumber};

            Console.WriteLine("Problem 2:");
            PrintQuery(studentsByGroup);

            /*3. Задача*/
            var studentsByFirstBeforeLastName =
                from student in students
                where char.Parse(student.FirstName.Substring(0, 1)) < char.Parse(student.LastName.Substring(0, 1))
                select new {student.FirstName, student.LastName};

            Console.WriteLine("Problem 3:");
            PrintQuery(studentsByFirstBeforeLastName);

            /*4. Задача*/
            var studentsByAge =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select new {student.FirstName, student.LastName, student.Age};

            Console.WriteLine("Problem 4:");
            PrintQuery(studentsByAge);


            /*5. Задача*/
            var sortStudents = students
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName)
                .Select(student => new {student.FirstName, student.LastName});

            var sortStudent =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select new {student.FirstName, student.LastName};

            Console.WriteLine("Problem 5:");
            Console.WriteLine("Lambda expressions ");
            PrintQuery(sortStudents);
            Console.WriteLine("LINQ query syntax");
            PrintQuery(sortStudent);

            /*6. Задача*/
            var filterStudentsByEmailDomain = students
                .Where(student => student.Email.Contains("@abv.bg"))
                .Select(student => new {student.FirstName, student.LastName, student.Email});

            Console.WriteLine("Problem 6:");
            PrintQuery(filterStudentsByEmailDomain);

            /*7. Задача*/
            var filterStudentsByPhone = students
                .Where(student => student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") ||
                                  student.Phone.StartsWith("+359 2"))
                .Select(student => new {student.FirstName, student.LastName, student.Phone});

            Console.WriteLine("Problem 7:");
            PrintQuery(filterStudentsByPhone);

            /*8. Задача*/
            var excellentStudents = students
                .Where(student => student.Marks.Any(mark => mark == 6))
                .Select(student => new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Mark = string.Join(" ", student.Marks)
                });


            Console.WriteLine("Problem 8:");
            PrintQuery(excellentStudents);

            /*9. Задача*/
            var weakStudents = students
                .Where(student => student.Marks.Count(mark => mark == 2) == 2)
                .Select(student => new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Mark = string.Join(" ", student.Marks)
                });


            Console.WriteLine("Problem 9:");
            PrintQuery(weakStudents);

            /*10. Задача*/
            var studentsEnrolled = students
                .Where(student => student.FacultyNumber.EndsWith("14"))
                .Select(student => new {FullName = student.FirstName + " " + student.LastName, student.FacultyNumber});

            Console.WriteLine("Problem 10:");
            PrintQuery(studentsEnrolled);


            /*11. Задача*/
            var studentsByGroups =
                from student in students
                group new {Name = student.FirstName + " " + student.LastName} by student.GroupName
                into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            Console.WriteLine("Problem 11:");
            foreach (var groups in studentsByGroups)
            {
                Console.WriteLine("Group name: {0}", groups.Key);
                PrintQuery(groups);
            }

            /*12. Задача*/
            var studentsJoinedtoSpecialties =
                from student in students
                join studentSpecial in studentSpecialty on student.FacultyNumber equals studentSpecial.FacultyNumber
                orderby student.FirstName
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    student.FacultyNumber, studentSpecial.SpecialtyName
                };


            Console.WriteLine("Problem 12:");
            PrintQuery(studentsJoinedtoSpecialties);
        }

        public static void PrintQuery(IEnumerable collection)
        {
            foreach (var student in collection)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }
    }
}
