using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    static class Alphabets
    {
        //+ё +ъ
        public static List<char> alph_1;
        //+ъ
        public static List<char> alph_2;
        //+ё
        public static List<char> alph_3;
        //
        public static List<char> alph_4;
    }
    public static class Bruteforce
    {
        public static void FillUp(ref List<List<char>> table,string message, List<char> alphabet)
        {
            
            InitalizeList(ref table, message.Length);
            int index = 0;
            for (int i = 0; i < message.Length; i++)
            {
                index = alphabet.IndexOf(message[i]);
                for (int j = 0; j < 10; j++)
                {
                    if (index>= alphabet.Count)
                    {
                        index = 0;
                    }
                    table[i].Add(alphabet[index]);
                    index++;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"> номер строки(буквы в слове)</param>
        /// <param name="j">номер столбца (0-9)</param>
        /// <param name="table"></param>
        /// <param name="pos"></param>
        public static void Brute(ref List<string> res,int i,int j,List<List<char>> table , string pos)
        {
            if (i < table.Count)
            {
                for(int k = 0; k < 10; k++)
                {
                    Brute(ref res, i + 1,  k, table, pos+ table[i][k]);
                }
                return;
            }
            else
            {
                res.Add(pos);
                Console.WriteLine(pos);
                return;
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
            string coded_m_11 = "уусхрог";
            string coded_m_2 = "сжрссчпббдуусхрогдожзенй";
            string test = "фпжисьиоссахилфиусс";
            
            InitializeAlphabets();
            List<string> bruted = new List<string>();
            List<List<char>> table = new List<List<char>>();

            Bruteforce.FillUp(ref table, coded_m_11, Alphabets.alph_2);
            Bruteforce.Brute(ref bruted, 0, 0, table, "");
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"E:\3 course (inst)\Defence X\bruted_middle.txt"))
            {
                foreach (string s in bruted)
                {
                    file.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
        static void InitializeAlphabets()
        {
            Alphabets.alph_1 = new List<char>
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
            'ё',
            'е',
            'д',
            'г',
            'в',
            'б',
            'а',
            ' '
            };
            Alphabets.alph_2 = new List<char>
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
            Alphabets.alph_3 = new List<char>
            {
            'я',
            'ю',
            'э',
            'ь',
            'ы',
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
            'ё',
            'е',
            'д',
            'г',
            'в',
            'б',
            'а',
            ' '
            };
            Alphabets.alph_4 = new List<char>
            {
            'я',
            'ю',
            'э',
            'ь',
            'ы',
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
