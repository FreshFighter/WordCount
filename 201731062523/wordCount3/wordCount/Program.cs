using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wordCountClassLibrary;
using System.IO;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            if (OpenFile(args[0], out text))
            {
                Operate(text);
            }
            else
                Console.WriteLine("打开文件失败！");
           // Console.ReadKey();
        }

        /// <summary>
        /// 打开文件的函数，调用成功返回ture
        /// </summary>
        /// <param name="args"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        static bool OpenFile(string args,out string s)
        {
            //读取文件到文件结束，并将其存入s中
            StreamReader file = new StreamReader(args, Encoding.Default);
            s = file.ReadToEnd();
            return true;
        }

        /// <summary>
        /// 进行各种统计的函数
        /// </summary>
        /// <param name="s"></param>
        static void Operate(string s)
        {
            CountCharacters count_characters = new CountCharacters(s);
            count_characters.Count_character();
            CountLines count_lines = new CountLines(s);
            count_lines.Count_line();
            CountWords count_words = new CountWords(s);
            count_words.Count_word();
            count_words.Count_word_frequency();
        }
    }
}
