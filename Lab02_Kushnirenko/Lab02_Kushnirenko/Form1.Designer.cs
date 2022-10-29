namespace Lab02_Kushnirenko
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
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.label_PH = new System.Windows.Forms.Label();
            this.label_PD = new System.Windows.Forms.Label();
            this.label_PB = new System.Windows.Forms.Label();
            this.label_KeyB = new System.Windows.Forms.Label();
            this.label_KeyD = new System.Windows.Forms.Label();
            this.label_KeyH = new System.Windows.Forms.Label();
            this.label_CB = new System.Windows.Forms.Label();
            this.label_CD = new System.Windows.Forms.Label();
            this.label_CH = new System.Windows.Forms.Label();
            this.radioButton_Hex = new System.Windows.Forms.RadioButton();
            this.radioButton_Dec = new System.Windows.Forms.RadioButton();
            this.radioButton_Bin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_XOR
            // 
            this.button_XOR.Enabled = false;
            this.button_XOR.Location = new System.Drawing.Point(235, 38);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(75, 23);
            this.button_XOR.TabIndex = 0;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(235, 168);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 1;
            this.button_clean.Text = "Прибрати";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "P=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C=";
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(115, 25);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 20);
            this.textBox_P.TabIndex = 5;
            this.textBox_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_P_KeyPress);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(115, 82);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 20);
            this.textBox_Key.TabIndex = 6;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(115, 145);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 20);
            this.textBox_C.TabIndex = 7;
            // 
            // label_PH
            // 
            this.label_PH.AutoSize = true;
            this.label_PH.Location = new System.Drawing.Point(79, 48);
            this.label_PH.Name = "label_PH";
            this.label_PH.Size = new System.Drawing.Size(15, 13);
            this.label_PH.TabIndex = 8;
            this.label_PH.Text = "H";
            // 
            // label_PD
            // 
            this.label_PD.AutoSize = true;
            this.label_PD.Location = new System.Drawing.Point(129, 48);
            this.label_PD.Name = "label_PD";
            this.label_PD.Size = new System.Drawing.Size(15, 13);
            this.label_PD.TabIndex = 9;
            this.label_PD.Text = "D";
            // 
            // label_PB
            // 
            this.label_PB.AutoSize = true;
            this.label_PB.Location = new System.Drawing.Point(79, 64);
            this.label_PB.Name = "label_PB";
            this.label_PB.Size = new System.Drawing.Size(14, 13);
            this.label_PB.TabIndex = 10;
            this.label_PB.Text = "B";
            // 
            // label_KeyB
            // 
            this.label_KeyB.AutoSize = true;
            this.label_KeyB.Location = new System.Drawing.Point(79, 125);
            this.label_KeyB.Name = "label_KeyB";
            this.label_KeyB.Size = new System.Drawing.Size(14, 13);
            this.label_KeyB.TabIndex = 13;
            this.label_KeyB.Text = "B";
            // 
            // label_KeyD
            // 
            this.label_KeyD.AutoSize = true;
            this.label_KeyD.Location = new System.Drawing.Point(129, 105);
            this.label_KeyD.Name = "label_KeyD";
            this.label_KeyD.Size = new System.Drawing.Size(15, 13);
            this.label_KeyD.TabIndex = 12;
            this.label_KeyD.Text = "D";
            // 
            // label_KeyH
            // 
            this.label_KeyH.AutoSize = true;
            this.label_KeyH.Location = new System.Drawing.Point(79, 105);
            this.label_KeyH.Name = "label_KeyH";
            this.label_KeyH.Size = new System.Drawing.Size(15, 13);
            this.label_KeyH.TabIndex = 11;
            this.label_KeyH.Text = "H";
            // 
            // label_CB
            // 
            this.label_CB.AutoSize = true;
            this.label_CB.Location = new System.Drawing.Point(79, 188);
            this.label_CB.Name = "label_CB";
            this.label_CB.Size = new System.Drawing.Size(14, 13);
            this.label_CB.TabIndex = 16;
            this.label_CB.Text = "B";
            // 
            // label_CD
            // 
            this.label_CD.AutoSize = true;
            this.label_CD.Location = new System.Drawing.Point(129, 168);
            this.label_CD.Name = "label_CD";
            this.label_CD.Size = new System.Drawing.Size(15, 13);
            this.label_CD.TabIndex = 15;
            this.label_CD.Text = "D";
            // 
            // label_CH
            // 
            this.label_CH.AutoSize = true;
            this.label_CH.Location = new System.Drawing.Point(79, 168);
            this.label_CH.Name = "label_CH";
            this.label_CH.Size = new System.Drawing.Size(15, 13);
            this.label_CH.TabIndex = 14;
            this.label_CH.Text = "H";
            // 
            // radioButton_Hex
            // 
            this.radioButton_Hex.AutoSize = true;
            this.radioButton_Hex.Location = new System.Drawing.Point(250, 98);
            this.radioButton_Hex.Name = "radioButton_Hex";
            this.radioButton_Hex.Size = new System.Drawing.Size(44, 17);
            this.radioButton_Hex.TabIndex = 17;
            this.radioButton_Hex.TabStop = true;
            this.radioButton_Hex.Text = "Hex";
            this.radioButton_Hex.UseVisualStyleBackColor = true;
            this.radioButton_Hex.CheckedChanged += new System.EventHandler(this.radioButton_Hex_CheckedChanged);
            // 
            // radioButton_Dec
            // 
            this.radioButton_Dec.AutoSize = true;
            this.radioButton_Dec.Location = new System.Drawing.Point(250, 121);
            this.radioButton_Dec.Name = "radioButton_Dec";
            this.radioButton_Dec.Size = new System.Drawing.Size(45, 17);
            this.radioButton_Dec.TabIndex = 18;
            this.radioButton_Dec.TabStop = true;
            this.radioButton_Dec.Text = "Dec";
            this.radioButton_Dec.UseVisualStyleBackColor = true;
            this.radioButton_Dec.CheckedChanged += new System.EventHandler(this.radioButton_Dec_CheckedChanged);
            // 
            // radioButton_Bin
            // 
            this.radioButton_Bin.AutoSize = true;
            this.radioButton_Bin.Location = new System.Drawing.Point(250, 144);
            this.radioButton_Bin.Name = "radioButton_Bin";
            this.radioButton_Bin.Size = new System.Drawing.Size(40, 17);
            this.radioButton_Bin.TabIndex = 19;
            this.radioButton_Bin.TabStop = true;
            this.radioButton_Bin.Text = "Bin";
            this.radioButton_Bin.UseVisualStyleBackColor = true;
            this.radioButton_Bin.CheckedChanged += new System.EventHandler(this.radioButton_Bin_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(221, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Виберіть систему счислення для вхідних даних";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 236);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton_Bin);
            this.Controls.Add(this.radioButton_Dec);
            this.Controls.Add(this.radioButton_Hex);
            this.Controls.Add(this.label_CB);
            this.Controls.Add(this.label_CD);
            this.Controls.Add(this.label_CH);
            this.Controls.Add(this.label_KeyB);
            this.Controls.Add(this.label_KeyD);
            this.Controls.Add(this.label_KeyH);
            this.Controls.Add(this.label_PB);
            this.Controls.Add(this.label_PD);
            this.Controls.Add(this.label_PH);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_XOR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Label label_PH;
        private System.Windows.Forms.Label label_PD;
        private System.Windows.Forms.Label label_PB;
        private System.Windows.Forms.Label label_KeyB;
        private System.Windows.Forms.Label label_KeyD;
        private System.Windows.Forms.Label label_KeyH;
        private System.Windows.Forms.Label label_CB;
        private System.Windows.Forms.Label label_CD;
        private System.Windows.Forms.Label label_CH;
        private System.Windows.Forms.RadioButton radioButton_Hex;
        private System.Windows.Forms.RadioButton radioButton_Dec;
        private System.Windows.Forms.RadioButton radioButton_Bin;
        private System.Windows.Forms.Label label4;
    }
}

