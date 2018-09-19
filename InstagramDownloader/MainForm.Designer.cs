namespace InstagramDownloader
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
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.buttonPilihFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(12, 131);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(15, 25);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(457, 20);
            this.textURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Masukkan alamat profil Instagram yang ingin di download:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Pilih folder tempat menyimpan foto:";
            // 
            // textFolder
            // 
            this.textFolder.Location = new System.Drawing.Point(15, 75);
            this.textFolder.Name = "textFolder";
            this.textFolder.Size = new System.Drawing.Size(358, 20);
            this.textFolder.TabIndex = 4;
            // 
            // buttonPilihFolder
            // 
            this.buttonPilihFolder.Location = new System.Drawing.Point(379, 74);
            this.buttonPilihFolder.Name = "buttonPilihFolder";
            this.buttonPilihFolder.Size = new System.Drawing.Size(93, 23);
            this.buttonPilihFolder.TabIndex = 5;
            this.buttonPilihFolder.Text = "Pilih Folder...";
            this.buttonPilihFolder.UseVisualStyleBackColor = true;
            this.buttonPilihFolder.Click += new System.EventHandler(this.buttonPilihFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "3. Download foto ke lokasi folder yang ditentukan:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 166);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPilihFolder);
            this.Controls.Add(this.textFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.buttonDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.Button buttonPilihFolder;
        private System.Windows.Forms.Label label3;
    }
}

