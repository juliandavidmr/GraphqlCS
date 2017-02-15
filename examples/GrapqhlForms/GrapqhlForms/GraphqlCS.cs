using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GrapqhlForms
{
    public class GraphqlCS
    {

        private readonly string pattern_general = @"{\s*(\w+)\s*\((.*)\)\s*{([\s\S]*)\s*}";
        private readonly string pattern_params = "\\s*(\\w+):\\s*\"?(\\w+)\"?";
        private readonly string pattern_content = "\\s*";

        public string toSQL(string input)
        {
            String result_sql = "";


            foreach (Match match in Regex.Matches(input, pattern_general, RegexOptions.IgnoreCase))
            {
                string name = match.Groups[1].Value;
                string parameters = match.Groups[2].Value;
                string content = match.Groups[3].Value.Replace("}", "");

                result_sql = get_content(content) + name + " " + get_params(parameters);
            }

            return result_sql;
        }

        public string get_params(string input)
        {
            string aux = "where ";
            int cont = 0;
            foreach (Match match in Regex.Matches(input, pattern_params, RegexOptions.IgnoreCase))
            {
                aux += match.Groups[1].Value + "=" + match.Groups[2].Value + ((match.Length - 1) == cont ? " AND " : "");
                cont++;
            }
            return aux;
        }

        public string get_content(string input)
        {

            char[] delimiterChars = { ' ' };
            string[] BruteWords = (input.Replace(System.Environment.NewLine, string.Empty)).Split(delimiterChars);
            List<string> CleanWords = new List<string>();
            foreach (string word in BruteWords)
            {
                if (!word.Equals(""))
                {
                    CleanWords.Add(word);
                }
            }
            string aux = "SELECT ";
            int countwords = 0;
            foreach (string word in CleanWords)
            {
                countwords++;
                aux += ((CleanWords.Count == countwords) ? word + " from " : word + ",");
            }

            return aux;

        }

    }
}
