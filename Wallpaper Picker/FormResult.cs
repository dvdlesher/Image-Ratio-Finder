using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallpaper_Picker
{
    public partial class FormResult : Form
    {
        List<MatchedImages> matchedImages;
        Form prevForm;

        public FormResult()
        {
            InitializeComponent();
        }

        public FormResult(List<MatchedImages> matchedImages, Form prevForm)
        {
            InitializeComponent();
            this.matchedImages = matchedImages;
            this.prevForm = prevForm;
            label3.Text = matchedImages.Count.ToString();
            comboBoxPreviewSelect.SelectedIndex = 0;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            String fullpath, filename, foldername = "";
            Boolean flagMakeFolder = false;

            folderBrowserDialog1.ShowDialog();

            for (int i = 0; i < matchedImages.Count; i++)
            {
                fullpath = matchedImages[i].getfullPath();
                filename = matchedImages[i].getfullPath().Split('\\')[matchedImages[i].getfullPath().Split('\\').Length - 1];
                if (checkBox1.Checked)
                {
                    if (!flagMakeFolder) //only create subfolder once.
                    {
                        foldername = subfolderName(matchedImages[i]);
                        try
                        {
                            Directory.CreateDirectory(folderBrowserDialog1.SelectedPath + "\\" + subfolderName(matchedImages[i]));
                        }
                        catch (Exception ex) { }
                        flagMakeFolder = true;

                    }
                    secureCopyMove("Copy", fullpath, folderBrowserDialog1.SelectedPath + "\\" + foldername + "\\" + filename);
                }
                else
                {
                    secureCopyMove("Copy", fullpath, folderBrowserDialog1.SelectedPath + "\\" + filename);
                }
            }
            MessageBox.Show("Copying Finished!");
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            String fullpath, filename, foldername = "";
            Boolean flagMakeFolder = false;

            folderBrowserDialog1.ShowDialog();

            for (int i = 0; i < matchedImages.Count; i++)
            {
                fullpath = matchedImages[i].getfullPath();
                filename = matchedImages[i].getfullPath().Split('\\')[matchedImages[i].getfullPath().Split('\\').Length - 1];
                if (checkBox1.Checked)
                {
                    if (!flagMakeFolder) //only create subfolder once.
                    {
                        foldername = subfolderName(matchedImages[i]);
                        try
                        {
                            Directory.CreateDirectory(folderBrowserDialog1.SelectedPath + "\\" + foldername);
                        }
                        catch (Exception ex) { }
                        flagMakeFolder = true;
                    }
                    secureCopyMove("Move", fullpath, folderBrowserDialog1.SelectedPath + "\\" + foldername + "\\" + filename);
                }
                else
                {
                    secureCopyMove("Move", fullpath, folderBrowserDialog1.SelectedPath + "\\" + filename);
                }
            }
            MessageBox.Show("Moving finished!");
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayForm dispWindow = new DisplayForm(matchedImages, this, comboBoxPreviewSelect.SelectedItem.ToString());
            dispWindow.Show();
            this.Hide();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\" + "Match Output.txt"))
            {
                System.IO.File.Create(System.IO.Directory.GetCurrentDirectory() + "\\" + "Match Output.txt");
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Match Output.txt"))
            {
                if (checkBox2.Checked)
                {
                    for (int i = 0; i < matchedImages.Count; i++)
                    {
                        file.WriteLine(matchedImages[i].fullPath.Split('\\')[matchedImages[i].getfullPath().Split('\\').Length - 1]);
                    } 
                }
                else
                {
                    for (int i = 0; i < matchedImages.Count; i++)
                    {
                        file.WriteLine(matchedImages[i].fullPath);
                    }
                }
                
            }

            MessageBox.Show("Export finished! Results are written in \"Data Output.txt\".");
        }

        // Call this function to copy/paste + create folder if it doesn't exist
        private void secureCopyMove(String command, String inputFile, String destFile, String destDir)
        {
            if (command.Equals("Copy"))
            {
                try
                {
                    Directory.CreateDirectory(destDir);
                    File.Copy(inputFile, destFile);
                }
                catch (Exception e) { }
            }
            else if (command.Equals("Move") || command.Equals("Cut"))
            {
                try
                {
                    Directory.CreateDirectory(destDir);
                    File.Move(inputFile, destFile);
                }
                catch (Exception e) { }
            }
        }

        // Call this function to copy/paste, but without creating folder if it doesn't exist
        private void secureCopyMove(String command, String inputFile, String destFile)
        {
            if (command.Equals("Copy"))
            {
                try
                {
                    File.Copy(inputFile, destFile);
                }
                catch (Exception e) { }
            }
            else if (command.Equals("Move") || command.Equals("Cut"))
            {
                try
                {
                    File.Move(inputFile, destFile);
                }
                catch (Exception e) { }
            }
        }

        private void FormResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Show();
        }

        private void comboBoxPreviewSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPreviewSelect.SelectedIndex == 0)
            {
                DisplayButton.Enabled = false;
            }
            else
            {
                DisplayButton.Enabled = true;
            }
        }

        private string subfolderName(MatchedImages input)
        {
            if (String.Equals(input.testBased, "ratio"))
            {
                return input.ratio.Replace(":", "꞉");
            }
            else if (String.Equals(input.testBased, "size"))
            {
                return input.size;
            }
            else // last case: "both"
            {
                return input.ratio.Replace(":", "꞉") + ", " + input.size;
            }
        }
    }
}
