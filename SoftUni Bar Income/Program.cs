using System;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\w *|)(?< name >%[A - Z][a - z] +%)(\w *|)(?< product ><\w +>)(\w *|)(?< quantity >\|\d +\|)(\w *|)(?< price >[0 - 9] +.[0 - 9] +\$|[0 - 9] +\$)(\w *|)";
        }
    }
}
