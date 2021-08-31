using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Конкретные продукты создаются соответствующими Конкретными Фабриками.
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
