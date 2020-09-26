using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    static class Alphabets
    {
        public static List<char> alph;
        public static List<char> alph_ukr;
        public static List<byte> alph_numbers;

    }
    public static class Gronsfeld_Cipher
    {
        public static string Code(string message, string key, List<char> alphabet)
        {
            string coded = "";
            int key_iterator = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (key_iterator >= key.Length) key_iterator = 0;
                int shift = Convert.ToInt32(key.Substring(key_iterator, 1));
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
        public static string Decode(string coded_message, string key, List<char> alphabet)
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
                    distance = distance - alphabet.Count - 1;
                }
                decoded += alphabet[distance];
                key_iterator++;
            }
            return decoded;
        }
        public static string Decode(List<byte> coded_message, List<byte> key, List<byte> alphabet)
        {
            string decoded = "";
            int key_iterator = 0;
            for (int i = 0; i < coded_message.Count; i++)
            {
                if (key_iterator >= key.Count) key_iterator = 0;
                int shift = key[key_iterator];
                int distance = alphabet.IndexOf(coded_message[i]) + shift;
                if (distance >= alphabet.Count)
                {
                    distance = distance - alphabet.Count-1;
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
            string message_2 = "у судді проникливий розум";
            string message_3 = "спеціальний підрозділ";
            string FIO = "";

            Console.WriteLine(Gronsfeld_Cipher.Code(message_1, "1601", Alphabets.alph_ukr));
            Console.WriteLine(Gronsfeld_Cipher.Code(message_2, "06754", Alphabets.alph_ukr));
            Console.WriteLine(Gronsfeld_Cipher.Code(message_3, "2345", Alphabets.alph_ukr));

            //Console.WriteLine(Gronsfeld_Cipher.Decode(Gronsfeld_Cipher.Code(message_1, "1601", Alphabets.alph_ukr), "1601", Alphabets.alph_ukr));
            string fio_key = Gronsfeld_Cipher.Decode(new List<byte> { 4, 6, 6, 8, 4, 6 }, new List<byte> { 1, 2, 8 }, Alphabets.alph_numbers);
            Console.WriteLine(fio_key);
            Console.WriteLine(Gronsfeld_Cipher.Code(FIO, fio_key, Alphabets.alph));

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
            Alphabets.alph_numbers = new List<byte>
            {
                9,8,7,6,5,4,3,2,1,0
            };
        }
    }
}
