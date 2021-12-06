namespace Cipher
{
    public class CaesarCipher
    {
        public int ShiftValue { get; private set; }

        public CaesarCipher()
        {
            ShiftValue = -3;
        }

        public CaesarCipher(int shiftValue)
        {
            ShiftValue = shiftValue;
        }

        public string Encrypt(string message)
        {
            var result = Ciphers.WithStringBuilder(message, ShiftValue);
            return result;
        }

        public string Decrypt(string message)
        {
            var result = Ciphers.WithStringBuilder(message, -ShiftValue);
            return result;
        }
    }
}
