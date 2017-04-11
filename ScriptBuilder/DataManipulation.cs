using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScriptBuilder
{
    class DataManipulation
    {

        // Extracts data between two string's character positions
        public string CaptureTextBetween(string source, int startPoint, int endPoint)
        {
            string capturedText = "";

            if (startPoint >= 0 && endPoint > startPoint)
            {
                capturedText = source.Substring(startPoint, endPoint - startPoint);
            }
            return capturedText;
        }

        // get all character start positions of a specified substring within a specified string
        public List<int> GetStartPositions(string source, string searchString)
        {
            List<int> ret = new List<int>();
            int len = searchString.Length;
            int start = -len;
            while (true)
            {
                start = source.IndexOf(searchString, start + len);
                if (start == -1)
                {
                    break;
                }
                else
                {
                    ret.Add(start + len);
                }
            }

            return ret;
        }

        // get all character end positions of a specified substring within a specified string
        public List<int> GetEndPositions(string source, string searchString)
        {
            List<int> ret = new List<int>();
            int len = searchString.Length;
            int start = -len;
            while (true)
            {
                start = source.IndexOf(searchString, start + len);
                if (start == -1)
                {
                    break;
                }
                else
                {
                    ret.Add(start);
                }
            }

            return ret;
        }


        public int GetStartPosition(string source, string searchString)
        {
            int ret = -1;
            int len = searchString.Length;
            int start = -len;
            start = source.IndexOf(searchString, start + len);

            if (start == -1)
            {

            }
            else
            {
                ret = start + len;
            }

            return ret;
        }


        public int GetEndPosition(string source, string searchString)
        {
            int ret = -1;
            int len = searchString.Length;
            int start = -len;
            start = source.IndexOf(searchString, start + len);

            if (start == -1)
            {

            }
            else
            {
                ret = start;
            }

            return ret;
        }

        public string ExtractScriptData(string source)
        {
            source = Regex.Replace(source, "<!--.*?-->", "", RegexOptions.Singleline);
            //tmText = Regex.Replace(tmText, "<table.*?/table>", "[refer to " + tmName + " to view this data table.]", RegexOptions.Singleline);
            source = Regex.Replace(source, "<figure.*?/figure>", "", RegexOptions.Singleline);
            source = Regex.Replace(source, "<callout.*?/>", "", RegexOptions.Singleline);
            source = Regex.Replace(source, "<xref.*?/>", "", RegexOptions.Singleline);
            source = Regex.Replace(source, @"posttext=", " ");
            source = Regex.Replace(source, @"\s+", " ");
            source = source.Replace(" ,", String.Empty);
            source = source.Replace("\n", String.Empty);
            source = source.Replace("\r", String.Empty);
            source = source.Replace("\t", String.Empty);

            return source;
        }

        // returns string data between specified substrings that appear in a source string
        public string ExtractData(string source, string start, string end)
        {
            string extractedData = "";

            extractedData = CaptureTextBetween(source, GetStartPosition(source, start), GetEndPosition(source, end));

            return extractedData;
        }

        public string FindTopLevelTag(string source, string topTag)
        {
            string newSource = string.Empty;
            int start = GetStartPosition(source, "<" + topTag);
            int end = GetEndPosition(source, "</" + topTag + ">");
            newSource = CaptureTextBetween(source, start, end);
            return newSource;
        }


    }
}
