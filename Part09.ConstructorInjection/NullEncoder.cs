
namespace Part09.ConstructorInjection
{
    public class NullEncoder : IEncoder
    {
        public string Encode(string source)
        {
            return source;
        }
    }
}
