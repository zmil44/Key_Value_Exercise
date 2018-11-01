using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Exercise
{
    class MyDictionary<T>
    {
        private int Count = -1;

        private KeyValue<T>[] _keyValueArray = new KeyValue<T>[50];

        public T this[string key]
        {
            get
            {
                if(Count<0)
                {
                    throw new KeyNotFoundException();
                }
                for (int i = 0; i < _keyValueArray.Length; i++)
                {
                    if(_keyValueArray[i].Key.Equals(key))
                    {
                        return _keyValueArray[i].Value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                bool exists = false;
                for (int i = 0; i < Count; i++)
                {
                    if(_keyValueArray[i].Key.Equals(key))
                    {
                        _keyValueArray[i] = new KeyValue<T>(key, _keyValueArray[i].Value);
                        exists = true;
                    }
                }
                if(!exists)
                {
                    _keyValueArray[Count+1] = new KeyValue<T>(key,value);
                    Count++;
                }
                
            }
        }

    }
}
