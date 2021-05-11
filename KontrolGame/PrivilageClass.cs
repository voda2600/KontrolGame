using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolGame
{
    public static class PrivilageClass
    {
        public static string GetPrivilage(int kol)
        {
            if (kol <= 1) return "Normal";
            else if (kol <= 6) return "Great";
            else return "Boss";
        }
    }
}
