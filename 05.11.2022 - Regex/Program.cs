using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _05._11._2022___Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            string s = "901b.0e94.83a8";
            Console.WriteLine($"Mac address Cisco: {s}");
            string result = "";
            // 90-1B-0E-94-83-A8
            Regex regex = new Regex(@"[0-9a-z]{1,4}");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    result += match.Value;
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }

            // Convert To Upper

            result = result.ToUpper();

            // Insert - in each 2 symbols

            result = Regex.Replace(result, ".{2}", "$0-");

            // Removing last sumbol

            result = result.Remove(result.Length - 1);

            Console.WriteLine($"Mac address Windows: {result}");
            Console.ReadKey();
        }
    }
}
