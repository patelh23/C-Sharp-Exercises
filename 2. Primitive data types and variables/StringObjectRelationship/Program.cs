using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringObjectRelationship
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declare two variables of type string with values "Hello" and "World".
            Declare a variable of type object.Assign the value obtained of
            concatenation of the two string variables(add space if necessary) to this
            variable.Print the variable of type object.*/

            string first = "Hello";
            string second = "World";
            object together = first + " " + second;
            Console.WriteLine(together);
            //Objects can be printed. 

            /*Declare two variables of type string and give them values "Hello" and
            "World". Assign the value obtained by the concatenation of the two
            variables of type string (do not miss the space in the middle) to a
            variable of type object. Declare a third variable of type string and
            initialize it with the value of the variable of type object (you should use
            type casting).*/

            string combine = (string)together;
            Console.WriteLine(combine);

        }
}
}
