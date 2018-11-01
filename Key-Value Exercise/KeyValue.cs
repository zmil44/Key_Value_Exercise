using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Exercise
{
    struct KeyValue<T>
    {
        public string Key { get; }
        public T Value { get; }
        public KeyValue(string Key, T Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
