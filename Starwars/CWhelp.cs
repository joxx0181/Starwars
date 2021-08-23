using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars
{
    public  static class CWhelp
    {
        // Method!
        public static void sendToConsole(this IEnumerable<Planet> assignmentList)
        {
            // Using foreach loop to query execution!
            foreach (Planet assignment in assignmentList)
            {
                Console.WriteLine(assignment.Name);
            }

            Console.WriteLine("======================");
        }
    }
}
