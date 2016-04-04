using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class HashMap
    {
        //Make a prime value to use in the hash Functio, and as the size of the array
        private const int PRIMEVALUE = 97;
        // Define a few arrays. one for keys, one for values
        int[] theKeys;
        string[] theValues;

        // constructor
        public HashMap()
        {
            theKeys = new int[PRIMEVALUE];
            theValues = new string[PRIMEVALUE];
        }

        public override string ToString()
        {
            string returnString = "Key:  ";
            returnString += "----------------------------";

            for (int i = 0; i < theKeys.Length; i++)
            {
                if (theKeys[i] != 0)
                {
                    returnString += theKeys[i] + " => " + theValues[i] + "\n";
                }
            }
            return returnString;
        }

        public string ShowArrays()
        {
            string returnString = "Index - key => Value \n";
            returnString += "--------------------";
            for (int i = 0; i < theKeys.Length; i++)
            {
                returnString += "[" + i + "] -" + theKeys[i] + " => " + theValues[i] + "\n";
            }
            return returnString;
        }

        public void Put(int key, string value)
        {
            // Get the index to use for storing the info from the hash funtion
            int indexForValue = hashFuntion(key);
            // Use the index to put the key and value int the assorted array
            theKeys[indexForValue] = key;
            theValues[indexForValue] = value;
        }

        public string Get(int key)
        {
            // get the index to use for looking up the value
            int indexForValues = hashFuntion(key);
            // return the information at the array location of indexforValues
            return theValues[indexForValues];

        }


        // Hash function to take in a key and map it to a smaller number space that is between
        // 0 and PRIMEVALUE.  this is acomplisehd by the mod function
        private int hashFuntion(int key)
        {
            return key % PRIMEVALUE;
        }
    }
}
