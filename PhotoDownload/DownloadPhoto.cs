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
using System.Web;
using System.Threading;
namespace PhotoDownload
{
   
    public partial class DownloadPhoto : Form
    {
        public static int friendNumber = -1;
        public static int friendNumber1 = -1;
        string friendId;
        string Cookiesstr;
        string nowFriendId;
        CookieContainer cc;
        List<string> friendIdList = new List<string>();
        List<string> downloadedIdList = new List<string>();
        List<FileName> fileNameList = new List<FileName>();
        public DownloadPhoto(string Cookiesstr, CookieContainer cc, List<string> friendIdList,string friendId)
        {
            InitializeComponent();
            this.Cookiesstr = Cookiesstr;
            this.cc = cc;
            this.friendIdList = friendIdList;
            this.friendId = friendId;
        }

        private void DownLoadButton_Click(object sender, EventArgs e)
        {
            //Thread Thread = new Thread(new ThreadStart());
            int i = 0;
            foreach (FileName f in fileNameList)
            {

                NowDownloadingIdBox.Text = f.id;
                Delay();
                string filePath = "I://lcj//" + friendId + "downloaded.txt";
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine("id " + f.id);
                sw.Close();

                Download(f,0);
                DownloadedIdBox.Text += f.id+"\r\n";
                Delay();
                i++;
                {
                    if (i % 10 == 0)
                    {
                        int a = 0; ;
                    }
                }
            }
                
                
               
           

        }

        private void GetAlbumNumber(string url,string Id)
        {
            int start;
            int end = 0;
            int albumCount = 0;
            GetHtml getHtml = new GetHtml(url, Cookiesstr, cc);
            List<string> albumIdList = new List<string>();
            string str = getHtml.GetHtmlMetheod();
            //Console.WriteLine(str);
            while (str != null)
            {
                start = str.IndexOf("/album-", end);
                if (start != -1)
                {
                    end = str.IndexOf("?", start);
                    string number = str.Substring(start + 7, (end - start - 7));

                    try
                    {
                        if (albumCount % 2 == 0)
                        {
                            albumIdList.Add(number);

                        }
                        albumCount++;

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

            }
            //foreach (string i in albumIdList)
            //{
            //    Console.WriteLine("album id=" + i);
            //}
            string outPutPath = "I://lcj//"+friendId+"albumList.txt";
            StreamWriter sw = new StreamWriter(outPutPath, true);          
           
                sw.WriteLine("id " + Id);
                FileName fileName = new FileName(Id);
                fileName.ablumIdList = albumIdList;
                fileNameList.Add(fileName);
                foreach(string album in albumIdList)
                {
                    sw.WriteLine("album "+ album);
                }
               

            sw.Close();
            
        }

        private void GetAlbumIdButton_Click(object sender, EventArgs e)
        {
            string filePath = "I://lcj//" + friendId + "albumList.txt";
            foreach (string i in friendIdList)
            {
                    string url = "http://photo.renren.com/photo/" + i + "/album/relatives";
                    this.GetAlbumNumber(url,i);
             }

            Console.WriteLine("Get Ablum Id From Net Successfully");
        }

        private void ReadAlbumIdfromFileButton_Click(object sender, EventArgs e)
        {
            string filePath = "I://lcj//" + friendId + "albumList.txt";
            if (File.Exists(filePath) == true)
            {
                foreach (string Id in friendIdList)
                {
                    FileName fileName = new FileName(Id);
                    fileNameList.Add(fileName);
                }

                    StreamReader fr = new StreamReader(filePath);
                    string sLine = "";
                    while (sLine != null)
                    {
                        sLine = fr.ReadLine();
                        if (sLine != null && !sLine.Equals(""))
                        {
                            string[] fileStr = sLine.Split(new char[] { ' ' });
                            switch (fileStr[0])
                            {
                                case "id": friendNumber++; nowFriendId = fileNameList[friendNumber].id; break;
                                case "album": fileNameList[friendNumber].ablumIdList.Add(fileStr[1]); break;

                            }
                        }

                       
                    }
                
            }
            else
            {
                GetAlbumIdButton_Click(sender, e);
            }
            Console.WriteLine("Read Ablum Id From File Successfully");
           
        }

        private void Download(FileName f,int k)
        {
            
            int j = 0;

            string filePath = "I://lcj//" + friendId + "downloaded.txt";
            for(int m=k;m<f.ablumIdList.Count;m++)
            {
                NowDownloadingFileBox.Text = f.ablumIdList[m];
                if (f.ablumIdList[m] != null)
                {
                    string url = "http://photo.renren.com/photo/" + f.id + "/album-" + f.ablumIdList[m] + "?frommyphoto";
                    this.GetPhotoAddress(url, f);
                    string directoryPath = "I://lcj//" +friendId+"//"+ f.id + "//" + f.ablumIdList[m];
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);

                    }

                    for (int i = j; i < f.photoList.Count; i++)
                    {
                        try
                        {
                            Console.WriteLine(f.id + " " + f.ablumIdList[m] + " " + i.ToString() + " is downloading......");
                            WebClient photoClient = new WebClient();
                            string downloadPath = directoryPath + "//" + i.ToString() + ".jpg";

                            photoClient.DownloadFile(f.photoList[i], downloadPath);
                            Delay();
                            j++;
                        }
                        catch 
                        {
                            string filePath1 = "I://lcj//" + friendId + "error.txt";
                            StreamWriter sw1 = new StreamWriter(filePath1);
                            sw1.WriteLine(f.photoList[i]);
                            sw1.Close();
                            continue;
                        }

                    }
                    downloadedIdList.Add(f.id);
                    f.downloadedablumIdList.Add(f.ablumIdList[m]);
                    StreamWriter sw = new StreamWriter(filePath, true);
                    //sw.WriteLine("id " +f.id);
                    sw.WriteLine("album " + f.ablumIdList[m]);
                    DownloadedFileBox.Text += f.id+"  "+f.ablumIdList[m]+"\r\n";
                    sw.Close();
                    Console.WriteLine("download" + f.id + " " + f.ablumIdList[m] + " succssefully");
                    //Application.DoEvents();
                }

            }
        }

        private void GetPhotoAddress(string url,FileName f)
        {
            int start;
            int end = 0;
            GetHtml getHtml = new GetHtml(url, Cookiesstr, cc);
            List<string> albumIdList = new List<string>();
            string str = getHtml.GetHtmlMetheod();
            //Console.WriteLine(str);
            while (str != null)
            {
                start = str.IndexOf("large:'", end);
                if (start != -1)
                {
                    try
                    {
                        end = str.IndexOf("g'", start);
                        string address = str.Substring(start + 7, (end - start - 7));
                        address += "g";
                        f.photoList.Add(address);
                    }
                    catch
                    {
                        if (end == -1)
                        {
                            end = str.IndexOf("f'", start);
                            string address = str.Substring(start + 7, (end - start - 7));
                            address += "f";
                            f.photoList.Add(address);
                        }
                    }

                }
                else
                {
                    break;
                }

            }
        }

        private void Delay()
        {
            Random ran = new Random();
            int randkey = ran.Next(100, 900);
            System.Threading.Thread.Sleep(randkey);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ContinueDownloadButton_Click(object sender, EventArgs e)
        {
            int i=0;
            string filePath = "I://lcj//" + friendId + "downloaded.txt";
            StreamReader fr = new StreamReader(filePath);
            string sLine = "";
            while (sLine != null)
            {
                sLine = fr.ReadLine();
                if (sLine != null && !sLine.Equals(""))
                {
                    string[] fileStr = sLine.Split(new char[] { ' ' });
                    switch (fileStr[0])
                    {
                        case "id": friendNumber1++; nowFriendId = fileNameList[friendNumber1].id; break;
                        case "album": fileNameList[friendNumber1].downloadedablumIdList.Add(fileStr[1]); i++; break;

                    }
                }


            }
            fr.Close();
            for (int o = 0; o < friendNumber1; o++)
            {
                DownloadedIdBox.Text += fileNameList[o].id+"\r\n";
                if (fileNameList[o].ablumIdList.Count!=0)
                {
                for (int p = 0; p <fileNameList[o].ablumIdList.Count;p++ )
                    DownloadedFileBox.Text += fileNameList[o].id + "  " + fileNameList[o].ablumIdList[p] + "\r\n";
                }
            }
           
            if (i < fileNameList[friendNumber1].ablumIdList.Count)
            {
                for (int u = 0; u < i; u++)
                    DownloadedFileBox.Text += fileNameList[friendNumber1].id + "  " + fileNameList[friendNumber1].ablumIdList[u] + "\r\n";

                string deletePath = "I://lcj//" + friendId + "//" + fileNameList[friendNumber1].id + "//" + fileNameList[friendNumber1].ablumIdList[i];
                if (Directory.Exists(deletePath) == true)
                {
                    Directory.Delete(deletePath, true);
                }
            }
            else
            {
                friendNumber1++;
                i = 0;
                for (int n = friendNumber1, k = i; n < fileNameList.Count; n++, k = 0)
                {
                    NowDownloadingIdBox.Text = fileNameList[n].id;
                    Delay();
                    string filePath2 = "I://lcj//" + friendId + "downloaded.txt";
                    StreamWriter sw = new StreamWriter(filePath2, true);
                    sw.WriteLine("id " + fileNameList[n].id);
                    sw.Close();
                    Download(fileNameList[n], k);

                }
            }

        }

    }
    public class FileName
    {
        public string id;
        public List<string> ablumIdList = new List<string>();
        public List<string> photoList = new List<string>();
        public List<string> downloadedablumIdList = new List<string>();
        public List<string> downloadedphotoList = new List<string>();

        public FileName(string id)
        {
            this.id = id;


        }
    }
}
