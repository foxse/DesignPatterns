using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteCreator2 : Creator
    {
        // Обратите внимание, что сигнатура метода по-прежнему использует тип
        // абстрактного продукта, хотя  фактически из метода возвращается
        // конкретный продукт. Таким образом, Создатель может оставаться
        // независимым от конкретных классов продуктов.
        public override IProduct<string, object> FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
