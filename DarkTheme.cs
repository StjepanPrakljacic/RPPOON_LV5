using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    class DarkTheme:ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
