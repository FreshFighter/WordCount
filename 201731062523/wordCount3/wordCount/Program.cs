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
            Operate(args);
            Console.WriteLine("运行成功");
        }


        /// <summary>
        /// 打开文件的函数，调用成功返回ture
        /// </summary>
        /// <param name="args"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        static bool OpenFile(string ss, ref List<string> textlist)
        {
            //读取文件到文件结束，并将其存入s中
            FileStream fs = new FileStream(ss, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = null;
            while ((line = sr.ReadLine()) != null)
                textlist.Add(line);
            return true;
        }



        /// <summary>
        /// 将数据写入文件的函数
        /// </summary>
        /// <param name="ss"></param>
        /// <param name="outlist"></param>
        /// <returns></returns>
        static bool WriteFile(string ss, List<string> outlist)
        {
            FileStream fs = new FileStream(ss, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach(var s in outlist)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            return true;
        }




        /// <summary>
        /// 进行各种统计的函数
        /// </summary>
        /// <param name="s"></param>
        static void Operate(string[] args)
        {
            string file = null;
            List<string> textlist = new List<string>();
            List<string> outputlist = new List<string>();
            const string i = "-i", n = "-n", o = "-o", m = "-m";
            string[] phrase = null;
            string[] word_frequency = null;
            List<string> list = new List<string>();
            foreach (var s in args)
                list.Add(s);
            int j = 0;
            foreach (var s in list)
            {
                if (s == i)
                {
                    file = list[j + 1];
                    if (OpenFile(file, ref textlist)){}
                    else
                        Console.WriteLine("打开文件失败！1");
                    break;
                }
                ++j;

            }
            CountCharacters character = new CountCharacters(textlist);
            string ctr = character.Count_character();
            Console.WriteLine(ctr);
            CountWords word = new CountWords(textlist);
            string ws = word.Count_word();
            Console.WriteLine(ws);
            CountLines lines = new CountLines(textlist);
            string ls = lines.Count_line();
            Console.WriteLine(ls);
            for (int k = 0; k < list.LongCount(); ++k)
            {
                if (list[k] == m)
                {
                    int num = int.Parse(list[++k]);
                    CountWords words = new CountWords(textlist);
                    phrase = words.Count_Phrase(num);
                }
                else if (list[k] == n)
                {
                    int num = int.Parse(list[++k]);
                    CountWords words = new CountWords(textlist);
                    word_frequency = words.Count_word_frequency(num);
                }
                else
                {
                    continue;
                }
            }
            outputlist.Add(ctr);
            outputlist.Add(ws);
            outputlist.Add(ls);
            outputlist.Add("\r");
            Console.WriteLine();
            if (word_frequency != null)
            foreach (var s in word_frequency)
                {
                    outputlist.Add(s);
                    Console.WriteLine(s);
                }
            outputlist.Add("\r");
            Console.WriteLine();
            if (phrase != null)
                foreach (var s in phrase)
                    outputlist.Add(s);
            for (int l = 0; l < list.LongCount(); ++l)
            {
                if (list[l] == o)
                {
                    string outfile = list[++l];
                    if(WriteFile(outfile, outputlist))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("打开文件失败");
                        break;
                    }
                }
            }
        }
    }
}
