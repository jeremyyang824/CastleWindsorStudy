using System;

namespace Part09.ConstructorInjection
{
    public class SecretMessageSender
    {
        private readonly IEncoder _encoder;
        private readonly string _from;

        public SecretMessageSender(string from, IEncoder encoder)
        {
            _from = from;
            _encoder = encoder;
        }

        public void SendMessage(string to, string body)
        {
            Console.WriteLine("to: {0}\r\nfrom: {1}\r\n\r\n{2}", to, _from, _encoder.Encode(body));
        }
    }
}
