using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson5.Exercise
{
    /// <summary>
    /// The discipline model
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// The lecturers collection
        /// </summary>
        private readonly List<Lecturer> Lecturers;

        /// <summary>
        /// The students collection
        /// </summary>
        private readonly List<Student> Students;

        /// <summary>
        /// The lessons collection
        /// </summary>
        private readonly List<Lesson> Lessons;

        /// <summary>
        /// Init the discipline
        /// </summary>
        /// <param name="name"></param>
        public Discipline(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Lessons = new List<Lesson>();
            this.Lecturers = new List<Lecturer>();
        }

        /// <summary>
        /// The discipline name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Add lecturer to lecturers list
        /// </summary>
        /// <param name="lecturer"></param>
        public void AddLecturer(Lecturer lecturer)
        {
            this.Lecturers.Add(lecturer);
        }

        /// <summary>
        /// Add lecturers to lecturers list
        /// </summary>
        /// <param name="lecturers"></param>
        public void AddLecturers(List<Lecturer> lecturers)
        {
            this.Lecturers.AddRange(lecturers);
        }

        /// <summary>
        /// Add student to students list
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student)
        {
            if (this.Students.Select(s => s.Id).Contains(student.Id))
            {
                Console.WriteLine($"{student.Name} alredy exists in students list");
                return;
            }

            this.Students.Add(student);
        }

        /// <summary>
        /// Add students to students list
        /// </summary>
        /// <param name="students"></param>
        public void AddStudents(List<Student> students)
        {
            var noDuplicateStudents = students.Where(w => !this.Students.Select(s => s.Id).Contains(w.Id));

            this.Students.AddRange(noDuplicateStudents);
        }

        /// <summary>
        /// Add lesson to lesson list
        /// </summary>
        /// <param name="lesson"></param>
        public void AddLesson(Lesson lesson)
        {
            if (this.Lecturers.Count == 0)
            {
                Console.WriteLine("There are no any lecturers in discipline!");
                return;
            }

            this.Lessons.Add(lesson);
        }

        /// <summary>
        /// Add lessons to lesson list
        /// </summary>
        /// <param name="lessons"></param>
        public void AddLessons(List<Lesson> lessons)
        {
            if (this.Lecturers.Count == 0)
            {
                Console.WriteLine("There are no any lecturers in discipline!");
                return;
            }

            this.Lessons.AddRange(lessons);
        }

        /// <summary>
        /// Get Lecturers collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lecturer> GetLecturers()
        {
            return this.Lecturers;
        }

        /// <summary>
        /// Get Students collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetStudents()
        {
            return this.Students;
        }

        /// <summary>
        /// Get Lessons collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Lesson> GetLessons()
        {
            return this.Lessons;
        }
    }
}
