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
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            InitializeColumns();
        }

        private void AddName_Click(object sender, EventArgs e)
        {
            string[] entries = new string[3];
            entries[0] = WebsiteName.Text.Trim();
            entries[1] = EmailAddress.Text.Trim();
            entries[2] = Password.Text.Trim();
            string[] row = { entries[0], entries[1], entries[2] };
            table.Rows.Add(row);

            if (WebsiteName.Text != null)
                WebsiteName.Text = "";
            EmailAddress.Text = "";
            Password.Text = "";
            dataGridView1.DataSource = table;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // saving the file
            SaveFile(savefilePath);
        }

        private void DeleteEntryBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (item.Selected)
                    dataGridView1.Rows.RemoveAt(item.Index);
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
            using (TextWriter tw = new StreamWriter(filepath + savefileName))
            {
                for (int i = 0; i < table.Rows.Count; ++i)
                {
                    for (int j = 0; j < table.Columns.Count; ++j)
                    {
                        tw.Write(table.Rows[i].ItemArray[j].ToString());
                        if (j != table.Columns.Count)
                        {
                            tw.Write(" ");
                        }
                    }
                    tw.WriteLine();
                }
            }

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
                catch (Exception ex)
                {
                    Console.Write(ex.ToString(), "file is not able to be decrypted.");
                }

                string[] lines = File.ReadAllLines(savefilePath + savefileName);
                string[] values;

                for (int i = 0; i < lines.Length; ++i)
                {
                    values = lines[i].ToString().Split(' ');
                    string[] row = new string[values.Length - 1];
                    for (int j = 0; j < values.Length - 1; ++j)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);
                }
                dataGridView1.DataSource = table;

                }
        }

        private void InitializeColumns()
        {
            dataGridView1.AllowUserToAddRows = false;
            DataColumn column1 = new DataColumn();
            DataColumn column2 = new DataColumn();
            DataColumn column3 = new DataColumn();
            column1.ColumnName = "Website(optional)";
            column2.ColumnName = "Username/Email";
            column3.ColumnName = "Password";
            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);
            dataGridView1.DataSource = table;
        }

    }
}
