using System;

using BaseNamespace.SubNamespace1;

namespace BaseNamespace
{
    public interface IMyInterface { }

    public static class MyInterfaceAbstractionExtensions
    {
        public static IMyInterface Abstract(this IMyInterface myInterface)
        {
            Console.WriteLine($"{nameof(Abstract)}({nameof(IMyInterface)})");
            return (myInterface as MyClass).Abstract(); // Resolves to this method, instead of more-specific method MyClassAbstractionExtensions.Abstract()
        }
    }
}
