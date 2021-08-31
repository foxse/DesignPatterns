using System;

namespace FactoryMethod
{
    // Интерфейс Продукта объявляет операции, которые должны выполнять все
    // конкретные продукты.
    public interface IProduct<out T, in U>
    {
        T Operation(U param);
    }
}
