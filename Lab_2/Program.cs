using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    static class Alphabets
    {
        public static List<char> alph;
        public static List<char> alph_ukr;

    }
    public static class Gronsfeld_Cipher
    {
        public static string Code(string message, string key,List<char> alphabet)
        {
            string coded = "";
            int key_iterator = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (key_iterator >= key.Length) key_iterator = 0;
                int shift = Convert.ToInt32(key.Substring(key_iterator,1));
                int distance = alphabet.IndexOf(message[i]) - shift;
                if (distance < 0)
                {
                    distance = alphabet.Count - shift;
                }
                coded += alphabet[distance];
                key_iterator++;
            }
            return coded;
        }
        public static string Decode(string coded_message,string key,List<char> alphabet)
        {
            string decoded = "";
            int key_iterator = 0;
            for (int i = 0; i < coded_message.Length; i++)
            {
                if (key_iterator >= key.Length) key_iterator = 0;
                int shift = Convert.ToInt32(key.Substring(key_iterator, 1));
                int distance = alphabet.IndexOf(coded_message[i]) + shift;
                if (distance >= alphabet.Count)
                {
                    distance = alphabet.Count + shift;
                }
                decoded += alphabet[distance];
                key_iterator++;
            }
            return decoded;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            InitializeAlphabet();
            string message_1 = "зустріч призначена в сім";


            Console.WriteLine(Gronsfeld_Cipher.Code(message_1, "1601", Alphabets.alph_ukr));
            Console.WriteLine(Gronsfeld_Cipher.Decode(Gronsfeld_Cipher.Code(message_1, "1601", Alphabets.alph_ukr),"1601",Alphabets.alph_ukr));
            Console.ReadKey();
        }
        static void InitializeAlphabet()
        {   
            Alphabets.alph = new List<char>
            {
            'я',
            'ю',
            'э',
            'ь',
            'ы',
            'ъ',
            'щ',
            'ш',
            'ч',
            'ц',
            'х',
            'ф',
            'у',
            'т',
            'с',
            'р',
            'п',
            'о',
            'н',
            'м',
            'л',
            'к',
            'й',
            'и',
            'з',
            'ж',
            'е',
            'д',
            'г',
            'в',
            'б',
            'а',
            ' '
            };
            Alphabets.alph_ukr = new List<char>
            {
            'я',
            'ю',         
            'ь',    
            'щ',
            'ш',
            'ч',
            'ц',
            'х',
            'ф',
            'у',
            'т',
            'с',
            'р',
            'п',
            'о',
            'н',
            'м',
            'л',
            'к',
            'й',
            'ї',
            'і',
            'и',
            'з',
            'ж',
            'є',
            'е',
            'д',
            'ґ',
            'г',
            'в',
            'б',
            'а',
            ' '
            };
        }
    }
}
