namespace Calculator
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
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.textBox_enterone = new System.Windows.Forms.TextBox();
            this.textBox_entertwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_enterthree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sinus = new System.Windows.Forms.Button();
            this.Logarithm = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.foursquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(50, 133);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(75, 23);
            this.button_plus.TabIndex = 0;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Button_click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(131, 133);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 23);
            this.button_minus.TabIndex = 1;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.Button_click);
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(50, 162);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(75, 23);
            this.button_multiply.TabIndex = 2;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.Button_click);
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(131, 162);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(75, 23);
            this.button_divide.TabIndex = 3;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.Button_click);
            // 
            // textBox_enterone
            // 
            this.textBox_enterone.Location = new System.Drawing.Point(50, 22);
            this.textBox_enterone.Name = "textBox_enterone";
            this.textBox_enterone.Size = new System.Drawing.Size(100, 20);
            this.textBox_enterone.TabIndex = 4;
            // 
            // textBox_entertwo
            // 
            this.textBox_entertwo.Location = new System.Drawing.Point(50, 48);
            this.textBox_entertwo.Name = "textBox_entertwo";
            this.textBox_entertwo.Size = new System.Drawing.Size(100, 20);
            this.textBox_entertwo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // textBox_enterthree
            // 
            this.textBox_enterthree.Location = new System.Drawing.Point(343, 22);
            this.textBox_enterthree.Name = "textBox_enterthree";
            this.textBox_enterthree.Size = new System.Drawing.Size(100, 20);
            this.textBox_enterthree.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(343, 133);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(75, 23);
            this.Sinus.TabIndex = 10;
            this.Sinus.Text = "Sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.OneClick);
            // 
            // Logarithm
            // 
            this.Logarithm.Location = new System.Drawing.Point(424, 133);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(75, 23);
            this.Logarithm.TabIndex = 11;
            this.Logarithm.Text = "Ln";
            this.Logarithm.UseVisualStyleBackColor = true;
            this.Logarithm.Click += new System.EventHandler(this.OneClick);
            // 
            // exponent
            // 
            this.exponent.Location = new System.Drawing.Point(343, 162);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(75, 23);
            this.exponent.TabIndex = 12;
            this.exponent.Text = "2^x";
            this.exponent.UseVisualStyleBackColor = true;
            this.exponent.Click += new System.EventHandler(this.OneClick);
            // 
            // foursquare
            // 
            this.foursquare.Location = new System.Drawing.Point(424, 162);
            this.foursquare.Name = "foursquare";
            this.foursquare.Size = new System.Drawing.Size(75, 23);
            this.foursquare.TabIndex = 13;
            this.foursquare.Text = "x^2";
            this.foursquare.UseVisualStyleBackColor = true;
            this.foursquare.Click += new System.EventHandler(this.OneClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 243);
            this.Controls.Add(this.foursquare);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.Logarithm);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_enterthree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_entertwo);
            this.Controls.Add(this.textBox_enterone);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.TextBox textBox_enterone;
        private System.Windows.Forms.TextBox textBox_entertwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_enterthree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Logarithm;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button foursquare;
    }
}

