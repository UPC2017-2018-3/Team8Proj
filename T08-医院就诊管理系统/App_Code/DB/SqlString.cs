using System;
using System.Collections;

namespace Hospital.DB
{
    public class SqlString
    {
        public static String GetSafeSqlString(String XStr)
        {
            return XStr.Replace("'", "''");
        }
        public static String GetQuotedString(String XStr)
        {
            return ("'" + GetSafeSqlString(XStr) + "'");
        }
    }

}

