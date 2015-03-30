namespace Wallpaper_Picker
{
    partial class FormResult
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
            this.copyButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBoxPreviewSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(12, 55);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(243, 23);
            this.copyButton.TabIndex = 0;
            this.copyButton.Text = "Copy to location";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(12, 84);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(243, 23);
            this.moveButton.TabIndex = 1;
            this.moveButton.Text = "Move to location";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(12, 113);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(116, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Results found:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "What do you want to do with the matched images?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NUMBER";
            // 
            // comboBoxPreviewSelect
            // 
            this.comboBoxPreviewSelect.FormattingEnabled = true;
            this.comboBoxPreviewSelect.Items.AddRange(new object[] {
            "Select Preview Size",
            "16x16",
            "32x32",
            "64x64",
            "128x128",
            "256x256",
            "512x512",
            "800x800"});
            this.comboBoxPreviewSelect.Location = new System.Drawing.Point(134, 115);
            this.comboBoxPreviewSelect.Name = "comboBoxPreviewSelect";
            this.comboBoxPreviewSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPreviewSelect.TabIndex = 6;
            this.comboBoxPreviewSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxPreviewSelect_SelectedIndexChanged);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 148);
            this.Controls.Add(this.comboBoxPreviewSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.copyButton);
            this.Name = "FormResult";
            this.Text = "FormResult";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormResult_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBoxPreviewSelect;
    }
}