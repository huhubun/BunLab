namespace BunLab.Client.Core.Colors
{
    public enum ColorDefineType
    {
        /// <summary>
        /// 以十六进制表示的颜色 #FF00CC
        /// </summary>
        HEX,

        /// <summary>
        /// 以十六进制缩写表示的颜色 #F0C
        /// </summary>
        HEXAbbr,

        /// <summary>
        /// 以 rgb() 函数形式表示的颜色 rgb(255,0,128)
        /// </summary>
        RGB,

        /// <summary>
        /// 以 rgba() 函数形式表示的颜色 rgb(255,0,128,0.4)
        /// </summary>
        RGBA
    }
}
