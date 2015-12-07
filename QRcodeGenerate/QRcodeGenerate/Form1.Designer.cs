namespace QRcodeGenerate
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
            this.qrimage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.saveQRcodeButton = new System.Windows.Forms.Button();
            this.loadQRcodeButton = new System.Windows.Forms.Button();
            this.showQRcodeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Id = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.savecodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrimage)).BeginInit();
            this.SuspendLayout();
            // 
            // qrimage
            // 
            this.qrimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrimage.Location = new System.Drawing.Point(58, 53);
            this.qrimage.Name = "qrimage";
            this.qrimage.Padding = new System.Windows.Forms.Padding(1);
            this.qrimage.Size = new System.Drawing.Size(200, 150);
            this.qrimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.qrimage.TabIndex = 0;
            this.qrimage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Value";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(367, 87);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(154, 20);
            this.urlBox.TabIndex = 2;
            // 
            // saveQRcodeButton
            // 
            this.saveQRcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQRcodeButton.Location = new System.Drawing.Point(304, 143);
            this.saveQRcodeButton.Name = "saveQRcodeButton";
            this.saveQRcodeButton.Size = new System.Drawing.Size(217, 23);
            this.saveQRcodeButton.TabIndex = 4;
            this.saveQRcodeButton.Text = "Save QR code Image";
            this.saveQRcodeButton.UseVisualStyleBackColor = true;
            this.saveQRcodeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadQRcodeButton
            // 
            this.loadQRcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQRcodeButton.Location = new System.Drawing.Point(304, 180);
            this.loadQRcodeButton.Name = "loadQRcodeButton";
            this.loadQRcodeButton.Size = new System.Drawing.Size(103, 23);
            this.loadQRcodeButton.TabIndex = 5;
            this.loadQRcodeButton.Text = "Upload QR Code";
            this.loadQRcodeButton.UseVisualStyleBackColor = true;
            this.loadQRcodeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // showQRcodeButton
            // 
            this.showQRcodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showQRcodeButton.Location = new System.Drawing.Point(413, 180);
            this.showQRcodeButton.Name = "showQRcodeButton";
            this.showQRcodeButton.Size = new System.Drawing.Size(108, 23);
            this.showQRcodeButton.TabIndex = 6;
            this.showQRcodeButton.Text = "Show QR Code";
            this.showQRcodeButton.UseVisualStyleBackColor = true;
            this.showQRcodeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = " Developed By";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkVisited = true;
            this.linkLabel.Location = new System.Drawing.Point(384, 236);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(148, 13);
            this.linkLabel.TabIndex = 8;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Akash Soft Task & Engineering";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(351, 15);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 13);
            this.Id.TabIndex = 10;
            this.Id.Text = "ID";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(397, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(375, 15);
            this.idBox.Multiline = true;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(137, 20);
            this.idBox.TabIndex = 12;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(339, 114);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(133, 23);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Created QR Code";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // savecodeButton
            // 
            this.savecodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savecodeButton.Location = new System.Drawing.Point(339, 210);
            this.savecodeButton.Name = "savecodeButton";
            this.savecodeButton.Size = new System.Drawing.Size(133, 23);
            this.savecodeButton.TabIndex = 14;
            this.savecodeButton.Text = "Save Code";
            this.savecodeButton.UseVisualStyleBackColor = true;
            this.savecodeButton.Click += new System.EventHandler(this.savecodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 300);
            this.Controls.Add(this.savecodeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showQRcodeButton);
            this.Controls.Add(this.loadQRcodeButton);
            this.Controls.Add(this.saveQRcodeButton);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrimage);
            this.Name = "Form1";
            this.Text = "Amarbrand.com";
            ((System.ComponentModel.ISupportInitialize)(this.qrimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button saveQRcodeButton;
        private System.Windows.Forms.Button loadQRcodeButton;
        private System.Windows.Forms.Button showQRcodeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel;
        public System.Windows.Forms.PictureBox qrimage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button savecodeButton;
    }
}

