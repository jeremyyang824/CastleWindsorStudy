
namespace Part10.SetterInjection
{
    public interface IMessageFormatter
    {
        string FormatMessage(string from, string to, string body);
    }
}
