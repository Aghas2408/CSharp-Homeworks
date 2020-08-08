
using Lesson5.Exercise;

namespace Lesson5
{
    /// <summary>
    /// Console host model
    /// </summary>
    public class ConsoleHost
    {
        /// <summary>
        /// Run th application
        /// </summary>
        public void Run()
        {
           

            //linqExamples.Run();

            // create LINQ exercise
            var linqExercise = new LINQExercise();

            linqExercise.Run();
        }
    }
}