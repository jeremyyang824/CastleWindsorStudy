
namespace Part10.SetterInjection
{
    public class DefaultFormatter : IMessageFormatter
    {
        public string FormatMessage(string from, string to, string body)
        {
            return $"to: {to}\r\nfrom: {@from}\r\n\r\n{body}";
        }
    }
}
