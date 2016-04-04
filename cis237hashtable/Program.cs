using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dictionary<int, string> valleyNumToName = nw Dictionary<int, string>;

            // Now to use te Hash Map

            HashMap valleyNumToName = new HashMap();

            Console.SetBufferSize(80, 1200);

            Console.WriteLine("Adding some entres to the hash");
            Console.WriteLine("Ex: Valley NumtoName.Put(12345, \"Mario Kart\" ");
            valleyNumToName.Put(12345, "Mike Jones");
            // add more names here

            Console.WriteLine("the created Hash Table behold! \n");
            Console.WriteLine(valleyNumToName.ToString());

            Console.WriteLine("The full arrays as they got filled out");
            Console.WriteLine(valleyNumToName.ShowArrays());

            Console.WriteLine();



            Console.WriteLine(" Get a single value out of the hash table by passing in the key");
            Console.WriteLine("valleyNumToName.Get(12345)");
            Console.WriteLine(valleyNumToName.Get(12345));

            Console.WriteLine("\n Press enter to continue");
            Console.ReadLine();


            Console.WriteLine("\n What is we add 2 entries to the hash table that map to the same location o_O?");
            Console.WriteLine("valleyNumToName.Put(26189, \"First Entry\" ))");
            valleyNumToName.Put(26189, "Luigi Mansion");
            Console.WriteLine("valleyNumToName.Put(25698,\"Peach Kart\")");
            valleyNumToName.Put(25698, "Peach Kart");

            Console.WriteLine("repritnting");
            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine(valleyNumToName.ShowArrays());

        }
    }
}
