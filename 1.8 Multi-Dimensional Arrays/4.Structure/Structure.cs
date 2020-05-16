using System;

class Structure
{
    public struct Student
    {
        public int Id;
        public string Name;
        public int Age;
        public int Score;
        public string Gender;

        public Student(int id, string name, int age, int score, string gender)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Score = score;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return "Id: " + this.Id + "    Name: " + this.Name +
                "   Age: " + this.Age + "   Score: " + this.Score + "   Gender: " + this.Gender;
        }
    }

    static void Main()
    {
        Student temp = new Student();
        Student[] students = {
            new Student(1,"ivan",22,10,"m"),
            new Student(5,"mariq",10,59,"f"),
            new Student(8,"neli",40,100,"f"),
            new Student(4,"boris",55,40,"m"),
            new Student(3,"nikolai",34,87,"m"),
            new Student(6,"iveta",17,45,"f"),
            new Student(7,"dimityr",4,9,"m"),
            new Student(2,"svetlio",22,99,"m"),
            new Student(9,"cvetelina",22,100,"f"),
            new Student(10,"nikolai",30,79,"m"),
        };

        Console.WriteLine("The array of students:");
        PrintStudents(students);

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (students[i].Id > students[j].Id)
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        Console.WriteLine("The array of students by Id:");
        PrintStudents(students);

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (students[i].Name.CompareTo(students[j].Name) > 0)
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        Console.WriteLine("The array of students by Name:");
        PrintStudents(students);

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (Reverse(students[i].Name).CompareTo(Reverse(students[j].Name)) > 0)
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        Console.WriteLine("The array of students by Name(reverse):");
        PrintStudents(students);

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (students[i].Age > students[j].Age)
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        Console.WriteLine("The array of students by Age:");
        PrintStudents(students);

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (students[i].Score < students[j].Score)
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        Console.WriteLine("The array of students by Score:");
        PrintStudents(students);

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (students[i].Name.Length > students[j].Name.Length)
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        Console.WriteLine("The array of students by Name Length:");
        PrintStudents(students);

        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if (students[i].Gender.CompareTo(students[j].Gender) > 0)
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = i + 1; j < students.Length; j++)
            {
                if ((students[i].Name.CompareTo(students[j].Name) > 0) && 
                    (students[i].Gender.CompareTo(students[j].Gender) == 0))
                {
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
        Console.WriteLine("The array of students by Name and gender:");
        PrintStudents(students);

        Console.Read();
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private static void PrintStudents(Student[] students)
    {
        Console.WriteLine(new string('-', 50));
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine(new string('-', 50));
    }
}

