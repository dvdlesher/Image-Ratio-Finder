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
            String fullpath;
            String filename;
            folderBrowserDialog1.ShowDialog();
            for (int i = 0; i < matchedImages.Count; i++)
            {
                fullpath = matchedImages[i].getfullPath();
                filename = matchedImages[i].getfullPath().Split('\\')[matchedImages[i].getfullPath().Split('\\').Length - 1];
                if (checkBox1.Checked)
                {
                    secureCopyMove("Copy", fullpath, folderBrowserDialog1.SelectedPath + "\\" + matchedImages[i].getratio().Replace(":", "x") + "\\" + filename, folderBrowserDialog1.SelectedPath + "\\" + matchedImages[i].getratio().Replace(":", "x"));
                }
                else
                {
                    secureCopyMove("Copy", fullpath, folderBrowserDialog1.SelectedPath + "\\" + filename);
                }
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            String fullpath;
            String filename;
            folderBrowserDialog1.ShowDialog();
            for (int i = 0; i < matchedImages.Count; i++)
            {
                fullpath = matchedImages[i].getfullPath();
                filename = matchedImages[i].getfullPath().Split('\\')[matchedImages[i].getfullPath().Split('\\').Length - 1];
                if (checkBox1.Checked)
                {
                    secureCopyMove("Move", fullpath, folderBrowserDialog1.SelectedPath + "\\" + matchedImages[i].getratio().Replace(":", "꞉") + "\\" + filename, folderBrowserDialog1.SelectedPath + "\\" + matchedImages[i].getratio().Replace(":", "꞉"));
                }
                else
                {
                    secureCopyMove("Move", fullpath, folderBrowserDialog1.SelectedPath + "\\" + filename);
                }
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayForm dispWindow = new DisplayForm(matchedImages, this, comboBoxPreviewSelect.SelectedItem.ToString());
            dispWindow.Show();
            this.Hide();
        }

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
    }
}
