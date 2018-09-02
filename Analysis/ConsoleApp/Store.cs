using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Store<T> where T : struct
    {
        T[] _values;
        uint _counter;
        public Store(uint length)
        {
            _values = new T[length];
        }

        public T[] AddValue(T newValue)
        {
            _counter++;
            if (_counter > _values.Length)
            {
                var i = 0;
                while (i < (_values.Length - 1))
                {
                    _values[i] = _values[i + 1];
                    i++;
                }
                _values[i] = newValue;
            }
            else
            {
                _values[_counter-1] = newValue;
            }
            return _values;
        }

        
    }
}
