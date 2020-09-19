using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    static class Alphabets
    {
        public static List<char> alph;

    }
    public static class Bruteforce
    {
        public static void FillUp(ref List<List<char>> table, string message, List<char> alphabet)
        {

            InitalizeList(ref table, message.Length);
            int index = 0;
            for (int i = 0; i < message.Length; i++)
            {
                index = alphabet.IndexOf(message[i]);
                for (int j = 0; j < 10; j++)
                {
                    if (index >= alphabet.Count)
                    {
                        index = 0;
                    }
                    table[i].Add(alphabet[index]);
                    index++;
                }
            }
        }
        public static void BruteKey(ref List<string> res, List<List<char>> table, string message, int mul)
        { 
            int limit = 1;
            for(int i = 0; i < mul; i++)
            {
                limit *= 10;
            }
            for (int key_size = 0; key_size < limit; key_size++)
            {
                string pos = "";
                string key = "";
                key = key_size.ToString().PadLeft(mul - 1, '0');
                int h = 0;//key iterator
                for (int g = 0; g < message.Length; g++)
                {
                    if (h + 1 > key.Length)
                        h = 0;
                    pos += table[g][Convert.ToInt32((key.Substring(h, 1)))];
                    h++;
                }
                res.Add(pos);
                Console.WriteLine(pos);
            }

        }
        static void InitalizeList(ref List<List<char>> list, int size)
        {
            for (int i = 0; i < size; i++)
            {
                list.Add(new List<char>());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string coded_m_1 = "трхшуеокйефхмптпдцсрхшхзчкм";
            string coded_m_2 = "сжрссчпббдуусхрогдожзенй";
            string test = "фпжисьиоссахилфиусс";

            InitializeAlphabet();
            List<string> bruted = new List<string>();
            List<List<char>> table = new List<List<char>>();

            Bruteforce.FillUp(ref table, coded_m_2, Alphabets.alph);    
            Bruteforce.BruteKey(ref bruted, table, coded_m_2, 4);//where 6 - assumed key length

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"E:\3 course (inst)\Defence X\bruted_full_2_4.txt"))
            {
                foreach (string s in bruted)
                {
                    file.WriteLine(s, Encoding.ASCII);
                }
            }
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
        }
    }
}
