using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace BunLab.Client.Core.Colors
{
    public static class BunColorConverter
    {
        public static Color? FromString(string text)
        {
            var colorRegexs = new List<ColorRegex>();
            colorRegexs.Add(ColorRegex.HEX);
            colorRegexs.Add(ColorRegex.HEXAbbr);
            colorRegexs.Add(ColorRegex.RGB);
            colorRegexs.Add(ColorRegex.RGBA);

            foreach (var colorRegex in colorRegexs)
            {
                var regex = colorRegex.Regex;
                var match = regex.Match(text);

                if (match.Success)
                {
                    switch (colorRegex.ColorDefineType)
                    {
                        case ColorDefineType.HEX:
                            return HEXConverter(match);

                        case ColorDefineType.HEXAbbr:
                            return HEXAbbrConverter(match);

                        case ColorDefineType.RGB:
                            return RGBonverter(match);

                        case ColorDefineType.RGBA:
                            return RGBAConverter(match);

                        default:
                            throw new NotSupportedException(colorRegex.ColorDefineType.ToString());
                    }
                }
            }

            return KnownColorNameConverter(text);
        }

        private static Color HEXConverter(Match match)
        {
            // #FF  00  CC
            //  [1] [2] [3]
            //   R   G   B
            var groups = match.Groups;

            var r = Convert.ToInt32(groups[1].Value, 16);
            var g = Convert.ToInt32(groups[2].Value, 16);
            var b = Convert.ToInt32(groups[3].Value, 16);

            return Color.FromArgb(r, g, b);
        }

        private static Color HEXAbbrConverter(Match match)
        {
            // #F   0   C
            //  [1] [2] [3]
            //   R   G   B
            var groups = match.Groups;

            var r = Convert.ToInt32(groups[1].Value + groups[1].Value, 16);
            var g = Convert.ToInt32(groups[2].Value + groups[2].Value, 16);
            var b = Convert.ToInt32(groups[3].Value + groups[3].Value, 16);

            return Color.FromArgb(r, g, b);
        }

        private static Color RGBonverter(Match match)
        {
            // rgb(255, 0,  128)
            //     [1]  [2] [3]
            //      R    G   B
            var groups = match.Groups;

            var r = Convert.ToInt32(groups[1].Value);
            var g = Convert.ToInt32(groups[2].Value);
            var b = Convert.ToInt32(groups[3].Value);

            return Color.FromArgb(r, g, b);
        }

        private static Color RGBAConverter(Match match)
        {
            // rgba(255, 0,  128, 0.4))
            //      [1]  [2] [3]  [4]
            //       R    G   B    A
            var groups = match.Groups;

            var r = Convert.ToInt32(groups[1].Value);
            var g = Convert.ToInt32(groups[2].Value);
            var b = Convert.ToInt32(groups[3].Value);
            // CSS 的 alpha 是 0~1，而 .NET 是 0~255，所以需要进行换算
            // 0.4、.4、.4444 都是合法输入
            var a = (int)Math.Floor(Convert.ToDouble(groups[4].Value) * 255);

            return Color.FromArgb(a, r, g, b);
        }

        private static Color? KnownColorNameConverter(string text)
        {
            var isKnownColorName = Enum.TryParse<KnownColor>(text, true, out var knownColor);

            // 需要过滤掉输入 1、2 这种枚举值的情况
            // 只能通过枚举名称来获取 KnownColor
            if (isKnownColorName && knownColor.ToString().ToUpper() == text.ToUpper())
            {
                return Color.FromKnownColor(knownColor);
            }

            return null;
        }
    }
}
