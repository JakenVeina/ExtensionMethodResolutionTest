using BaseNamespace.SubNamespace1; // Call below does not resolve as expected

namespace BaseNamespace.SubNamespace2
{
    //using BaseNamespace.SubNamespace1; // Call below resolves as expected

    public class MyOtherClass
    {
        public IMyInterface GetMyInterface()
            => new MyClass().Abstract(); // I expect this resolve to most-specific method MyClassAbstractionExtensions.Abstract()
    }
}
