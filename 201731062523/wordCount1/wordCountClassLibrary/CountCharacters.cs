using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordCountClassLibrary
{
    /// <summary>
    /// 统计字符数的类
    /// </summary>
    public class CountCharacters
    {
        public string text;
        public CountCharacters(string s)
        {
            this.text = s;
        }
        /// <summary>
        /// 统计字符数的函数
        /// </summary>
        /// <returns>字符个数</returns>
        public int Count_character()
        {
            if(this.text!=null)
            {
                int count = 0;
                foreach (char ascii in this.text)
                {
                    if (ascii >= 0 && ascii <= 127)
                        ++count;
                }
                Console.WriteLine("characters:" + count);
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
