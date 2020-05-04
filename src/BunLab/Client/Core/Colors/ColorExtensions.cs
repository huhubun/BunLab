using System;
using System.Drawing;

namespace BunLab.Client.Core.Colors
{
    public static class ColorExtensions
    {
        public static string GetHEXFormat(this Color color)
        {
            return $"#{color.R:x2}{color.G:x2}{color.B:x2}";
        }

        public static string GetRGBAFormat(this Color color)
        {
            var alphaString = GetCssColorAlpha(color).ToString();

            return $"rgba({color.R},{color.G},{color.B},{alphaString})";
        }

        public static string GetHSLAFormat(this Color color)
        {
            var alphaString = GetCssColorAlpha(color).ToString();

            return $"hsla({color.GetHue()},{color.GetSaturation():P0},{color.GetBrightness():P0},{alphaString})";
        }

        public static double GetCssColorAlpha(this Color color)
        {
            // 最多保留两位小数
            return Math.Round(color.A * (1 / 255.0), 2);
        }
    }
}
