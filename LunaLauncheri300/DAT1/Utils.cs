using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaLauncheri30
{
    public class Utils
    {
        public static string Normalize(string data)
        {
            string result = data.ToLower().Replace('\\', '/');
            string replaced = "";
            bool slash = false;

            foreach (var c in result)
            {
                if (c == '/')
                {
                    if (slash) continue;
                    slash = true;
                }
                else
                {
                    slash = false;
                }

                replaced += c;
            }

            return replaced;
        }

        [Conditional("DEBUG")]
        public static void Assert(bool condition, string message)
        {
            if (!condition)
            {
                throw new System.Exception(message);
            }
        }

        [Conditional("DEBUG")]
        public static void Assert(bool condition) => Assert(condition, string.Empty);
    }
}
