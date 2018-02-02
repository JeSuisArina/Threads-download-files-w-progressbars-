namespace addTask
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
            this.button1 = new System.Windows.Forms.Button();
            this.url1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label01 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label02 = new System.Windows.Forms.Label();
            this.url2 = new System.Windows.Forms.TextBox();
            this.title2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // url1
            // 
            this.url1.Location = new System.Drawing.Point(15, 32);
            this.url1.Name = "url1";
            this.url1.Size = new System.Drawing.Size(241, 20);
            this.url1.TabIndex = 1;
            this.url1.Text = "https://vk.com/doc41328782_453706317?hash=5b514b2681e6ac207c&dl=dd7584c405e39933c" +
    "e";
            this.url1.TextChanged += new System.EventHandler(this.url1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите URL для загрузки";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(105, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(151, 20);
            this.progressBar1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Введите название файла";
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(15, 71);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(241, 20);
            this.title1.TabIndex = 26;
            this.title1.TextChanged += new System.EventHandler(this.title1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label01);
            this.groupBox1.Controls.Add(this.url1);
            this.groupBox1.Controls.Add(this.title1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 140);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(102, 120);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(0, 13);
            this.label01.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label02);
            this.groupBox2.Controls.Add(this.url2);
            this.groupBox2.Controls.Add(this.title2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Location = new System.Drawing.Point(15, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 140);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(102, 120);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(0, 13);
            this.label02.TabIndex = 28;
            // 
            // url2
            // 
            this.url2.Location = new System.Drawing.Point(15, 32);
            this.url2.Name = "url2";
            this.url2.Size = new System.Drawing.Size(241, 20);
            this.url2.TabIndex = 1;
            this.url2.Text = "https://vk.com/doc41328782_450311504?hash=d9a694b495908f36ee&dl=65e1b68e573b620d3" +
    "0";
            this.url2.TextChanged += new System.EventHandler(this.url2_TextChanged);
            // 
            // title2
            // 
            this.title2.Location = new System.Drawing.Point(15, 71);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(241, 20);
            this.title2.TabIndex = 26;
            this.title2.TextChanged += new System.EventHandler(this.title2_TextChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(15, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 20);
            this.button2.TabIndex = 0;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите название файла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите URL для загрузки";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(105, 97);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(151, 20);
            this.progressBar2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Загрузка файлов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox url1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox title1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox url2;
        private System.Windows.Forms.TextBox title2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
    }
}

