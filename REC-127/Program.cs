using System;

namespace REC_127
{

    class Program
    {
        static string Encryption(string originalString)
        {
            String result;
            Char[] encryptionWords = originalString.ToCharArray();
            for (int i = 0; i < encryptionWords.Length; i++)
            {
                encryptionWords[i] = Convert.ToChar((int)encryptionWords[i] + 1);
            }
            result = string.Join("",encryptionWords);
            return result;
        }
        static string Decryption(string originalString)
        {
            String result;
            Char[] decryptionWords = originalString.ToCharArray();
            for (int i = 0; i < decryptionWords.Length; i++)
            {
                decryptionWords[i] = Convert.ToChar((int)decryptionWords[i] - 1);
            }
            result = string.Join("", decryptionWords);
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку для шифрования: ");
            string originalString = Console.ReadLine();
            Console.WriteLine(Encryption(originalString));
            Console.WriteLine(Decryption(Encryption(originalString)));
            Console.ReadKey();
        }
    }
}
