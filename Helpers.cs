using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace JarrettVance.ChapterTools
{
    public static class Helpers
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            //remove invalid file name chars
            str = new string(str.ToCharArray().Where(c => !System.IO.Path.GetInvalidFileNameChars().Contains(c)).ToArray());

            //remove url special chars ;/?:@&=+$,()|\^[]'<>#%"
            str = new string(str.ToCharArray().Where(c => !";/?:@&=+$,()|\\^[]'<>#%\"".Contains(c)).ToArray());

            //normalize and remove non-spacing marks
            //TODO: is this really necessary?
            str = str.Normalize(NormalizationForm.FormD);
            str = new string(str.ToCharArray().Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray());

            //WCF doesn't support periods and it may throw off IIS6 or other extension mime type issues
            str = str.Replace(".", string.Empty);
            return str;
        }

        public static string RemoveNumbers(this string str)
        {
            var chars = str.ToCharArray()
                .Where(x => !char.IsDigit(x));
            return new string(chars.ToArray());
        }
    }
}