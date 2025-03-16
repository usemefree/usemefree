using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CommonFun;
using Newtonsoft.Json;

namespace usemefreeHttpClient
{
    public partial class Frm_FtpUpload : Form
    {
        FtpClient ftpClient;
        string ftpServer = string.Empty;
        string user = string.Empty;
        string pwd = string.Empty;
        string remoteDirectory = string.Empty;
        public Frm_FtpUpload()
        {
            InitializeComponent();
            ftpClient = new FtpClient();
        }

        private void Frm_FtpUpload_Load(object sender, EventArgs e)
        {
            ftpServer = ConfigurationManager.AppSettings["ftpServer"];
            user = ConfigurationManager.AppSettings["user"];
            pwd = ConfigurationManager.AppSettings["pwd"];
            remoteDirectory = ConfigurationManager.AppSettings["remoteDirectory"];

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ftpServer))
            {
                MessageBox.Show("ftp Server not empty; ");
                return;
            }
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("user not empty; ");
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("pwd not empty; ");
                return;

            }
            if (string.IsNullOrEmpty(remoteDirectory))
            {
                MessageBox.Show("remoteDirectory not empty; ");
                return;
            }
            if (string.IsNullOrEmpty(txt_ftpFile.Text))
            {
                MessageBox.Show("ftp serger file is reqired ");
                return;
            }
            if (string.IsNullOrEmpty(txt_LocalPath.Text))
            {
                MessageBox.Show("local path is required ");
                return;
            }
            if (string.IsNullOrEmpty(txt_LocalFile.Text))
            {
                MessageBox.Show("local file is required ");
                return;
            }
            ftpClient.upload(ftpServer, remoteDirectory, user, pwd, Path.Combine(txt_LocalPath.Text, txt_LocalFile.Text));


        }

        private void btn_SelectLocalFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "json file (*.json)|*.json";
            openFileDialog.Title = "Select a json file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_LocalPath.Text = openFileDialog.FileName.Substring(0, openFileDialog.FileName.LastIndexOf('\\'));
                txt_LocalFile.Text = openFileDialog.FileName.Substring( openFileDialog.FileName.LastIndexOf('\\')+1); ;
            }

            
        }
    }
}
