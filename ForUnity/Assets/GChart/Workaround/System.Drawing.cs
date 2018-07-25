/// <summary>
/// Workaround for System.Drawing
/// </summary>

namespace System.Drawing
{
    public struct Color
    {
        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public static implicit operator Color(UnityEngine.Color32 c)
        {
            return new Color
            {
                A = c.a,
                R = c.r,
                G = c.g,
                B = c.b
            };
        }
        public static implicit operator Color(UnityEngine.Color c)
        {
            return (UnityEngine.Color32)(c);
        }

        public static readonly Color Green = UnityEngine.Color.green;
        public static readonly Color Red = UnityEngine.Color.red;
    }


    public static class ColorTranslator
    {
        public static Color FromHtml(string htmlColor)
        {
            UnityEngine.Color res;
            UnityEngine.ColorUtility.TryParseHtmlString(htmlColor, out res);
            return res;
        }
    }
}
