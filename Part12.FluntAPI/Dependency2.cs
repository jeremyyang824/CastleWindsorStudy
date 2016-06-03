
namespace Part12.FluntAPI
{
    public class Dependency2 : IDependency2
    {
        public object SomeOtherObject { get; set; }

        public override string ToString()
        {
            return SomeOtherObject.ToString();
        }
    }
}
