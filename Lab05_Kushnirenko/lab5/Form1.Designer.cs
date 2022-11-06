namespace lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_size_in = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_size_out = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rB_SHA512 = new System.Windows.Forms.RadioButton();
            this.rB_SHA384 = new System.Windows.Forms.RadioButton();
            this.rB_SHA256 = new System.Windows.Forms.RadioButton();
            this.rB_SHA1 = new System.Windows.Forms.RadioButton();
            this.rB_MD5 = new System.Windows.Forms.RadioButton();
            this.rB_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rB_HAVAL = new System.Windows.Forms.RadioButton();
            this.rB_CRC32 = new System.Windows.Forms.RadioButton();
            this.bClean = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxInFile = new System.Windows.Forms.TextBox();
            this.textBoxOutFile = new System.Windows.Forms.TextBox();
            this.bInFile = new System.Windows.Forms.Button();
            this.bOutFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхідний файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вихідний файл:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вхідного файлу:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Вихідного файлу:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_size_in);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(270, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оцінка розміру (Мбайт)";
            // 
            // label_size_in
            // 
            this.label_size_in.AutoSize = true;
            this.label_size_in.Location = new System.Drawing.Point(154, 35);
            this.label_size_in.Name = "label_size_in";
            this.label_size_in.Size = new System.Drawing.Size(18, 20);
            this.label_size_in.TabIndex = 5;
            this.label_size_in.Text = "_";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_size_out);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(270, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 83);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (Байти)";
            // 
            // label_size_out
            // 
            this.label_size_out.AutoSize = true;
            this.label_size_out.Location = new System.Drawing.Point(154, 38);
            this.label_size_out.Name = "label_size_out";
            this.label_size_out.Size = new System.Drawing.Size(18, 20);
            this.label_size_out.TabIndex = 7;
            this.label_size_out.Text = "_";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rB_SHA512);
            this.groupBox3.Controls.Add(this.rB_SHA384);
            this.groupBox3.Controls.Add(this.rB_SHA256);
            this.groupBox3.Controls.Add(this.rB_SHA1);
            this.groupBox3.Controls.Add(this.rB_MD5);
            this.groupBox3.Controls.Add(this.rB_RIPEMD160);
            this.groupBox3.Controls.Add(this.rB_HAVAL);
            this.groupBox3.Controls.Add(this.rB_CRC32);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(16, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 159);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Режим роботи:";
            // 
            // rB_SHA512
            // 
            this.rB_SHA512.AutoSize = true;
            this.rB_SHA512.Location = new System.Drawing.Point(144, 121);
            this.rB_SHA512.Name = "rB_SHA512";
            this.rB_SHA512.Size = new System.Drawing.Size(93, 24);
            this.rB_SHA512.TabIndex = 7;
            this.rB_SHA512.TabStop = true;
            this.rB_SHA512.Text = "SHA-512";
            this.rB_SHA512.UseVisualStyleBackColor = true;
            // 
            // rB_SHA384
            // 
            this.rB_SHA384.AutoSize = true;
            this.rB_SHA384.Location = new System.Drawing.Point(144, 87);
            this.rB_SHA384.Name = "rB_SHA384";
            this.rB_SHA384.Size = new System.Drawing.Size(93, 24);
            this.rB_SHA384.TabIndex = 6;
            this.rB_SHA384.TabStop = true;
            this.rB_SHA384.Text = "SHA-384";
            this.rB_SHA384.UseVisualStyleBackColor = true;
            // 
            // rB_SHA256
            // 
            this.rB_SHA256.AutoSize = true;
            this.rB_SHA256.Location = new System.Drawing.Point(144, 57);
            this.rB_SHA256.Name = "rB_SHA256";
            this.rB_SHA256.Size = new System.Drawing.Size(93, 24);
            this.rB_SHA256.TabIndex = 5;
            this.rB_SHA256.TabStop = true;
            this.rB_SHA256.Text = "SHA-256";
            this.rB_SHA256.UseVisualStyleBackColor = true;
            // 
            // rB_SHA1
            // 
            this.rB_SHA1.AutoSize = true;
            this.rB_SHA1.Location = new System.Drawing.Point(144, 25);
            this.rB_SHA1.Name = "rB_SHA1";
            this.rB_SHA1.Size = new System.Drawing.Size(75, 24);
            this.rB_SHA1.TabIndex = 4;
            this.rB_SHA1.TabStop = true;
            this.rB_SHA1.Text = "SHA-1";
            this.rB_SHA1.UseVisualStyleBackColor = true;
            // 
            // rB_MD5
            // 
            this.rB_MD5.AutoSize = true;
            this.rB_MD5.Location = new System.Drawing.Point(6, 117);
            this.rB_MD5.Name = "rB_MD5";
            this.rB_MD5.Size = new System.Drawing.Size(61, 24);
            this.rB_MD5.TabIndex = 3;
            this.rB_MD5.TabStop = true;
            this.rB_MD5.Text = "MD5";
            this.rB_MD5.UseVisualStyleBackColor = true;
            // 
            // rB_RIPEMD160
            // 
            this.rB_RIPEMD160.AutoSize = true;
            this.rB_RIPEMD160.Location = new System.Drawing.Point(6, 87);
            this.rB_RIPEMD160.Name = "rB_RIPEMD160";
            this.rB_RIPEMD160.Size = new System.Drawing.Size(117, 24);
            this.rB_RIPEMD160.TabIndex = 2;
            this.rB_RIPEMD160.TabStop = true;
            this.rB_RIPEMD160.Text = "RIPEMD160";
            this.rB_RIPEMD160.UseVisualStyleBackColor = true;
            // 
            // rB_HAVAL
            // 
            this.rB_HAVAL.AutoSize = true;
            this.rB_HAVAL.Location = new System.Drawing.Point(6, 57);
            this.rB_HAVAL.Name = "rB_HAVAL";
            this.rB_HAVAL.Size = new System.Drawing.Size(132, 24);
            this.rB_HAVAL.TabIndex = 1;
            this.rB_HAVAL.TabStop = true;
            this.rB_HAVAL.Text = "HashAlgorithm";
            this.rB_HAVAL.UseVisualStyleBackColor = true;
            // 
            // rB_CRC32
            // 
            this.rB_CRC32.AutoSize = true;
            this.rB_CRC32.Location = new System.Drawing.Point(6, 25);
            this.rB_CRC32.Name = "rB_CRC32";
            this.rB_CRC32.Size = new System.Drawing.Size(79, 24);
            this.rB_CRC32.TabIndex = 0;
            this.rB_CRC32.TabStop = true;
            this.rB_CRC32.Text = "CRC32";
            this.rB_CRC32.UseVisualStyleBackColor = true;
            // 
            // bClean
            // 
            this.bClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClean.Location = new System.Drawing.Point(441, 300);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(92, 35);
            this.bClean.TabIndex = 10;
            this.bClean.Text = "Очистити";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(270, 300);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(92, 35);
            this.bStart.TabIndex = 11;
            this.bStart.Text = "Виконати";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(270, 255);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 39);
            this.progressBar1.TabIndex = 12;
            // 
            // textBoxInFile
            // 
            this.textBoxInFile.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInFile.Location = new System.Drawing.Point(146, 6);
            this.textBoxInFile.Name = "textBoxInFile";
            this.textBoxInFile.Size = new System.Drawing.Size(316, 26);
            this.textBoxInFile.TabIndex = 13;
            this.textBoxInFile.TextChanged += new System.EventHandler(this.textBoxInFile_TextChanged);
            // 
            // textBoxOutFile
            // 
            this.textBoxOutFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutFile.Location = new System.Drawing.Point(146, 42);
            this.textBoxOutFile.Name = "textBoxOutFile";
            this.textBoxOutFile.Size = new System.Drawing.Size(316, 26);
            this.textBoxOutFile.TabIndex = 14;
            // 
            // bInFile
            // 
            this.bInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bInFile.Location = new System.Drawing.Point(468, 6);
            this.bInFile.Name = "bInFile";
            this.bInFile.Size = new System.Drawing.Size(40, 26);
            this.bInFile.TabIndex = 15;
            this.bInFile.Text = "...";
            this.bInFile.UseVisualStyleBackColor = true;
            this.bInFile.Click += new System.EventHandler(this.bInFile_Click);
            // 
            // bOutFile
            // 
            this.bOutFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOutFile.Location = new System.Drawing.Point(468, 42);
            this.bOutFile.Name = "bOutFile";
            this.bOutFile.Size = new System.Drawing.Size(40, 26);
            this.bOutFile.TabIndex = 16;
            this.bOutFile.Text = "...";
            this.bOutFile.UseVisualStyleBackColor = true;
            this.bOutFile.Click += new System.EventHandler(this.bOutFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 346);
            this.Controls.Add(this.bOutFile);
            this.Controls.Add(this.bInFile);
            this.Controls.Add(this.textBoxOutFile);
            this.Controls.Add(this.textBoxInFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Циклічний надлишковий код(CRC)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_size_in;
        private System.Windows.Forms.Label label_size_out;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rB_SHA512;
        private System.Windows.Forms.RadioButton rB_SHA384;
        private System.Windows.Forms.RadioButton rB_SHA256;
        private System.Windows.Forms.RadioButton rB_SHA1;
        private System.Windows.Forms.RadioButton rB_MD5;
        private System.Windows.Forms.RadioButton rB_RIPEMD160;
        private System.Windows.Forms.RadioButton rB_HAVAL;
        private System.Windows.Forms.RadioButton rB_CRC32;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxInFile;
        private System.Windows.Forms.TextBox textBoxOutFile;
        private System.Windows.Forms.Button bInFile;
        private System.Windows.Forms.Button bOutFile;
    }
}

