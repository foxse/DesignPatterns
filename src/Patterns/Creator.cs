using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class Creator
    {
        // Обратите внимание, что Создатель может также обеспечить реализацию
        // фабричного метода по умолчанию.
        public abstract IProduct<object, string> FactoryMethod();

        // Также заметьте, что, несмотря на название, основная обязанность
        // Создателя не заключается в создании продуктов. Обычно он содержит
        // некоторую базовую бизнес-логику, которая основана  на объектах
        // Продуктов, возвращаемых фабричным методом.  Подклассы могут косвенно
        // изменять эту бизнес-логику, переопределяя фабричный метод и возвращая
        // из него другой тип продукта.
        public string SomeOperation()
        {
            // Вызываем фабричный метод, чтобы получить объект-продукт.
            var product = FactoryMethod();
            // Далее, работаем с этим продуктом.
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation("R");

            return result;
        }
    }
}
