using System.Collections.Generic;

namespace AspCore.Web.Models
{
    public static class Repository
    {
        private static List<Student> students = new List<Student>();

        public static List<Student> Students
        {
            get
            {
                return students;
            }
        }

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
