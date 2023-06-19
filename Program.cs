namespace QLSV0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login("admin", "password");

            bool isAuthenticated = login.Authenticate();

            if (isAuthenticated)
            {

            }
            else
            {

                Console.WriteLine("Exiting...");
            }

            Console.ReadLine();
            List<Student> students = new List<Student>();
            List<Subject> subjects = new List<Subject>();
            List<Teacher> teachers = new List<Teacher>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("------- School Management System -------");
                Console.WriteLine("1. Student Management");
                Console.WriteLine("2. School Information");
                Console.WriteLine("3. Subject Management");
                Console.WriteLine("4. Teacher Management");
                Console.WriteLine("5. Exit");
                Console.WriteLine("----------------------------------------");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StudentManagement(students);
                        break;
                    case "2":
                        SchoolInformation();
                        break;
                    case "3":
                        SubjectManagement(subjects);
                        break;
                    case "4":
                        TeacherManagement(teachers);
                        break;
                        
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void TeacherManagement(List<Teacher> teachers)
        {
            bool backToMain = false;
            while (!backToMain)
            {
                Console.WriteLine("------- Teacher Management -------");
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Update Teacher");
                Console.WriteLine("3. Print All Teachers");
                Console.WriteLine("4. Back to Main Menu");
                Console.WriteLine("----------------------------------");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTeacher(teachers);
                        break;
                    case "2":
                        UpdateTeacher(teachers);
                        break;
                    case "3":
                        PrintAllTeachers(teachers);
                        break;
                    case "4":
                        backToMain = true;
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("--- Add Teacher ---");
            Console.Write("Enter Teacher ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Teacher Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Teacher Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Teacher teacher = new Teacher(id, name, age);
            teachers.Add(teacher);

            Console.WriteLine("Teacher added successfully.");
        }

        static void UpdateTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("--- Update Teacher ---");
            Console.Write("Enter Teacher ID: ");
            string id = Console.ReadLine();

            Teacher teacher = teachers.Find(t => t.TeacherID == id);
            if (teacher == null)
            {
                Console.WriteLine("Teacher not found.");
                return;
            }

            Console.WriteLine("Teacher found. Enter new information:");

            Console.Write("Enter Teacher Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Teacher Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            teacher.Name = name;
            teacher.Age = age;

            Console.WriteLine("Teacher updated successfully.");
        }

        static void PrintAllTeachers(List<Teacher> teachers)
        {
            Console.WriteLine("--- All Teachers ---");
            if (teachers.Count == 0)
            {
                Console.WriteLine("No teachers found.");
                return;
            }

            foreach (Teacher teacher in teachers)
            {
                teacher.PrintInfo();
                Console.WriteLine();
            }
        }

        static void StudentManagement(List<Student> students)
        {
            bool backToMain = false;
            while (!backToMain)
            {
                Console.WriteLine("------- Student Management -------");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Print All Students");
                Console.WriteLine("5. Back to Main Menu");
                Console.WriteLine("----------------------------------");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(students);
                        break;
                    case "2":
                        RemoveStudent(students);
                        break;
                    case "3":
                        SearchStudent(students);
                        break;
                    case "4":
                        PrintAllStudents(students);
                        break;
                    case "5":
                        backToMain = true;
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddStudent(List<Student> students)
        {
            Console.WriteLine("--- Add Student ---");
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Student student = new Student(id, name);
            students.Add(student);

            Console.WriteLine("Student added successfully.");
        }

        static void RemoveStudent(List<Student> students)
        {
            Console.WriteLine("--- Remove Student ---");
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();

            Student student = students.Find(s => s.ID == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void SearchStudent(List<Student> students)
        {
            Console.WriteLine("--- Search Student ---");
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();

            Student student = students.Find(s => s.ID == id);
            if (student != null)
            {
                Console.WriteLine("Student found:");
                Console.WriteLine("ID: " + student.ID);
                Console.WriteLine("Name: " + student.Name);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void PrintAllStudents(List<Student> students)
        {
            Console.WriteLine("--- All Students ---");
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
            }
            else
            {
                foreach (Student student in students)
                {
                    Console.WriteLine("ID: " + student.ID);
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine();
                }
            }
        }

        static void SchoolInformation()
        {
            Console.WriteLine("--- School Information ---");
            Console.Write("Enter School Name: ");
            string schoolName = Console.ReadLine();
            Console.WriteLine("School Name: " + schoolName);
        }

        static void SubjectManagement(List<Subject> subjects)
        {
            bool backToMain = false;
            while (!backToMain)
            {
                Console.WriteLine("------- Subject Management -------");
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Remove Subject");
                Console.WriteLine("3. Search Subject");
                Console.WriteLine("4. Print All Subjects");
                Console.WriteLine("5. Back to Main Menu");
                Console.WriteLine("---------------------------------");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddSubject(subjects);
                        break;
                    case "2":
                        RemoveSubject(subjects);
                        break;
                    case "3":
                        SearchSubject(subjects);
                        break;
                    case "4":
                        PrintAllSubjects(subjects);
                        break;
                    case "5":
                        backToMain = true;
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddSubject(List<Subject> subjects)
        {
            Console.WriteLine("--- Add Subject ---");
            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Subject Name: ");
            string name = Console.ReadLine();

            Subject subject = new Subject(code, name);
            subjects.Add(subject);

            Console.WriteLine("Subject added successfully.");
        }

        static void RemoveSubject(List<Subject> subjects)
        {
            Console.WriteLine("--- Remove Subject ---");
            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();

            Subject subject = subjects.Find(s => s.Code == code);
            if (subject != null)
            {
                subjects.Remove(subject);
                Console.WriteLine("Subject removed successfully.");
            }
            else
            {
                Console.WriteLine("Subject not found.");
            }
        }

        static void SearchSubject(List<Subject> subjects)
        {
            Console.WriteLine("--- Search Subject ---");
            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();

            Subject subject = subjects.Find(s => s.Code == code);
            if (subject != null)
            {
                Console.WriteLine("Subject found:");
                Console.WriteLine("Code: " + subject.Code);
                Console.WriteLine("Name: " + subject.Name);
            }
            else
            {
                Console.WriteLine("Subject not found.");
            }
        }

        static void PrintAllSubjects(List<Subject> subjects)
        {
            Console.WriteLine("--- All Subjects ---");
            if (subjects.Count == 0)
            {
                Console.WriteLine("No subjects found.");
            }
            else
            {
                foreach (Subject subject in subjects)
                {
                    Console.WriteLine("Code: " + subject.Code);
                    Console.WriteLine("Name: " + subject.Name);
                    Console.WriteLine();
                }
            }

           
        }
    }
}
    

