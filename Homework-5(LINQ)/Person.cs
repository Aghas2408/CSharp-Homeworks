namespace Lesson5.Exercise
{
    /// <summary>
    /// The Person model
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Init the person
        /// </summary>
        /// <param name="name">The person name</param>
        /// <param name="surname">The person surname</param>
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        /// <summary>
        /// The person name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The person surname
        /// </summary>
        public string Surname { get; private set; }
    }
}
