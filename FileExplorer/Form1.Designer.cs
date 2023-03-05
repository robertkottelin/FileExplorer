namespace FileExplorer
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
            this.button_Desktop = new System.Windows.Forms.Button();
            this.button_Documents = new System.Windows.Forms.Button();
            this.button_Pictures = new System.Windows.Forms.Button();
            this.button_Music = new System.Windows.Forms.Button();
            this.button_Videos = new System.Windows.Forms.Button();
            this.panel_FilesList = new System.Windows.Forms.FlowLayoutPanel();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Desktop
            // 
            this.button_Desktop.Location = new System.Drawing.Point(12, 4);
            this.button_Desktop.Name = "button_Desktop";
            this.button_Desktop.Size = new System.Drawing.Size(101, 54);
            this.button_Desktop.TabIndex = 0;
            this.button_Desktop.Text = "Desktop";
            this.button_Desktop.UseVisualStyleBackColor = true;
            this.button_Desktop.Click += new System.EventHandler(this.button_Desktop_Click);
            // 
            // button_Documents
            // 
            this.button_Documents.Location = new System.Drawing.Point(12, 64);
            this.button_Documents.Name = "button_Documents";
            this.button_Documents.Size = new System.Drawing.Size(101, 54);
            this.button_Documents.TabIndex = 1;
            this.button_Documents.Text = "My Documents";
            this.button_Documents.UseVisualStyleBackColor = true;
            this.button_Documents.Click += new System.EventHandler(this.button_Documents_Click);
            // 
            // button_Pictures
            // 
            this.button_Pictures.Location = new System.Drawing.Point(12, 124);
            this.button_Pictures.Name = "button_Pictures";
            this.button_Pictures.Size = new System.Drawing.Size(101, 54);
            this.button_Pictures.TabIndex = 2;
            this.button_Pictures.Text = "Pictures";
            this.button_Pictures.UseVisualStyleBackColor = true;
            this.button_Pictures.Click += new System.EventHandler(this.button_Pictures_Click);
            // 
            // button_Music
            // 
            this.button_Music.Location = new System.Drawing.Point(12, 184);
            this.button_Music.Name = "button_Music";
            this.button_Music.Size = new System.Drawing.Size(101, 54);
            this.button_Music.TabIndex = 3;
            this.button_Music.Text = "Music";
            this.button_Music.UseVisualStyleBackColor = true;
            this.button_Music.Click += new System.EventHandler(this.button_Music_Click);
            // 
            // button_Videos
            // 
            this.button_Videos.Location = new System.Drawing.Point(12, 244);
            this.button_Videos.Name = "button_Videos";
            this.button_Videos.Size = new System.Drawing.Size(101, 54);
            this.button_Videos.TabIndex = 4;
            this.button_Videos.Text = "Videos";
            this.button_Videos.UseVisualStyleBackColor = true;
            this.button_Videos.Click += new System.EventHandler(this.button_Videos_Click);
            // 
            // panel_FilesList
            // 
            this.panel_FilesList.Location = new System.Drawing.Point(119, 37);
            this.panel_FilesList.Name = "panel_FilesList";
            this.panel_FilesList.Size = new System.Drawing.Size(587, 351);
            this.panel_FilesList.TabIndex = 5;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(119, 8);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel_FilesList);
            this.Controls.Add(this.button_Videos);
            this.Controls.Add(this.button_Music);
            this.Controls.Add(this.button_Pictures);
            this.Controls.Add(this.button_Documents);
            this.Controls.Add(this.button_Desktop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Desktop;
        private System.Windows.Forms.Button button_Documents;
        private System.Windows.Forms.Button button_Pictures;
        private System.Windows.Forms.Button button_Music;
        private System.Windows.Forms.Button button_Videos;
        private System.Windows.Forms.FlowLayoutPanel panel_FilesList;
        private System.Windows.Forms.Button back;
    }
}

