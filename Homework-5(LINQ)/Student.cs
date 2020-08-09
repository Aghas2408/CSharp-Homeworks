using System;

namespace Lesson5.Exercise
{
    /// <summary>
    /// The Student model
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Student id
        /// </summary>
        private Guid _id;
        private int age ;
        /// <summary>
        /// Init the student
        /// </summary>
        /// <param name="name">The student name</param>
        /// <param name="surname">The student surname</param>
        public Student(string name, string surname, int age)
            : base(name, surname)
        {
            _id = Guid.NewGuid();
            this.age = age;
        }

        public Guid Id { get { return this._id; } }

        public int Age { get { return this.age; } }
    }
}
