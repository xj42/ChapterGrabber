/********************************************************************************
*
*    Copyright(C) 2003-2008 Jarrett Vance http://jvance.com
*
*    This file is part of ChapterGrabber
*
*	 ChapterGrabber is free software; you can redistribute it and/or modify
*    it under the terms of the GNU General Public License as published by
*    the Free Software Foundation; either version 2 of the License, or
*    (at your option) any later version.
*
*    ChapterGrabber is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU General Public License for more details.
*
*    You should have received a copy of the GNU General Public License
*    along with this program; if not, write to the Free Software
*    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
*
********************************************************************************/
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace JarrettVance.ChapterTools
{
    /// <summary>
    /// Summary description for ChapterGrabber.
    /// </summary>
    public static class Grabber
    {
        //this is a bullshit method because 
        //   TimeSpan.ToString(string format) is missing
        public static string ToShortString(this TimeSpan ts)
        {
            string time;
            time = ts.Hours.ToString("00");
            time = time + ":" + ts.Minutes.ToString("00");
            time = time + ":" + ts.Seconds.ToString("00");
            time = time + "." + ts.Milliseconds.ToString("000");
            return time;
        }

        public static void ImportFromClipboard(List<ChapterEntry> chapters, string clipboard, bool includeDuration)
        {
            clipboard = clipboard.Replace("\t", string.Empty);
            for (int i = 0; i < chapters.Count; i++)
                chapters[i] = new ChapterEntry() { Time = chapters[i].Time, Name = ExtractFromCopy(clipboard, i + 1, includeDuration) };
        }

        private static string ExtractFromCopy(string clipboard, int chapterNum, bool includeDuration)
        {
            int nameAt = clipboard.IndexOf(chapterNum.ToString() + ". ");
            int nameTo = clipboard.IndexOf("\n", nameAt + 2 + chapterNum.ToString().Length);
            if (nameAt == -1 || nameTo == -1) return "Chapter " + chapterNum.ToString();
            string name = clipboard.Substring(nameAt + 2 + chapterNum.ToString().Length, nameTo - (nameAt + 2 + chapterNum.ToString().Length));
            if (!includeDuration) return name.RemoveDuration();
            else return name.Trim();
        }

        public static string RemoveDuration(this string val)
        {
            if (val.LastIndexOf('[') > 1) val = val.Substring(0, val.LastIndexOf('[') - 1);
            return val.Trim();
        }
    }
}
