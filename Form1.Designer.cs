namespace Triangle
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
            this.Запуск = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Запуск
            // 
            this.Запуск.BackColor = System.Drawing.Color.Cornsilk;
            this.Запуск.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Запуск.FlatAppearance.BorderSize = 10;
            this.Запуск.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Запуск.Font = new System.Drawing.Font("Mongolian Baiti", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Запуск.Location = new System.Drawing.Point(292, 136);
            this.Запуск.Name = "Запуск";
            this.Запуск.Size = new System.Drawing.Size(160, 100);
            this.Запуск.TabIndex = 0;
            this.Запуск.Text = "Запуск";
            this.Запуск.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Запуск);
            this.Name = "Form1";
            this.Text = "Работа с треугольником";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Запуск;
    }
}

