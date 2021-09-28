using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMidSemeter
{
    class Program
    ///----Dor Ben Dor -----///
    ///         Oop     //////
    ///Dor Ben Haim Amit Vaknin ///
    ///    28/9/21       /////
    {
        static void Main(string[] args)
        {

            TreeBuilder tb = new TreeBuilder(5, 2);

            foreach (var item in tb.tree)
            {
                Console.WriteLine(item.Value.Name);
            }
            Console.ReadLine();
        }
    }
}
