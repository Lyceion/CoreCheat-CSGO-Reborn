using static System.Convert;
using static System.Text.Encoding;

namespace CoreCheat_Reborn.Classes
{
    class Base64
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = UTF8.GetBytes(plainText);
            return ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = FromBase64String(base64EncodedData);
            return UTF8.GetString(base64EncodedBytes);
        }
    }
}
