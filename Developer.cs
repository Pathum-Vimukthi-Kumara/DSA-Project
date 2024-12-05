using System;

namespace DSA_Project___Dev_Mode
{
    public class Developer
    {
        private LinkedList students;

        public Developer()
        {
            students = new LinkedList();
        }

        public void AddStudent(string id, string name)
        {
            var student = new Student(id, name);
            students.AddLast(student);
            Console.WriteLine($"Student {name} with ID {id} added successfully.");
        }

        public void RemoveStudent(string id)
        {
            var studentNode = students.Search(id);
            if (studentNode != null)
            {
                students.Remove(studentNode.Data);
                Console.WriteLine($"Student with ID {id} removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DisplayStudents()
        {
            students.Display();
        }

        public static void Start_dev()
        {
            var studentManager = new Developer();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Remove Student");
                Console.WriteLine("3. Display Students");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        studentManager.AddStudent(id, name);
                        break;

                    case 2:
                        Console.Write("Enter student ID to remove: ");
                        string removeId = Console.ReadLine();
                        studentManager.RemoveStudent(removeId);
                        break;

                    case 3:
                        studentManager.DisplayStudents();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
