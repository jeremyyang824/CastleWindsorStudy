
namespace Part09.ConstructorInjection
{
    public class SillyEncoder : IEncoder
    {
        private readonly char[] _mixedUp = "YACBDFEGIHJLKMONPRSQTUWVXZ".ToCharArray();

        public string Encode(string source)
        {
            string upperSource = source.ToUpper();
            char[] encoded = new char[source.Length];
            for (int i = 0; i < encoded.Length; i++)
            {
                encoded[i] = MapCharacter(upperSource[i]);
            }
            return new string(encoded);
        }

        private char MapCharacter(char ch)
        {
            if ((ch >= 'A') && (ch <= 'Z'))
            {
                return _mixedUp[ch - 'A'];
            }
            return ch;
        }
    }
}
