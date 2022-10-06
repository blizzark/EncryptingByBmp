namespace EncryptingByBmp
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
            this.UnencryptedTextTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SaveImageBtn = new System.Windows.Forms.Button();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LoadImageBtn = new System.Windows.Forms.Button();
            this.UnencryptBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DecryptedTB = new System.Windows.Forms.TextBox();
            this.SaveTextEnBtn = new System.Windows.Forms.Button();
            this.LoadTextEnBtn = new System.Windows.Forms.Button();
            this.SaveTextDeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnencryptedTextTB
            // 
            this.UnencryptedTextTB.Location = new System.Drawing.Point(6, 21);
            this.UnencryptedTextTB.Multiline = true;
            this.UnencryptedTextTB.Name = "UnencryptedTextTB";
            this.UnencryptedTextTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UnencryptedTextTB.Size = new System.Drawing.Size(415, 461);
            this.UnencryptedTextTB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnencryptedTextTB);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текст к шифрованию";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 529);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LoadTextEnBtn);
            this.tabPage1.Controls.Add(this.SaveTextEnBtn);
            this.tabPage1.Controls.Add(this.SaveImageBtn);
            this.tabPage1.Controls.Add(this.EncryptBtn);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SaveImageBtn
            // 
            this.SaveImageBtn.Location = new System.Drawing.Point(440, 290);
            this.SaveImageBtn.Name = "SaveImageBtn";
            this.SaveImageBtn.Size = new System.Drawing.Size(177, 69);
            this.SaveImageBtn.TabIndex = 4;
            this.SaveImageBtn.Text = "Сохранить изображение";
            this.SaveImageBtn.UseVisualStyleBackColor = true;
            this.SaveImageBtn.Click += new System.EventHandler(this.SaveImageBtn_Click);
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(439, 211);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(178, 72);
            this.EncryptBtn.TabIndex = 3;
            this.EncryptBtn.Text = "Зашифровать";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(623, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 487);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат шифрования";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 460);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SaveTextDeBtn);
            this.tabPage2.Controls.Add(this.LoadImageBtn);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.UnencryptBtn);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифрование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LoadImageBtn
            // 
            this.LoadImageBtn.Location = new System.Drawing.Point(564, 285);
            this.LoadImageBtn.Name = "LoadImageBtn";
            this.LoadImageBtn.Size = new System.Drawing.Size(177, 69);
            this.LoadImageBtn.TabIndex = 8;
            this.LoadImageBtn.Text = "Загрузить изображение";
            this.LoadImageBtn.UseVisualStyleBackColor = true;
            this.LoadImageBtn.Click += new System.EventHandler(this.LoadImageBtn_Click);
            // 
            // UnencryptBtn
            // 
            this.UnencryptBtn.Location = new System.Drawing.Point(563, 206);
            this.UnencryptBtn.Name = "UnencryptBtn";
            this.UnencryptBtn.Size = new System.Drawing.Size(178, 72);
            this.UnencryptBtn.TabIndex = 7;
            this.UnencryptBtn.Text = "Расшифровать";
            this.UnencryptBtn.UseVisualStyleBackColor = true;
            this.UnencryptBtn.Click += new System.EventHandler(this.UnencryptBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 487);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Шифрованный текст";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(54, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 460);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DecryptedTB);
            this.groupBox4.Location = new System.Drawing.Point(747, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 488);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расшифрованный текст";
            // 
            // DecryptedTB
            // 
            this.DecryptedTB.Location = new System.Drawing.Point(6, 21);
            this.DecryptedTB.Multiline = true;
            this.DecryptedTB.Name = "DecryptedTB";
            this.DecryptedTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecryptedTB.Size = new System.Drawing.Size(415, 461);
            this.DecryptedTB.TabIndex = 0;
            // 
            // SaveTextEnBtn
            // 
            this.SaveTextEnBtn.Location = new System.Drawing.Point(440, 27);
            this.SaveTextEnBtn.Name = "SaveTextEnBtn";
            this.SaveTextEnBtn.Size = new System.Drawing.Size(177, 68);
            this.SaveTextEnBtn.TabIndex = 5;
            this.SaveTextEnBtn.Text = "Сохранить текст в файл";
            this.SaveTextEnBtn.UseVisualStyleBackColor = true;
            this.SaveTextEnBtn.Click += new System.EventHandler(this.SaveTextEnBtn_Click);
            // 
            // LoadTextEnBtn
            // 
            this.LoadTextEnBtn.Location = new System.Drawing.Point(439, 101);
            this.LoadTextEnBtn.Name = "LoadTextEnBtn";
            this.LoadTextEnBtn.Size = new System.Drawing.Size(177, 68);
            this.LoadTextEnBtn.TabIndex = 5;
            this.LoadTextEnBtn.Text = "Загрузить текст из файла";
            this.LoadTextEnBtn.UseVisualStyleBackColor = true;
            this.LoadTextEnBtn.Click += new System.EventHandler(this.LoadTextEnBtn_Click);
            // 
            // SaveTextDeBtn
            // 
            this.SaveTextDeBtn.Location = new System.Drawing.Point(563, 31);
            this.SaveTextDeBtn.Name = "SaveTextDeBtn";
            this.SaveTextDeBtn.Size = new System.Drawing.Size(177, 68);
            this.SaveTextDeBtn.TabIndex = 9;
            this.SaveTextDeBtn.Text = "Сохранить текст в файл";
            this.SaveTextDeBtn.UseVisualStyleBackColor = true;
            this.SaveTextDeBtn.Click += new System.EventHandler(this.SaveTextDeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Шифратор/Дешифратор с помощью изображения";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UnencryptedTextTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SaveImageBtn;
        private System.Windows.Forms.Button LoadImageBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox DecryptedTB;
        private System.Windows.Forms.Button UnencryptBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LoadTextEnBtn;
        private System.Windows.Forms.Button SaveTextEnBtn;
        private System.Windows.Forms.Button SaveTextDeBtn;
    }
}

