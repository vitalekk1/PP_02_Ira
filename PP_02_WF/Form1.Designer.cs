namespace PP_02_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Linear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_Binary = new System.Windows.Forms.Label();
            this.TB_FIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Resume = new System.Windows.Forms.Button();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Линейный поиск:";
            // 
            // LB_Linear
            // 
            this.LB_Linear.AutoSize = true;
            this.LB_Linear.Location = new System.Drawing.Point(113, 72);
            this.LB_Linear.Name = "LB_Linear";
            this.LB_Linear.Size = new System.Drawing.Size(34, 13);
            this.LB_Linear.TabIndex = 1;
            this.LB_Linear.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Бинарный поиск";
            // 
            // LB_Binary
            // 
            this.LB_Binary.AutoSize = true;
            this.LB_Binary.Location = new System.Drawing.Point(113, 103);
            this.LB_Binary.Name = "LB_Binary";
            this.LB_Binary.Size = new System.Drawing.Size(34, 13);
            this.LB_Binary.TabIndex = 3;
            this.LB_Binary.Text = "ФИО";
            // 
            // TB_FIO
            // 
            this.TB_FIO.Location = new System.Drawing.Point(52, 6);
            this.TB_FIO.Name = "TB_FIO";
            this.TB_FIO.Size = new System.Drawing.Size(164, 20);
            this.TB_FIO.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ФИО";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(260, 4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search.TabIndex = 6;
            this.Btn_Search.Text = "Искать";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Resume
            // 
            this.Btn_Resume.Location = new System.Drawing.Point(406, 4);
            this.Btn_Resume.Name = "Btn_Resume";
            this.Btn_Resume.Size = new System.Drawing.Size(85, 23);
            this.Btn_Resume.TabIndex = 7;
            this.Btn_Resume.Text = "Возобновить";
            this.Btn_Resume.UseVisualStyleBackColor = true;
            this.Btn_Resume.Click += new System.EventHandler(this.continueL_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.Location = new System.Drawing.Point(521, 4);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.Btn_Pause.TabIndex = 8;
            this.Btn_Pause.Text = "Остановить";
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Pause);
            this.Controls.Add(this.Btn_Resume);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_FIO);
            this.Controls.Add(this.LB_Binary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_Linear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Linear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_Binary;
        private System.Windows.Forms.TextBox TB_FIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Resume;
        private System.Windows.Forms.Button Btn_Pause;
    }
}

