using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GrapqhlForms {
  public class GraphqlCS {

    private readonly string pattern_general = @"{\s*(\w+)\s*\((.*)\)\s*{([\s\S]*)\s*}";

    public string toSQL(string input) {
      String result_sql = "";

      foreach (Match match in Regex.Matches(input, pattern_general, RegexOptions.IgnoreCase)) {
        string name = match.Groups[1].Value;
        string parameters = match.Groups[2].Value;
        string content = match.Groups[3].Value;

        result_sql += String.Format("Nombre : {0}  \t\n", name);
        result_sql += String.Format("Params : {0}  \t\n", get_params(parameters)[0]);
        result_sql += String.Format("Content: {0}  \t\n", content);
      }

      return result_sql;
    }

    public string[] get_params(string input) {
      return Regex.Split(input, ",");
    }
  }
}
