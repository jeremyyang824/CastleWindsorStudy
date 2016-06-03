
namespace Part12.FluntAPI
{
    public class Main
    {
        public IDependency1 Object1 { get; }
        public IDependency2 Object2 { get; }

        public Main(IDependency1 dependency1, IDependency2 dependency2)
        {
            Object1 = dependency1;
            Object2 = dependency2;
        }

        public void DoSomething()
        {
            Object1.SomeObject = "Hello World";
            Object2.SomeOtherObject = "Hello Mars";
        }
    }
}
