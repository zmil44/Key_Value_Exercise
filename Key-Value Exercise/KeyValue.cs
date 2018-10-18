using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Exercise
{
    struct KeyValue
    {
        public string Key { get; }
        public Object Value { get; }
        public KeyValue(string Key, Object Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
