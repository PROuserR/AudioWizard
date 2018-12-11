namespace AudioWizard
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.mp3RadioButton = new System.Windows.Forms.RadioButton();
            this.wmaRadioButton = new System.Windows.Forms.RadioButton();
            this.aacRadioButton = new System.Windows.Forms.RadioButton();
            this.openButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(73, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(316, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filename:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Converted format:";
            // 
            // convertButton
            // 
            this.convertButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.convertButton.ImageIndex = 0;
            this.convertButton.ImageList = this.imageList;
            this.convertButton.Location = new System.Drawing.Point(274, 52);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(71, 31);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // mp3RadioButton
            // 
            this.mp3RadioButton.AutoSize = true;
            this.mp3RadioButton.Location = new System.Drawing.Point(115, 57);
            this.mp3RadioButton.Name = "mp3RadioButton";
            this.mp3RadioButton.Size = new System.Drawing.Size(45, 17);
            this.mp3RadioButton.TabIndex = 10;
            this.mp3RadioButton.TabStop = true;
            this.mp3RadioButton.Text = "MP3";
            this.mp3RadioButton.UseVisualStyleBackColor = true;
            // 
            // wmaRadioButton
            // 
            this.wmaRadioButton.AutoSize = true;
            this.wmaRadioButton.Location = new System.Drawing.Point(166, 57);
            this.wmaRadioButton.Name = "wmaRadioButton";
            this.wmaRadioButton.Size = new System.Drawing.Size(50, 17);
            this.wmaRadioButton.TabIndex = 11;
            this.wmaRadioButton.TabStop = true;
            this.wmaRadioButton.Text = "WMA";
            this.wmaRadioButton.UseVisualStyleBackColor = true;
            // 
            // aacRadioButton
            // 
            this.aacRadioButton.AutoSize = true;
            this.aacRadioButton.Location = new System.Drawing.Point(222, 57);
            this.aacRadioButton.Name = "aacRadioButton";
            this.aacRadioButton.Size = new System.Drawing.Size(46, 17);
            this.aacRadioButton.TabIndex = 12;
            this.aacRadioButton.TabStop = true;
            this.aacRadioButton.Text = "AAC";
            this.aacRadioButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(395, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(54, 20);
            this.openButton.TabIndex = 14;
            this.openButton.Text = "...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "cog-icon.png");
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(482, 95);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.aacRadioButton);
            this.Controls.Add(this.wmaRadioButton);
            this.Controls.Add(this.mp3RadioButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.Text = "AudioWizard>>Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.RadioButton mp3RadioButton;
        private System.Windows.Forms.RadioButton wmaRadioButton;
        private System.Windows.Forms.RadioButton aacRadioButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ImageList imageList;
    }
}