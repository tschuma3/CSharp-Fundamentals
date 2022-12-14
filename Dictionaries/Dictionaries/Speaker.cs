using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    /// <summary>
    /// Speaks a message
    /// </summary>
    static class Speaker
    {
        // add whatever fields you need here
        /*static IList<MessageName> list = new List<MessageName>();*/

        static string one = "Hi there, n00b";
        static string two = "See Ya!";
        static string three = "Wow, I can't believe it";

        static Dictionary<MessageName, string> messageName = new Dictionary<MessageName, string>();

        /// <summary>
        /// Initializes the speaker
        /// </summary>
        public static void Initialize()
        {
            // initialize the speaker here
            /*list.Add (MessageName.Bye);
            list.Add(MessageName.GG);
            list.Add(MessageName.Hi);*/
            
            messageName.Add(MessageName.Hi, one);
            messageName.Add(MessageName.Bye, two);
            messageName.Add(MessageName.GG, three);
        }

        /// <summary>
        /// Prints the message with the given name
        /// </summary>
        /// <param name="name">message name</param>
        public static void Speak(MessageName name)
        {
            // print message
            /*if (name.ToString().Equals("Bye"))
            {
                Console.WriteLine(two);
            }
            else if (name.ToString().Equals("Hi"))
            {
                Console.WriteLine(one);
            }
            else
            {
                Console.WriteLine(three);
            }*/

            Console.WriteLine(messageName[name]);
        }
    }
}

