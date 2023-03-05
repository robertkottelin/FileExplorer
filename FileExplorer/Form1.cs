using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        string currentLocation;

        public Form1()
        {
            
            InitializeComponent();
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void DisplayFiles(string filePath)
        {
            try
            {
                // Code to display the files and folders inside the directory
                string[] filesList = Directory.GetDirectories(filePath).Concat(Directory.GetFiles(filePath)).ToArray();
                panel_FilesList.Controls.Clear();
                currentLocation = filePath;
                currentDirectory.Text = currentLocation.ToString();
                string stringcurrentLocation = "";

                // Display the contents of the filesList array
                //MessageBox.Show(string.Join(Environment.NewLine, filesList));

                for (int i = 0; i < filesList.Length - 1; i++)
                {
                    bool isHidden = ((File.GetAttributes(filesList[i]) & FileAttributes.Hidden) == FileAttributes.Hidden);

                    if (!isHidden)
                    {
                        // Get the name of the file from the path
                        var startOfName = filesList[i].LastIndexOf("\\");
                        var fileName = filesList[i].Substring(startOfName + 1, filesList[i].Length - (startOfName + 1));

                        // Display the file or folder as a button
                        Button newButton = new Button();
                        newButton.Text = fileName;
                        newButton.Name = filesList[i];
                        newButton.Location = new Point(70, 70);
                        newButton.Size = new Size(800, 50);
                        newButton.TextAlign = ContentAlignment.MiddleLeft;
                        newButton.Padding = new Padding(24, 0, 0, 0);
                        newButton.Click += button_Click_Open;
                        panel_FilesList.Controls.Add(newButton);
                        panel_FilesList.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                // Display the exception message in a MessageBox
                MessageBox.Show(ex.Message);
            }
        }


        private void button_Click_Open(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string filePath = button.Name;

            try
            {
                // If a directory clicked, reload list of files in new directory
                DisplayFiles(filePath);
            }
            catch (Exception ex)
            {
                // If file clicked, open the file
                var process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = filePath };
                process.Start();
            }
        }

        private void button_Desktop_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void button_Documents_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void button_Pictures_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }

        private void button_Music_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }

        private void button_Videos_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var previousFolder = this.currentLocation.Substring(0, this.currentLocation.LastIndexOf("\\"));
                DisplayFiles(previousFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't go further back");
            }
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");

        }
    }
}
