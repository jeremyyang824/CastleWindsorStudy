
namespace Part10.SetterInjection
{
    public class NullEncoder : IEncoder
    {
        public string Encode(string source)
        {
            return source;
        }
    }
}
