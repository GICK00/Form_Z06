
namespace Form_Z06
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
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNd = new System.Windows.Forms.TextBox();
            this.textBoxMd = new System.Windows.Forms.TextBox();
            this.textBoxArrD = new System.Windows.Forms.TextBox();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работа с массивами.";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(239, 44);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(60, 20);
            this.textBoxN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите размер N одномерного массива.";
            // 
            // textBoxArr
            // 
            this.textBoxArr.Location = new System.Drawing.Point(63, 86);
            this.textBoxArr.Multiline = true;
            this.textBoxArr.Name = "textBoxArr";
            this.textBoxArr.Size = new System.Drawing.Size(197, 71);
            this.textBoxArr.TabIndex = 3;
            this.textBoxArr.Text = "Введите элементы массива черех \",\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Одномерный массив";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(124, 163);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Двумерный массив";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите размер N M двумерного массива.";
            // 
            // textBoxNd
            // 
            this.textBoxNd.Location = new System.Drawing.Point(239, 203);
            this.textBoxNd.Name = "textBoxNd";
            this.textBoxNd.Size = new System.Drawing.Size(60, 20);
            this.textBoxNd.TabIndex = 8;
            // 
            // textBoxMd
            // 
            this.textBoxMd.Location = new System.Drawing.Point(239, 229);
            this.textBoxMd.Name = "textBoxMd";
            this.textBoxMd.Size = new System.Drawing.Size(60, 20);
            this.textBoxMd.TabIndex = 9;
            // 
            // textBoxArrD
            // 
            this.textBoxArrD.Location = new System.Drawing.Point(63, 267);
            this.textBoxArrD.Multiline = true;
            this.textBoxArrD.Name = "textBoxArrD";
            this.textBoxArrD.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxArrD.Size = new System.Drawing.Size(197, 87);
            this.textBoxArrD.TabIndex = 10;
            this.textBoxArrD.Text = "Введите элементы массива черех \",\"";
            // 
            // buttonStart2
            // 
            this.buttonStart2.Location = new System.Drawing.Point(124, 360);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(75, 23);
            this.buttonStart2.TabIndex = 11;
            this.buttonStart2.Text = "Старт";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Утин Д. С.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonStart2);
            this.Controls.Add(this.textBoxArrD);
            this.Controls.Add(this.textBoxMd);
            this.Controls.Add(this.textBoxNd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxArr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form Z06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNd;
        private System.Windows.Forms.TextBox textBoxMd;
        private System.Windows.Forms.TextBox textBoxArrD;
        private System.Windows.Forms.Button buttonStart2;
        private System.Windows.Forms.Label label6;
    }
}

