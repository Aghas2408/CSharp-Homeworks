using System;

namespace Lesson5.Exercise
{
    /// <summary>
    /// The Lesson model
    /// </summary>
    public class Lesson
    {
        /// <summary>
        /// Create a lesson instance
        /// </summary>
        /// <param name="name">The lesson name</param>
        /// <param name="startDate">The lesson start date</param>
        public Lesson(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Create a lesson instance
        /// </summary>
        /// <param name="name">The lesson name</param>
        /// <param name="startDate">The lesson start date</param>
        public Lesson(string name, DateTime startDate, DateTime endDate) : this(name)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// The start date of the lesson
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// The end date of the lesson
        /// </summary>
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// The lesson name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Set start and end dates of lesson
        /// </summary>
        /// <param name="startDate">Start date</param>
        /// <param name="endDate">End date</param>
        public void SetDate(DateTime startDate, DateTime endDate)
        {
            if (startDate < DateTime.Now)
            {
                Console.WriteLine("The start date is invalid!");
                return;
            }

            this.StartDate = startDate;

            if (endDate < startDate)
            {
                Console.WriteLine("The end date is invalid!");
                return;
            }

            this.EndDate = endDate;
        }
    }
}