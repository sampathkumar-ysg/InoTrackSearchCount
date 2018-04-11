using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Api.InoTrackSearchCount.Common
{
    public class Helpers
    {
        public static List<string> FindAllHrefMatches(string html, Uri url)
        {
            string lookup = "href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))";
            MatchCollection matches = Regex.Matches(html, lookup);

            var matchlist = new List<string>();

            for (int i = 0; i < matches.Count; i++)
            {
                string match = matches[i].Groups[0].Value;
                if (match.Contains(url.Host))
                {
                    matchlist.Add($"Found {url.Host} at {i}");
                }
            }

            return matchlist;
        }
    }
}
