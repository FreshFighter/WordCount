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
        private List<string> textlist = new List<string>();
        public CountLines(List<string> textlist)
        {
            this.textlist = textlist;
        }




        /// <summary>
        /// 统计有效行数的函数
        /// </summary>
        /// <returns>行数大小字符串</returns>
        public string Count_line()
        {
            if(this.textlist != null)
            { 
                return "lines:" + textlist.LongCount();
            }
            else
            {
                Console.WriteLine("文件为空");
                return null;
            }
        }
    }
}
