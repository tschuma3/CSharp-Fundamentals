using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    /// <summary>
    /// Provides practice with dictionaries
    /// </summary>
    class Program
    {
        /// <summary>
        /// Has the speaker say some phrases
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // set up speaker
            Speaker.Initialize();

            // print messages
            Speaker.Speak(MessageName.Hi);
            Speaker.Speak(MessageName.Bye);
            Speaker.Speak(MessageName.GG);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
