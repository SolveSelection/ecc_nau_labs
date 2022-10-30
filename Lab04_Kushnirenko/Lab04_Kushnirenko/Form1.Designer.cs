namespace Lab04_Kushnirenko
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_time = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_fileKEY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_KEYsize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_fileKEYsave = new System.Windows.Forms.Button();
            this.button_fileKEYopen = new System.Windows.Forms.Button();
            this.button_fileKEYgenerator = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(219, 195);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(26, 13);
            this.label_time.TabIndex = 12;
            this.label_time.Text = "time";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(314, 190);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тривалість шифрування (мін:сек.мс):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label_KEYsize);
            this.groupBox2.Controls.Add(this.button_fileKEYsave);
            this.groupBox2.Controls.Add(this.button_fileKEYopen);
            this.groupBox2.Controls.Add(this.button_fileKEYgenerator);
            this.groupBox2.Controls.Add(this.textBox_fileKEY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 81);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // textBox_fileKEY
            // 
            this.textBox_fileKEY.Location = new System.Drawing.Point(109, 24);
            this.textBox_fileKEY.Name = "textBox_fileKEY";
            this.textBox_fileKEY.Size = new System.Drawing.Size(171, 20);
            this.textBox_fileKEY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Файл з ключем:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fileOUT);
            this.groupBox1.Controls.Add(this.button_fileIN);
            this.groupBox1.Controls.Add(this.textBox_fileOUT);
            this.groupBox1.Controls.Add(this.textBox_fileIN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файли";
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Location = new System.Drawing.Point(367, 50);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(29, 23);
            this.button_fileOUT.TabIndex = 8;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.UseVisualStyleBackColor = true;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // button_fileIN
            // 
            this.button_fileIN.Location = new System.Drawing.Point(367, 21);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(29, 23);
            this.button_fileIN.TabIndex = 7;
            this.button_fileIN.Text = "...";
            this.button_fileIN.UseVisualStyleBackColor = true;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(109, 53);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(252, 20);
            this.textBox_fileOUT.TabIndex = 4;
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(109, 24);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(252, 20);
            this.textBox_fileIN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зберегти у файл:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відкрити файл:";
            // 
            // label_KEYsize
            // 
            this.label_KEYsize.AutoSize = true;
            this.label_KEYsize.Location = new System.Drawing.Point(20, 65);
            this.label_KEYsize.Name = "label_KEYsize";
            this.label_KEYsize.Size = new System.Drawing.Size(13, 13);
            this.label_KEYsize.TabIndex = 8;
            this.label_KEYsize.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Розмір ключа:";
            // 
            // button_fileKEYsave
            // 
            this.button_fileKEYsave.Image = global::Lab04_Kushnirenko.Properties.Resources.save;
            this.button_fileKEYsave.Location = new System.Drawing.Point(344, 11);
            this.button_fileKEYsave.Name = "button_fileKEYsave";
            this.button_fileKEYsave.Size = new System.Drawing.Size(52, 52);
            this.button_fileKEYsave.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button_fileKEYsave, "Зберегти");
            this.button_fileKEYsave.UseVisualStyleBackColor = true;
            this.button_fileKEYsave.Click += new System.EventHandler(this.button_fileKEYsave_Click);
            // 
            // button_fileKEYopen
            // 
            this.button_fileKEYopen.Image = global::Lab04_Kushnirenko.Properties.Resources.open;
            this.button_fileKEYopen.Location = new System.Drawing.Point(286, 11);
            this.button_fileKEYopen.Name = "button_fileKEYopen";
            this.button_fileKEYopen.Size = new System.Drawing.Size(52, 52);
            this.button_fileKEYopen.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button_fileKEYopen, "Відкрити");
            this.button_fileKEYopen.UseVisualStyleBackColor = true;
            this.button_fileKEYopen.Click += new System.EventHandler(this.button_fileKEYopen_Click);
            // 
            // button_fileKEYgenerator
            // 
            this.button_fileKEYgenerator.Image = global::Lab04_Kushnirenko.Properties.Resources.icon_key;
            this.button_fileKEYgenerator.Location = new System.Drawing.Point(167, 46);
            this.button_fileKEYgenerator.Name = "button_fileKEYgenerator";
            this.button_fileKEYgenerator.Size = new System.Drawing.Size(66, 29);
            this.button_fileKEYgenerator.TabIndex = 5;
            this.toolTip1.SetToolTip(this.button_fileKEYgenerator, "Згенерувати ключ");
            this.button_fileKEYgenerator.UseVisualStyleBackColor = true;
            this.button_fileKEYgenerator.Click += new System.EventHandler(this.button_fileKEYgenerator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 230);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_fileKEYsave;
        private System.Windows.Forms.Button button_fileKEYopen;
        private System.Windows.Forms.Button button_fileKEYgenerator;
        private System.Windows.Forms.TextBox textBox_fileKEY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_KEYsize;
    }
}

