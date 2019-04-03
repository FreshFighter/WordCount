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
        public string text;
        public CountWords(string s)
        {
            this.text = s;
        }
        /// <summary>
        /// 统计单词数的函数
        /// </summary>
        /// <returns>单词数</returns>
        public int Count_word()
        {
            if(this.text!=null)
            {
                int count = 0;//用来记数
                string[] wordList = this.text.ToLower().Split(",.' ?!\r\n".ToCharArray());
                foreach (string word in wordList)
                    if (word.Length > 0)
                        ++count;
                Console.WriteLine("words:" + count);
                return count;
            }
            else
            {
                Console.WriteLine("文件为空");
                return 0;
            }
        }
        /// <summary>
        /// 统计词频的函数
        /// </summary>
        /// <returns>词频最高的单词的频数</returns>
        public int Count_word_frequency()
        {
            if (this.text != null)
            {
                string[] wordList = this.text.ToLower().Split(",.' ?!\r\n".ToCharArray());
                var List = wordList.GroupBy(x => x).OrderByDescending(x => x.Count());
                int i = 0;
                foreach (var word in List)
                {
                    if (word.Key != List.Last().Key)
                        Console.WriteLine(word.Key + ":" + word.Count());
                    ++i;
                    if (i == 10)
                        break;
                }
                return List.First().Count();
            }
            else
            {
                Console.WriteLine("文件为空");
                return 0;
            }
        }
    }
}
