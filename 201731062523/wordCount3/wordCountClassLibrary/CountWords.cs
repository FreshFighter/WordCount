using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordCountClassLibrary
{
    /// <summary>
    /// 统计单词个数及频数的类
    /// </summary>
    public class CountWords
    {
        private List<string> textlist = new List<string>();
        //private string[] wordlist = Extract_words();
        public CountWords(List<string> textlist)
        {
            this.textlist = textlist;
        }


        /// <summary>
        /// 将单词提取出来的函数
        /// </summary>
        /// <returns>单词字符串数组</returns>
        private string[] Extract_words()
        {
            if (this.textlist != null)
            {
                List<string> temp = new List<string>();
                int flag = 0;
                foreach (var words in textlist)
                {
                    string[] word = words.ToLower().Split(new char[] { ' ',':', ',', '.', '?', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var s in word)
                    {
                        flag = 0;
                        foreach (var c in s)
                        {
                            if ((c < 97 && c > 57) || c > 122 || c < 48)
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 1)
                            continue;
                        temp.Add(s);
                    }
                }
                string[] wordlist = new string[temp.LongCount()];
                int i = -1;
                foreach (var s in temp)
                    wordlist[++i] = s;
                return wordlist;
            }
            else
            {
                Console.WriteLine("文件为空");
                return null;
            }
        }


        /// <summary>
        /// 统计单词数的函数
        /// </summary>
        /// <returns>单词数字符串</returns>
        public string Count_word()
        {
            int count = 0;//用来记数;
            string[] wordlist = Extract_words();
            foreach (var s in wordlist) 
            {
                //Console.WriteLine(s);
                if (s.Length < 4 || (s[0] < 97 && s[0] > 122) || (s[1] < 97 && s[1] > 122) || (s[2] < 97 && s[2] > 122) || (s[3] < 97 && s[3] > 122))
                    continue;
                ++count;
            }
            return "words:" + count;
        }



        /// <summary>
        /// 统计词频的函数
        /// </summary>
        /// <returns>前num个单词的词频字符串数组</returns>
        public string[] Count_word_frequency(int num)
        {
            List<string> temp = new List<string>();
            string[] wordlist = Extract_words();
            foreach (var s in  wordlist)
            {
                if (s.Length < 4 || (s[0] < 97 && s[0] > 122) || (s[1] < 97 && s[1] > 122) || (s[2] < 97 && s[2] > 122) || (s[3] < 97 && s[3] > 122))
                    continue;
                temp.Add(s);
            }
            int k = -1;
            string[] ss = new string[temp.LongCount()];
            foreach (var s in temp)
                ss[++k] = s;
            var List = ss.GroupBy(x => x).OrderByDescending(x => x.Count());
            string[] frequency = new string[num];
            int j = 0;
            foreach (var s in List)
            {
                frequency[j++] = s.Key + ":" + s.Count();
                if (j == num)
                    break;
            }
            return frequency;
        }




        public string[] Count_Phrase(int a)
        {
            string[] wordlist = Extract_words();
            string[] phraseList = new string[wordlist.LongCount() - a + 1];
            for (int i = 0; i < wordlist.LongCount() - a + 1; i++)
            {
                string str = null;
                for (int k = 1; k < a; k++)
                    str += wordlist[i+k] + " ";
                phraseList[i] = str;
            }
            var List = phraseList.GroupBy(x => x).OrderByDescending(x => x.Count());
            string[] phraseList1 = new string[List.Count()];
            int j = 0;
            foreach (var s in List)
                phraseList1[j++] = s.Key + ":" + s.Count();
            return phraseList1;
        }
    }
}
