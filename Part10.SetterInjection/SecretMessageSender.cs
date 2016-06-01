using System;

namespace Part10.SetterInjection
{
    public class SecretMessageSender
    {
        private readonly IEncoder _encoder;
        private readonly string _from;

        public IMessageFormatter Formatter { get; set; } = new DefaultFormatter();  //设置默认值，可被DI取代

        public SecretMessageSender(string from, IEncoder encoder)
        {
            _from = from;
            _encoder = encoder;
        }

        public void SendMessage(string to, string body)
        {
            string encodedBody = _encoder.Encode(body);
            Console.WriteLine(Formatter.FormatMessage(_from, to, encodedBody));
        }
    }
}
