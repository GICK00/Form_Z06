
namespace Form_Z06_4
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нахождение положительного \r\nчисла";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(169, 62);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(76, 20);
            this.textBoxN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите размер N \r\nдвумерного массива.";
            // 
            // textBoxArr
            // 
            this.textBoxArr.Location = new System.Drawing.Point(42, 88);
            this.textBoxArr.Multiline = true;
            this.textBoxArr.Name = "textBoxArr";
            this.textBoxArr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArr.Size = new System.Drawing.Size(203, 131);
            this.textBoxArr.TabIndex = 3;
            this.textBoxArr.Text = "Введите элементы массива через \",\"";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(105, 225);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Утин Д. С.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxArr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form Z06.4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArr;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label3;
    }
}

