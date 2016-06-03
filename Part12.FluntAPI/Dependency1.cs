
namespace Part12.FluntAPI
{
    public class Dependency1 : IDependency1
    {
        public object SomeObject { get; set; }

        public override string ToString()
        {
            return SomeObject.ToString();
        }
    }
}
