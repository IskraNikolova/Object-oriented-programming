namespace TestValidator
{
    using System.Collections.Generic;
    using ObjectStateValidator.Annotations;

    public class Student
    {
        public string FirstName { get; set; }

        [Mandatory]
        public string LastName { get; set; }

        [Range(0, 100)]
        public int Age { get; set; }

        [Elements(4)]
        public ICollection<int> Marks { get; set; }

        public Student Mentor { get; set; }
    }
}