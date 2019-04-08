using System;

namespace BaseNamespace.SubNamespace1
{
    public class MyClass : IMyInterface { }

    public static class MyClassAbstractionExtensions
    {
        public static IMyInterface Abstract(this MyClass myClass)
        {
            Console.WriteLine($"{nameof(Abstract)}({nameof(MyClass)})");
            return myClass;
        }
    }
}
