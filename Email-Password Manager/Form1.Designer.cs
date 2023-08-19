namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WebsiteName = new System.Windows.Forms.TextBox();
            this.AddEntryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteEntryBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // WebsiteName
            // 
            this.WebsiteName.Location = new System.Drawing.Point(53, 46);
            this.WebsiteName.Name = "WebsiteName";
            this.WebsiteName.Size = new System.Drawing.Size(199, 22);
            this.WebsiteName.TabIndex = 0;
            // 
            // AddEntryBtn
            // 
            this.AddEntryBtn.Location = new System.Drawing.Point(7, 251);
            this.AddEntryBtn.Name = "AddEntryBtn";
            this.AddEntryBtn.Size = new System.Drawing.Size(76, 23);
            this.AddEntryBtn.TabIndex = 1;
            this.AddEntryBtn.Text = "Add Entry";
            this.AddEntryBtn.UseVisualStyleBackColor = true;
            this.AddEntryBtn.Click += new System.EventHandler(this.AddName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Website(optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email/Username";
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(53, 114);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(198, 22);
            this.EmailAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(53, 178);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(198, 22);
            this.Password.TabIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(7, 349);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 23);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteEntryBtn
            // 
            this.DeleteEntryBtn.Location = new System.Drawing.Point(89, 251);
            this.DeleteEntryBtn.Name = "DeleteEntryBtn";
            this.DeleteEntryBtn.Size = new System.Drawing.Size(95, 23);
            this.DeleteEntryBtn.TabIndex = 10;
            this.DeleteEntryBtn.Text = "Delete Entry";
            this.DeleteEntryBtn.UseVisualStyleBackColor = true;
            this.DeleteEntryBtn.Click += new System.EventHandler(this.DeleteEntryBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(166, 349);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(107, 23);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(362, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 426);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.DeleteEntryBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEntryBtn);
            this.Controls.Add(this.WebsiteName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WebsiteName;
        private System.Windows.Forms.Button AddEntryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteEntryBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ListView listView1;
    }
}

