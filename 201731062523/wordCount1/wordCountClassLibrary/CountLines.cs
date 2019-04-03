using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordCountClassLibrary
{
    /// <summary>
    /// 统计有效行数的类
    /// </summary>
    public class CountLines
    {
        public string text;
        public CountLines(string s)
        {
            this.text = s;
        }
        /// <summary>
        /// 统计有效行数的函数
        /// </summary>
        /// <returns>行数</returns>
        public int Count_line()
        {
            if(this.text!=null)
            {
                string[] wordList = this.text.Split("\r\n".ToCharArray());
                int count = 0;
                foreach (string word in wordList)
                    if (word.Length > 0)
                        ++count;
                Console.WriteLine("lines:" + count);
                return count;
            }
            else
            {
                Console.WriteLine("文件为空");
                return 0;
            }
        }
    }
}
