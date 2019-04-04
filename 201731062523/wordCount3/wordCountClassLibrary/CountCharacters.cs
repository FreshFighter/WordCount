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
        private List<string> textlist = new List<string>();
        public CountCharacters(List<string> textlist)
        {
            this.textlist = textlist;
        }
        /// <summary>
        /// 统计字符数的函数
        /// </summary>
        /// <returns>字符个数</returns>
        public string Count_character()
        {
            if(this.textlist != null)
            {
                int count = 0;
                foreach(var s in textlist)
                {
                    count += s.Length;
                }
                return "characters:" + count;
            }
            else
            {
                Console.WriteLine("文件为空");
                return null;
            }
        }
    }
}
