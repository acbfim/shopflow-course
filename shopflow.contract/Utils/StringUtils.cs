using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace shopflow.contract.Utils
{
    public static class StringUtils
    {
        private static readonly Regex diacriticRegex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
        public static string RemoveDiacriticsAndSpecialCharecteres(string text)
        {

            string normalizedString = text.Normalize(NormalizationForm.FormD);

            string withoutDiacritic = diacriticRegex.Replace(normalizedString, string.Empty).Normalize(NormalizationForm.FormC);

            string specialChars = "-/:,\\|";

            string pattern = "[" + Regex.Escape(specialChars) + "]";
            string result = Regex.Replace(withoutDiacritic, pattern, string.Empty);
                
            return result.Trim().ToLower();
        }
    }
}