using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OnlineShoppingStore.ui.Entities;
using System.Net;

namespace OnlineShoppingStore.ui.Helpers
{
    public class WebScrapping
    {
        public async Task<List<Course>> GetData()
        {
            string url = "https://www.google.com.au/search?num=30&q=online+title+search";
            WebClient web = new WebClient();
            string html = await Task.Factory.StartNew(() => web.DownloadString(url));
            List<string> m = FindMatch(html, @"<cite>(.+?)</cite>");
            
            return ReturnResult(m);    
        }

        private List<Course> ReturnResult(List<string> m)
        {

            List<Course> results = new List<Course>();

            if (m == null)
            {
                results.Add(new Course("No Course",0,false,false,0,"No one"));
                return results;
            }

            else
            {
                for (var i = 0; i < m.Count; i++)
                {
                    var courseName = m[i].Replace("<b>","").Replace("</b>","");
                    var courseId = i + 100;
                    bool isStarted = false;
                    bool isFinished = false;
                    var courseCompletion = 0;
                    var courseInstructor = i.ToString() + " Joe";

                    results.Add(new Course(courseName, courseId, isStarted, isFinished, courseCompletion, courseInstructor));
                }

                return results;
            }
        }

        private List<string> FindMatch(string main, string sub)
        {
            MatchCollection result = Regex.Matches(main, sub, RegexOptions.Singleline);
            List<string> output = new List<string>();

            for (var i = 0; i < result.Count; i++)
            {
                output.Add(result[i].Groups[1].Value.Trim());
            }

            return output;
        }
    }
}