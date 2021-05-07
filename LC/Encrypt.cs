namespace LC
{
    using System.Security.Cryptography;
    using System.IO;
    using System.Text;
    using System;

    public class Encrypter
    {
        private static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("cxKJ98&%");

        public static string _0036(string stringToHash)
        {
            byte[] result;
            string HashString;

            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            char[] cctx = stringToHash.ToCharArray();
            byte[] bctx = System.Text.UTF8Encoding.UTF8.GetBytes(cctx);

            result = md5.ComputeHash(bctx);
            System.Text.StringBuilder output = new System.Text.StringBuilder(2 + (result.Length * 2));

            foreach (byte b in result)
            {
                output.Append(b.ToString("x2"));
            }
            HashString = output.ToString().ToUpper();
            return HashString;
        }

        public static string _0034(string originalString)
        {
            if (String.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException("The string which needs to be encrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        public static string _0035(string cryptedString)
        {
            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException("The string which needs to be decrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }
    }
}