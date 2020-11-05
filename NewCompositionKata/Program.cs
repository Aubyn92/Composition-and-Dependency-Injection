using System;

namespace NewCompositionKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var foobar = new Foobar();
            foobar.Print();
            
            var instanceOfFoo = new Foo();
            var instanceOfBar = new Bar();
            var foobarDi = new FoobarDi(instanceOfFoo, instanceOfBar);
            
            foobarDi.Print();
        }
    }
}