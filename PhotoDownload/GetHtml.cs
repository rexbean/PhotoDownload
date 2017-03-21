using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace PhotoDownload
{
    class GetHtml
    {
        string url;
        string Cookiesstr;
        CookieContainer cc;
        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("utf-8");
        public GetHtml(string url,string Cookiesstr,CookieContainer cc)
        {
            this.Cookiesstr = Cookiesstr;
            this.cc = cc;
            this.url = url;
           
        }
        public string GetHtmlMetheod()
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("Cookie:" + Cookiesstr);
            request.CookieContainer = cc;
            request.AllowAutoRedirect = false;
            response = (HttpWebResponse)request.GetResponse();
            Cookiesstr = request.CookieContainer.GetCookieHeader(request.RequestUri);
            StreamReader sr = new StreamReader(response.GetResponseStream(), encoding);
            string str = sr.ReadToEnd();
            request.Abort();
            sr.Close();
            response.Close();
            return str;
        }
    }
}
