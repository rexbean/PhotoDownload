using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace PhotoDownload
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username=UserNameTextBox.Text.ToString();
            password = PasswordTextBox.Text.ToString();
            
            Login(username, password);

         

            

        }
        private void Login(string username, string password)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            string accept = "image/gif,image/x-xbitmap,image/jpeg,image/pjpeg,application/x-shockwave-flash";
            System.Net.CookieContainer cc = new CookieContainer();
            string contentType = "application/x-www-form-urlencoded";
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("utf-8");
            string userAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
            string url = "http://www.renren.com/PLogin.do";
            string Cookiesstr;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.CookieContainer = cc;
                request.Accept = accept;
                request.ContentType = contentType;
                request.UserAgent = userAgent;
                request.Referer = url;
                request.KeepAlive = true;
                request.Method = "POST";
               // string username1 = "1933747421@qq.com";
               // string password1 = "123456abc";
                string postData = string.Format("email={0}&password={1}&origURL=http%3A%2F%2Fwww.renren.com%2FHome.do&domain=renren.com", username, password);
                //string postData = string.Format("email={0}&password={1}&origURL=http%3A%2F%2Fwww.renren.com%2FHome.do&domain=renren.com", username, password);
                if (!string.IsNullOrEmpty(postData))
                {
                    byte[] bytes = System.Text.Encoding.Default.GetBytes(postData);
                    request.ContentLength = bytes.Length;
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                }

                response = (HttpWebResponse)request.GetResponse();
                string strcrook = request.CookieContainer.GetCookieHeader(request.RequestUri);
                cc.Add(request.CookieContainer.GetCookies(request.RequestUri));
                Cookiesstr = strcrook;

                //get response
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream, encoding);
                string html = reader.ReadToEnd();
                reader.Close();
                responseStream.Close();
                response.Close();
                
                Regex r = new Regex("您的用户名和密码不匹配");
                Match m = r.Match(html);
                
                if (m.Success)
                {
                    Console.WriteLine("登陆失败");
                }
                else
                {
                    Console.WriteLine("登录成功");
                    GetIdForm downloadForm = new GetIdForm(Cookiesstr,cc);
                    downloadForm.Show();
                   // this.Close();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message.ToString());
                
                //Login(username, password);

                throw Ex;
            }
 
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        

        

      
    }
}
