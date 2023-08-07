﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    struct Entry
    {
        public string websiteOpt;
        public string email;
        public string passWord;
    }
    public partial class Form1 : Form
    {
        Entry entry;
        string savefileName = "/savefile.docx";
        string savefilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
        }

        private void AddName_Click(object sender, EventArgs e)
        {
            entry = new Entry();
            entry.email = EmailAddress.Text;
            entry.passWord = Password.Text;
            string space = "";
            if (WebsiteName.Text != null)
            {
                entry.websiteOpt = WebsiteName.Text;
                listBox1.Items.Add(entry.websiteOpt);
            }
            listBox1.Items.Add(entry.email);
            listBox1.Items.Add(entry.passWord);
            listBox1.Items.Add(space);

            if (WebsiteName.Text != null)
                WebsiteName.Text = "";
            EmailAddress.Text = "";
            Password.Text = "";

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // saving the file
            SaveFile(savefilePath);
        }

        private void DeleteEntryBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                Console.WriteLine("please elect an item first");
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        
        // if the file already exists,
        //then delete and override it.
        void SaveFile(string filepath)
        {
            if (File.Exists(filepath + savefileName))
            {
                Console.WriteLine("deleting file");
                File.Delete(filepath + savefileName);
            }

            File.Create(filepath + savefileName).Dispose();
            StreamWriter streamWriter = new StreamWriter(filepath + savefileName, false);
            foreach (object obj in listBox1.Items)
            {
                streamWriter.WriteLine(obj.ToString());
            }
            File.Encrypt(filepath + savefileName);
            streamWriter.Close();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(savefilePath + savefileName))
                Console.WriteLine("Error: file does not exist");
            else
            {
                File.Decrypt(savefilePath + savefileName);
                FileStream fileStream = File.OpenRead(savefilePath + savefileName);
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                        listBox1.Items.Add(line);
                }
            }
        }
    }
}