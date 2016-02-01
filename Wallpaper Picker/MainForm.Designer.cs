namespace Wallpaper_Picker
{
    partial class MainForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTolerance1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.checkBoxSubfolder = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.recursionTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTolerance2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAllRatio = new System.Windows.Forms.Button();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ratio";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 39);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Size";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4:3 (800x600, 1024x768)",
            "16:9 (720p, 1080p)",
            "16:10 (1200p)",
            "30:17 (PSVITA, PSP)"});
            this.comboBox1.Location = new System.Drawing.Point(69, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "16:9 (720p, 1080p)";
            // 
            // widthTextbox
            // 
            this.widthTextbox.Enabled = false;
            this.widthTextbox.Location = new System.Drawing.Point(69, 37);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(54, 20);
            this.widthTextbox.TabIndex = 3;
            // 
            // heightTextbox
            // 
            this.heightTextbox.Enabled = false;
            this.heightTextbox.Location = new System.Drawing.Point(137, 37);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(53, 20);
            this.heightTextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tolerance";
            // 
            // textBoxTolerance1
            // 
            this.textBoxTolerance1.Location = new System.Drawing.Point(347, 10);
            this.textBoxTolerance1.Name = "textBoxTolerance1";
            this.textBoxTolerance1.Size = new System.Drawing.Size(27, 20);
            this.textBoxTolerance1.TabIndex = 6;
            this.textBoxTolerance1.Text = "1";
            this.textBoxTolerance1.TextChanged += new System.EventHandler(this.textBoxTolerance1_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 165);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(187, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // checkBoxSubfolder
            // 
            this.checkBoxSubfolder.AutoSize = true;
            this.checkBoxSubfolder.Location = new System.Drawing.Point(15, 120);
            this.checkBoxSubfolder.Name = "checkBoxSubfolder";
            this.checkBoxSubfolder.Size = new System.Drawing.Size(114, 17);
            this.checkBoxSubfolder.TabIndex = 8;
            this.checkBoxSubfolder.Text = "Includes Subfolder";
            this.checkBoxSubfolder.UseVisualStyleBackColor = true;
            this.checkBoxSubfolder.CheckedChanged += new System.EventHandler(this.checkBoxSubfolder_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "%";
            // 
            // recursionTextbox
            // 
            this.recursionTextbox.Enabled = false;
            this.recursionTextbox.Location = new System.Drawing.Point(72, 143);
            this.recursionTextbox.Name = "recursionTextbox";
            this.recursionTextbox.Size = new System.Drawing.Size(27, 20);
            this.recursionTextbox.TabIndex = 12;
            this.recursionTextbox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "(0 for infinite)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "%";
            // 
            // textBoxTolerance2
            // 
            this.textBoxTolerance2.Enabled = false;
            this.textBoxTolerance2.Location = new System.Drawing.Point(347, 37);
            this.textBoxTolerance2.Name = "textBoxTolerance2";
            this.textBoxTolerance2.Size = new System.Drawing.Size(27, 20);
            this.textBoxTolerance2.TabIndex = 15;
            this.textBoxTolerance2.Text = "1";
            this.textBoxTolerance2.TextChanged += new System.EventHandler(this.textBoxTolerance2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tolerance";
            // 
            // buttonAllRatio
            // 
            this.buttonAllRatio.Enabled = false;
            this.buttonAllRatio.Location = new System.Drawing.Point(307, 165);
            this.buttonAllRatio.Name = "buttonAllRatio";
            this.buttonAllRatio.Size = new System.Drawing.Size(221, 23);
            this.buttonAllRatio.TabIndex = 18;
            this.buttonAllRatio.Text = "Multi-Custom Search";
            this.buttonAllRatio.UseVisualStyleBackColor = true;
            this.buttonAllRatio.Click += new System.EventHandler(this.buttonAllRatio_Click);
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Location = new System.Drawing.Point(413, 13);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(101, 13);
            this.infoLabel1.TabIndex = 19;
            this.infoLabel1.Text = "0.1% very restrictive";
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Location = new System.Drawing.Point(413, 30);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(63, 13);
            this.infoLabel2.TabIndex = 20;
            this.infoLabel2.Text = "1% average";
            // 
            // infoLabel3
            // 
            this.infoLabel3.AutoSize = true;
            this.infoLabel3.Location = new System.Drawing.Point(413, 47);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(82, 13);
            this.infoLabel3.TabIndex = 21;
            this.infoLabel3.Text = "5% very tolerant";
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(307, 146);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(221, 13);
            this.debugLabel.TabIndex = 22;
            this.debugLabel.Text = "*Not Implemented Yet (click to enable debug)";
            this.debugLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 200);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.buttonAllRatio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTolerance2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.recursionTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSubfolder);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBoxTolerance1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.widthTextbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "MainForm";
            this.Text = "WP Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTolerance1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox checkBoxSubfolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox recursionTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTolerance2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAllRatio;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label debugLabel;
    }
}

