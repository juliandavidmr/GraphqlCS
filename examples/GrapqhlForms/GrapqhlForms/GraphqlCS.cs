using System;
using System.Collections;
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

                //result_sql += String.Format("Nombre : {0}  \t\n", name);
                //result_sql += String.Format("Params : {0}  \t\n", get_params(parameters));
                //result_sql += String.Format("Content: {0}  \t\n", get_content(content));
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
         
            input.Replace("\r", "");
            string aux = "SELECT ";
            int cont = 0;
            foreach (string s in input.Split('\n'))
            {
                if (s.Equals(""))
                {

                }
                else
                {
                    aux += s + ((input.Split('\n').Length - 1) == cont ? "" : ",");
                }
             
            }
            return aux;
        }

    }
}
