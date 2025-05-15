#nullable disable

namespace _31.CustomEventForReloading
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Age { get; set; }
    }

    internal class Program
    {
        int age = 0;








        // Declare the Delegate.
        public delegate void ReloadData();

        // Declare the event.
        public event ReloadData ReloadDataEvent;

        List<Student> students;

        void Main(string[] args)
        {
            ReloadDataEvent += FillData;
            ReloadDataEvent.Invoke();

            Console.WriteLine("Hello, World!");
        }


        public void FillData()
        {
            students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Parham", Age = 12 });
            students.Add(new Student { Id = 2, Name = "Parsa", Age = 35 });
        }
    }
}
