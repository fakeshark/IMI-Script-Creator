using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptBuilder
{
    class Formatting
    {
        DataManipulation Dm = new DataManipulation();

        public string MakeOpenTag(string source)
        {
            return "<" + source;
        }

        public string MakeCloseTag(string source)
        {
            if (source[0].ToString() == "<")
            {
                source = source.Remove(0, 1);
            }

            return "</" + source + ">";
        }

        public bool Contains(string source, string compare)
        {
            if (source.IndexOf(compare) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FindFirstOpeningTag(string source)
        {
            string openingTag = string.Empty;

            if (Contains(source, "<"))
            {
                for (int i = Dm.GetStartPosition(source, "<"); i < source.Length; i++)
                {
                    if (source[i].ToString() == ">" || source[i].ToString() == " ")
                    {
                        break;
                    }
                    else
                    {
                        openingTag += source[i];
                    }
                }
            }

            return openingTag;
        }

        public string GetDataFrom(string source, string tag)
        {
            string dataInside = string.Empty;

            if (tag[0].ToString() == "<")
            {
                tag = tag.Remove(0, 1);
            }

            if (Contains(source, "<" + tag))
            {
                dataInside = Dm.ExtractData(source, "<" + tag, "</" + tag + ">");
            }

            return dataInside;
        }
    }
}
