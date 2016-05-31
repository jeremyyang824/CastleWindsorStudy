
namespace Part07.SwitchingImplementations
{
    public class StaticMessageOfTheDay : IMessageOfTheDay
    {
        public string Message { private get; set; }

        public string GetMessageOfTheDay()
        {
            return Message;
        }
    }
}
