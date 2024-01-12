using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopflow.contract.Utils;

namespace shopflow.contract.Extensions
{
    public static class StringExtensions
    {
        public static string ToNormalized(this string text)
        {
            return StringUtils.RemoveDiacriticsAndSpecialCharecteres(text);
        }
    }
}