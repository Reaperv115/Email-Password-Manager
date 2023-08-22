using System;
using System.Data;
using System.IO;
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
        string savefileName = "/savefile.docx";
        string savefilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public Form1()
        {
            InitializeComponent();
            InitializeColumns();
            //listView1.View = View.Details;
            //listView1.LabelEdit = true;
            //listView1.Columns.Add("Website(optional)", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("Username/Email", 130, HorizontalAlignment.Left);
            //listView1.Columns.Add("Password", -2, HorizontalAlignment.Left);
        }

        private void AddName_Click(object sender, EventArgs e)
        {
            string[] entries = new string[3];
            entries[0] = EmailAddress.Text.Trim();
            entries[1] = Password.Text.Trim();
            entries[2] = Password.Text.Trim();
            string[] row = { entries[0], entries[1], entries[2] };
            dataGridView1.Rows.Add(row);

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
            //foreach (ListViewItem item in listView1.Items)
            //{
            //    if (item.Selected)
            //        listView1.Items.RemoveAt(item.Index);
            //}
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
            //foreach (object obj in listView1.Items)
            //{
            //    streamWriter.WriteLine(obj.ToString());
            //}
            try
            {
                File.Encrypt(filepath + savefileName);
            }
            catch (Exception ex) 
            { 
                Console.Write(ex.ToString(), "file is not able to be encrypted.");
                Console.Write("You must be running the pro version of windows 11 to encrypt files.");
            }
            streamWriter.Close();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(savefilePath + savefileName))
                Console.WriteLine("Error: file does not exist");
            else
            {
                try
                {
                    File.Decrypt(savefilePath + savefileName);
                }
                catch(Exception ex) 
                {
                    
                    Console.Write(ex.ToString(), "file is not able to be decrypted.");
                }
                FileStream fileStream = File.OpenRead(savefilePath + savefileName);
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line;
                    //while ((line = streamReader.ReadLine()) != null)
                    //    listView1.Items.Add(line);
                }
            }
        }

        private void InitializeColumns()
        {
            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column1.Name = "Website(optional)";
            column2.Name = "Username/Email";
            column3.Name = "Password";
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
        }
        
    }
}
