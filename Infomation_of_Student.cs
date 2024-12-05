using System;

namespace DSA_Project___Dev_Mode
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Student(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ID} - {Name}";
        }
    }
}
