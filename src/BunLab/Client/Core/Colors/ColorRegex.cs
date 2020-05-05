using System.Text.RegularExpressions;

namespace BunLab.Client.Core.Colors
{
    public class ColorRegex
    {
        public ColorRegex(ColorDefineType colorDefineType, Regex regex)
        {
            ColorDefineType = colorDefineType;
            Regex = regex;
        }

        public ColorDefineType ColorDefineType { get; private set; }

        public Regex Regex { get; private set; }

        /// <summary>
        /// 十六进制表示的颜色 #FF00CC
        /// </summary>
        public static ColorRegex HEX
        {
            get
            {
                const string HEX_REGEX_STR = "^#{0,1}([0-9a-f]{2})([0-9a-f]{2})([0-9a-f]{2})$";
                return new ColorRegex(ColorDefineType.HEX, new Regex(HEX_REGEX_STR, RegexOptions.IgnoreCase));
            }
        }

        /// <summary>
        /// 十六进制缩写表示的颜色 #F0C
        /// </summary>
        public static ColorRegex HEXAbbr
        {
            get
            {
                const string HEX_ABBR_REGEX_STR = "^#{0,1}([0-9a-f])([0-9a-f])([0-9a-f])$";
                return new ColorRegex(ColorDefineType.HEXAbbr, new Regex(HEX_ABBR_REGEX_STR, RegexOptions.IgnoreCase));
            }
        }

        /// <summary>
        /// rgb() 函数形式表示的颜色 rgb(255,0,128)
        /// </summary>
        public static ColorRegex RGB
        {
            get
            {
                const string RGB_REGEX_STR = @"^rgb\((\d{1,3}),(\d{1,3}),(\d{1,3})\)$";
                return new ColorRegex(ColorDefineType.RGB, new Regex(RGB_REGEX_STR));
            }
        }

        /// <summary>
        /// rgba() 函数形式表示的颜色 rgb(255,0,255,0.4)
        /// </summary>
        public static ColorRegex RGBA
        {
            get
            {
                const string RGBA_REGEX_STR = @"^rgba\((\d{1,3}),(\d{1,3}),(\d{1,3}),((0{0,1}(.\d+))|0|1)\)$";
                return new ColorRegex(ColorDefineType.RGBA, new Regex(RGBA_REGEX_STR));
            }
        }
    }

}
