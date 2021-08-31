using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Конкретные Продукты предоставляют различные реализации интерфейса
    // Продукта.
    class ConcreteProduct1 : IProduct<object, string>
    {
        public object Operation(string t)
        {
            return $"{{Result of ConcreteProduct1}} param is string: \"{t}\"";
        }
    }
}
