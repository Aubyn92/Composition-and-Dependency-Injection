namespace NewCompositionKata
{
    public class FoobarDi : IPrinter
    {
        private IPrinter _foo;
        private IPrinter _bar;
        
        public FoobarDi(IPrinter incomingFoo, IPrinter incomingBar)
        { 
            _foo = incomingFoo;
            _bar = incomingBar;
        }

        public void Print()
        {
            _foo.Print();
            _bar.Print();
        }
    }
}