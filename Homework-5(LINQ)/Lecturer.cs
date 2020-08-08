namespace Lesson5.Exercise
{
    /// <summary>
    /// The Lecturer model
    /// </summary>
    public class Lecturer : Person
    {
        /// <summary>
        /// Init the lecturer
        /// </summary>
        /// <param name="name">The lecturer name</param>
        /// <param name="surname">The lecturer surname</param>
        public Lecturer(string name, string surname) 
            : base(name, surname)
        {

        }
    }
}
