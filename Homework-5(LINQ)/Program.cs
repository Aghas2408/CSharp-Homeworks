using System;

namespace Lesson5
{
    /// <summary>
    /// The start of the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point
        /// </summary>
        /// <param name="args">The run arguments</param>
        static void Main(string[] args)
        {
            // create host
            var host = new ConsoleHost();

            // run
            host.Run();
        }
    }
}
