using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace PhotoDownload
{
    public partial class GetIdForm : Form
    {
        
        private string Cookiesstr;
        private CookieContainer cc;
        string friendId;
        List<string> friendIdList = new List<string>();
        public GetIdForm(string Cookiesstr,CookieContainer cc)
        {
            InitializeComponent();
            this.Cookiesstr = Cookiesstr;
            this.cc = cc;
            
        }

        private void GetidButton_Click(object sender, EventArgs e)
        {
            friendId=FriendIDBox.Text.ToString();

            int start;
            int end=0;
            int start1;
            int end1=0;
            int page = 0;
            int finalpage=1;
            int renshu = 0;
            
            do
            {
                start = 0;
                end = 0;
                try
                {
                    string url = "http://friend.renren.com/GetFriendList.do?curpage=" + page + "&id=" + friendId;
                    string str = "";
                    #region get html source code
                    GetHtml gethtml=new GetHtml(url,Cookiesstr,cc);
                    str = gethtml.GetHtmlMetheod();
                    #endregion
                    
                    while (str != null)
                    {
                        #region get the number of total pages
                        start1 = str.IndexOf("最后页", end1);
                        if (page == 0 && start1 != -1)
                        {
                            end1 = str.IndexOf('&', start1);
                            if (end1 - start1 - 37<0)
                            {
                                page++;
                                continue;
 
                            }
                            string number = str.Substring(start1 + 37, (end1 - start1 - 37));
                            finalpage = int.Parse(number);
                        }
                        #endregion
                        #region get the friend id
                        int a;
                        start = str.IndexOf("addFriend", end);
                        if (start != -1)
                        {
                            end = str.IndexOf('"', start);
                            string number = str.Substring(start + 9, (end - start - 9));
                            try
                            {
                                a = int.Parse(number);
                                friendIdList.Add(number);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                        else
                        {
                            break;
                        }
                        #endregion
                    }
                        

                    page++;
                    #region print out the number of friends of each page
                    if (renshu == 0)
                    {
                        renshu = friendIdList.Count;
                        Console.WriteLine("this page has " + friendIdList.Count + "friends");
                    }
                    else
                    {
                        Console.WriteLine("this page has " + (friendIdList.Count-renshu).ToString() + "friends");
                        renshu = friendIdList.Count;
 
                    }  
#endregion
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message.ToString());
                    throw Ex;
                }
            } while (page!=finalpage+1);

            #region out put the friends id txt
            string outPutPath = "I://lcj//"+friendId+"Id.txt";
            StreamWriter sw = new StreamWriter(outPutPath, true);
            foreach (string id in friendIdList)
            {
                AllFriendIdBox.Text += id.ToString() + "\r\n";
                sw.WriteLine(id);
            }
            sw.Close();
            #endregion
            Console.WriteLine("Your friend has "+friendIdList.Count+" friends" );
           
                      
        }

        private void ReadIdFromFileButton_Click(object sender, EventArgs e)
        {
            friendId = this.FriendIDBox.Text.ToString();
            string filePath = "I://lcj//" + friendId + "Id.txt";

            
            if(File.Exists(filePath)==false)
            {
                GetidButton_Click(sender,e);
            }
            else
            {
                StreamReader fr = new StreamReader(filePath);
                string sLine = "";
                while (sLine != null)
                {
                    sLine = fr.ReadLine();
                    if (sLine != null && !sLine.Equals(""))
                        friendIdList.Add(sLine);

                }
                foreach (string id in friendIdList)
                {
                    AllFriendIdBox.Text += id.ToString() + "\r\n";
                }
                fr.Close();
            }
            
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            DownloadPhoto downLoadPhoto = new DownloadPhoto(Cookiesstr,cc,friendIdList,friendId);
            downLoadPhoto.Show();
            this.Close();
        }

        


        
    }
}
