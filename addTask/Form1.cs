using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var a = this.Controls;
        }


        public void DownloadFile(string url, string fileName, int index = 0)
        {
            WebClient client = new WebClient();
            var gb = this.Controls.Find($"groupBox{index}", false).First() as GroupBox;
            Thread thread = new Thread(() => {
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler((s,e) => 
                {
                    BeginInvoke((MethodInvoker)delegate {
                        double percentage = e.ProgressPercentage;
                        var p = gb.Controls.Find($"progressBar{index}", false).First() as ProgressBar;
                        p.Value = int.Parse(Math.Truncate(percentage).ToString());
                    });
                });
                client.DownloadFileCompleted += new AsyncCompletedEventHandler((s,e) => 
                {
                    var lb = gb.Controls.Find($"label0{index}", false).First() as Label;
                    BeginInvoke((MethodInvoker)delegate {
                        lb.Text = "Загружено";
                    });
                });
                client.DownloadFileAsync(new Uri(url), @"C:\Users\Котя\Documents\DownloadHere\" + fileName);
            });
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = url1.Text.ToString();
            string fileName = title1.Text.ToString();
            DownloadFile(url, fileName, 1);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = url2.Text.ToString();
            string fileName = title2.Text.ToString();
            DownloadFile(url, fileName, 2);
        }         

        public bool CheckEnabled(GroupBox gb)
        {
            foreach (TextBox tbs in gb.Controls.OfType<TextBox>())
            {
                if (tbs.Text == string.Empty) return false;                
            }
            return true;
        }        

        private void url1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = CheckEnabled(groupBox1);
        }

        private void title1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = CheckEnabled(groupBox1);
        }

        private void url2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = CheckEnabled(groupBox2);
        }

        private void title2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = CheckEnabled(groupBox2);
        }        
    }
}
