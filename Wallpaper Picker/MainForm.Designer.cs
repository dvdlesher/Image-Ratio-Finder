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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTolerance1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxSubfolder = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTolerance2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAddPrev = new System.Windows.Forms.CheckBox();
            this.buttonAllRatio = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
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
            this.comboBox1.Enabled = false;
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
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(69, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(137, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 4;
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
            this.textBoxTolerance1.Enabled = false;
            this.textBoxTolerance1.Location = new System.Drawing.Point(347, 10);
            this.textBoxTolerance1.Name = "textBoxTolerance1";
            this.textBoxTolerance1.Size = new System.Drawing.Size(27, 20);
            this.textBoxTolerance1.TabIndex = 6;
            this.textBoxTolerance1.Text = "1";
            this.textBoxTolerance1.TextChanged += new System.EventHandler(this.textBoxTolerance1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxSubfolder
            // 
            this.checkBoxSubfolder.AutoSize = true;
            this.checkBoxSubfolder.Enabled = false;
            this.checkBoxSubfolder.Location = new System.Drawing.Point(12, 91);
            this.checkBoxSubfolder.Name = "checkBoxSubfolder";
            this.checkBoxSubfolder.Size = new System.Drawing.Size(223, 17);
            this.checkBoxSubfolder.TabIndex = 8;
            this.checkBoxSubfolder.Text = "Includes Subfolder? (not implemented yet)";
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
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(69, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(27, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 117);
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
            // checkBoxAddPrev
            // 
            this.checkBoxAddPrev.AutoSize = true;
            this.checkBoxAddPrev.Enabled = false;
            this.checkBoxAddPrev.Location = new System.Drawing.Point(307, 91);
            this.checkBoxAddPrev.Name = "checkBoxAddPrev";
            this.checkBoxAddPrev.Size = new System.Drawing.Size(128, 17);
            this.checkBoxAddPrev.TabIndex = 17;
            this.checkBoxAddPrev.Text = "Add Previous Result?";
            this.checkBoxAddPrev.UseVisualStyleBackColor = true;
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
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(413, 13);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(101, 13);
            this.infoLabel.TabIndex = 19;
            this.infoLabel.Text = "0.1% very restrictive";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "1% average";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "5% very tolerant";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "*Not Implemented Yet (click to enable debug)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 200);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.buttonAllRatio);
            this.Controls.Add(this.checkBoxAddPrev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTolerance2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSubfolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTolerance1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTolerance1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxSubfolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTolerance2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxAddPrev;
        private System.Windows.Forms.Button buttonAllRatio;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

