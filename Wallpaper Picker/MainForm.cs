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
    public partial class MainForm : Form
    {

        private double lowerToleranceRatio;
        private double upperToleranceRatio;
        private double lowerToleranceSize;
        private double upperToleranceSize;
        private List<MatchedImages> matchedImages;
        private List<String> dirList;

        public MainForm()
        {
            InitializeComponent();
            lowerToleranceRatio = 1.0 - (Double.Parse(textBoxTolerance1.Text) / 100.0);
            upperToleranceRatio = 1.0 + (Double.Parse(textBoxTolerance1.Text) / 100.0);
            lowerToleranceSize = 1.0 - (Double.Parse(textBoxTolerance2.Text) / 100.0);
            upperToleranceSize = 1.0 + (Double.Parse(textBoxTolerance2.Text) / 100.0);
            matchedImages = new List<MatchedImages>();
            dirList = new List<String>();
            comboBox1.SelectedIndex = 1;
            folderBrowserDialog1.SelectedPath = System.IO.Directory.GetCurrentDirectory();
        }



        ///////////////////////
        // Component Handler //
        ///////////////////////

        // Ratio Option
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            searchButtonCheck();
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
                textBoxTolerance1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                textBoxTolerance1.Enabled = false;
            }

        }

        // Size Option
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            searchButtonCheck();
            if (checkBox2.Checked)
            {
                widthTextbox.Enabled = true;
                heightTextbox.Enabled = true;
                textBoxTolerance2.Enabled = true;
            }
            else
            {
                widthTextbox.Enabled = false;
                heightTextbox.Enabled = false;
                textBoxTolerance2.Enabled = false;
            }
        }

        private void searchButtonCheck()
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                searchButton.Enabled = true;
            }
            else
            {
                searchButton.Enabled = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String ratio = comboBox1.SelectedItem.ToString().Split(' ')[0];

            //NOT DONE: pointing at current location
            if (!(folderBrowserDialog1.ShowDialog() == DialogResult.Cancel) && !String.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                dirList.Clear(); //empty dirList for subdirectories search
                dirList.TrimExcess(); //empty dirList for subdirectories search
                matchedImages.Clear(); //empty matchedImages for the images search
                matchedImages.TrimExcess(); //empty dirList for the images search

                dirList.Add(folderBrowserDialog1.SelectedPath);
                // Store all subfolders in dirList List
                if (checkBoxSubfolder.Checked)
                {
                    if (int.Parse(recursionTextbox.Text) == 0)
                    {
                        recursiveDirSearch(folderBrowserDialog1.SelectedPath, 999);
                    }
                    else
                    {
                        recursiveDirSearch(folderBrowserDialog1.SelectedPath, int.Parse(recursionTextbox.Text));
                    }
                }

                foreach (string dirs in dirList)
                {
                    searchFunction(dirs, ratio);
                }
                callResultDialog();
            }
        }

        private void recursiveDirSearch(string dirPath, int recursionNum)
        {
            if (Directory.GetDirectories(dirPath).Length != 0)
            {
                recursionNum--;
            }

            if (recursionNum >= 0)
            {
                foreach (string res in Directory.GetDirectories(dirPath))
                {
                    dirList.Add(res);
                    recursiveDirSearch(res, recursionNum);
                }
            }
        }

        private void ratioFinderButton_Click(object sender, EventArgs e)
        {
            // Call another form, informing all of the images and their associated ratio in table
            // Have a feature so that the result can be pasted as txt or csv
        }

        
        private void buttonAllRatio_Click(object sender, EventArgs e)
        {
            String ratio;
            folderBrowserDialog1.ShowDialog();
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                ratio = comboBox1.Items[i].ToString().Split(' ')[0];
                searchFunction(folderBrowserDialog1.SelectedPath, ratio);
            }
            callResultDialog();

        }
        

        private void textBoxTolerance1_TextChanged(object sender, EventArgs e)
        {
            lowerToleranceRatio = 1.0 - (Double.Parse(textBoxTolerance1.Text) / 100.0);
            upperToleranceRatio = 1.0 + (Double.Parse(textBoxTolerance1.Text) / 100.0);
        }

        private void textBoxTolerance2_TextChanged(object sender, EventArgs e)
        {
            lowerToleranceSize = 1.0 - (Double.Parse(textBoxTolerance2.Text) / 100.0);
            upperToleranceSize = 1.0 + (Double.Parse(textBoxTolerance2.Text) / 100.0);
        }

        ///////////////////////
        //// MAIN FUNCTION ////
        ///////////////////////

        // Check if subfolder option is checked or not.
        private void searchFunction(string path, string ratio)
        {
            String[] list;
            if (checkBoxSubfolder.Checked) //Case if subfolder option is checked
            {
                list = Directory.GetDirectories(path);
                if (list.Length == 0)
                {
                    checkImages(path, ratio);
                }
                else
                {
                    foreach (string element in list)
                    {
                        searchFunction(element, ratio);
                    }
                    checkImages(path, ratio);
                }
            }
            else //Case if subfolder option is not checked
            {
                checkImages(path, ratio);
            }
        }

        //
        private void checkImages(String path, String ratio)
        {
            String[] imageList = Directory.GetFiles(path);
            Double ratioValue;
            Image tempImageObject;
            Boolean ratioFlag;
            Boolean sizeFlag;
            MatchedImages temp;
            String testBase; //"ratio" for ratio only search. "size" for size only search. "both" for both type search

            if (checkBox1.Checked && checkBox2.Checked){
                testBase = "both";
            }
            else if (checkBox1.Checked)
            {
                testBase = "ratio";
            }
            else
            {
                testBase = "size";
            }

            foreach (string element in imageList)
            {
                ratioFlag = false;
                sizeFlag = false;

                if (element.EndsWith("png") || element.EndsWith("gif") || element.EndsWith("jpg") || element.EndsWith("bmp"))
                {
                    using (FileStream fs = new FileStream(element, FileMode.Open, FileAccess.Read))
                    {
                        using (tempImageObject = Image.FromStream(fs))
                        {
                            if (!checkBox1.Checked && !checkBox2.Checked) { } else { 
                                if (checkBox1.Checked)
                                {
                                    ratioValue = Double.Parse(ratio.Split(':')[0]) / Double.Parse(ratio.Split(':')[1]);
                                    ratioFlag = ratioTest(tempImageObject.Height, tempImageObject.Width, ratioValue);
                                }
                                else { ratioFlag = true; }

                                if (checkBox2.Checked)
                                {
                                    sizeFlag = sizeTest(tempImageObject.Height, tempImageObject.Width);
                                }
                                else { sizeFlag = true; }

                                if (ratioFlag && sizeFlag)
                                {
                                    temp = new MatchedImages(element, ratio, (widthTextbox.Text + "x" + heightTextbox.Text), testBase);
                                    matchedImages.Add(temp);

                                }
                            }
                        }
                    }
                }
            }
        }

        // Test if image ratio matches the ratio or not.
        private bool ratioTest(int imageHeight, int imageWidth, double targetRatio)
        {
            String ratioText = comboBox1.GetItemText(comboBox1.SelectedItem).Split(' ')[0];
            double imageRatio = Convert.ToDouble(imageWidth) / Convert.ToDouble(imageHeight);

            if (imageRatio > lowerToleranceRatio * targetRatio && imageRatio < upperToleranceRatio * targetRatio)
            {
                return true;
            }
            
            return false;
        }

        // Test if image size matches the target size or not.
        private bool sizeTest(int imageHeight, int imageWidth)
        {
            if (String.IsNullOrEmpty(widthTextbox.Text))
            {
                widthTextbox.Text = "0";
            }

            if (String.IsNullOrEmpty(heightTextbox.Text))
            {
                heightTextbox.Text = "0";
            }

            if (imageWidth > lowerToleranceSize * Double.Parse(widthTextbox.Text) && imageWidth < upperToleranceSize * Double.Parse(widthTextbox.Text))
            {
                if (imageHeight > lowerToleranceSize * Double.Parse(heightTextbox.Text) && imageHeight < upperToleranceSize * Double.Parse(heightTextbox.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private void callResultDialog()
        {
            FormResult resultWindow = new FormResult(matchedImages, this);
            resultWindow.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            buttonAllRatio.Enabled = true;
        }

        private void checkBoxSubfolder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSubfolder.Checked)
            {
                recursionTextbox.Enabled = true;
            } 
            else 
            {
                recursionTextbox.Enabled = false;
            }
        }
    }
}
