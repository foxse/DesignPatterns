using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteProduct2 : IProduct<string, object>
    {
        public string Operation(object param)
        {
            return "{Result of ConcreteProduct2} (param is Object)";
        }
    }
}
