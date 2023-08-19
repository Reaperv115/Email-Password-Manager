using System;
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
        MouseButtons mouseButtons = MouseButtons.None;
        Entry entry;
        string savefileName = "/savefile.docx";
        string savefilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public Form1()
        {
            InitializeComponent();
            listView1.Items.Clear();
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
                listView1.Items.Add(entry.websiteOpt);
            }
            listView1.Items.Add(entry.email);
            listView1.Items.Add(entry.passWord);
            listView1.Items.Add(space);

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
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                    listView1.Items.RemoveAt(item.Index);
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
            foreach (object obj in listView1.Items)
            {
                streamWriter.WriteLine(obj.ToString());
            }
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
                    while ((line = streamReader.ReadLine()) != null)
                        listView1.Items.Add(line);
                }
            }
        }


        
    }
}
