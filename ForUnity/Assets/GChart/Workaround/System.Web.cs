/// <summary>
/// System.Web
/// </summary>
using UnityEngine;

namespace System.Web
{
    public static class HttpUtility
    {
        public static string UrlEncode(string str)
        {
            return WWW.EscapeURL(str);
        }
    }
}
