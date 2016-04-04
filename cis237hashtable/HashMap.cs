using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class HashMap
    {
        //make a prime value to use in the hash function and as the size of the array
        private const int PRIME_VALUE = 97;
        //define a couple arrays
        int[] theKeys;
        string[] theValues;

        //constructor
        public HashMap()
        {
            theKeys = new int[PRIME_VALUE];
            theValues = new string[PRIME_VALUE];


        }

        public override string ToString()
        {
            string returnString = "Key => Value\n";
            returnString += "------------\n";
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
            string returnString = "Idx - Key => Value\n";
            returnString += "------------------\n";
            for (int i = 0; i < theKeys.Length; i++)
            {
                returnString += "[" + i + "] - " + theKeys[i] + " => " + theValues[i] + "\n";
            }
            return returnString;
        }

        public void Put(int Key, string Value)
        {
            //get the index to use for storing the info from the hash function
            int indexForValue = hashFunction(Key);

            //use the index to put the key and value into the assoicated array
            theKeys[indexForValue] = Key;
            theValues[indexForValue] = Value;
        }

        public string Get(int Key)
        {
            //get the index to use for looking up the value
            int indexForValue = hashFunction(Key);

            //return the information at the array location of indexforvalues
            return theValues[indexForValue];
        }

        //hash function to take in a key and map it to a smaller number space that is between 0 and prime value.
        //this is accomplished by the % mod function
        private int hashFunction(int key)
        {
            return key % PRIME_VALUE;
        }
    }
}
