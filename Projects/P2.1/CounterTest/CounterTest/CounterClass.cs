using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class CounterClass
    {
        private int _count;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Value
        {
            get
            {
                return _count;
            }
        }

        public CounterClass(string name)
        {
            _name = name;
            _count = 0;
        }

        public int Increment()
        {
            return _count += 1;
        }

        public int Reset()
        {
            return _count = 0;
        }
    }
}