using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_NatashaOstrander
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab 08 - # 2 Array containing the months
            //Initialize the array with the month names
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int x;
            //Output the month's name to the console
            for (x = 0; x < 12; x++)
            {
                Console.WriteLine("{0} {1}",x,months[x]);
            }

            //Lab 08 - # 3 Array containing the 4 seasons
            //Initialize the array with the season names
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            //Output the season's name to the console
            foreach (string value in seasons)
            {
                Console.WriteLine("{0}", value);
            }

        }
    }
}
