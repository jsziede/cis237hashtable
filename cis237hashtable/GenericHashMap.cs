using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class GenericHashMap<TKey, TValue>
    {
        private const int PRIME_VALUE = 97;
        TValue[] theValues;

        public GenericHashMap()
        {
            theValues = new TValue[PRIME_VALUE];
        }

        public TValue Get(TKey key)
        {
            int indexForValues = hashFunction(key);
            return theValues[indexForValues];
        }

        public void Put(TKey key, TValue value)
        {
            int indexForValues = hashFunction(key);
            theValues[indexForValues] = value;
        }

        private int hashFunction(TKey key)
        {
            return key.GetHashCode() % PRIME_VALUE;
        }
    }
}
