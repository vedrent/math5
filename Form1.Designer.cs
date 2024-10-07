namespace math5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Input1 = new TextBox();
            Output1 = new TextBox();
            Input2 = new TextBox();
            Output2 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            keyCode = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Input1
            // 
            Input1.Font = new Font("Segoe UI", 12F);
            Input1.Location = new Point(81, 98);
            Input1.Name = "Input1";
            Input1.Size = new Size(300, 34);
            Input1.TabIndex = 0;
            // 
            // Output1
            // 
            Output1.Font = new Font("Segoe UI", 12F);
            Output1.Location = new Point(81, 308);
            Output1.Name = "Output1";
            Output1.Size = new Size(300, 34);
            Output1.TabIndex = 1;
            // 
            // Input2
            // 
            Input2.Font = new Font("Segoe UI", 12F);
            Input2.Location = new Point(440, 98);
            Input2.Name = "Input2";
            Input2.Size = new Size(300, 34);
            Input2.TabIndex = 2;
            // 
            // Output2
            // 
            Output2.Font = new Font("Segoe UI", 12F);
            Output2.Location = new Point(449, 308);
            Output2.Name = "Output2";
            Output2.Size = new Size(300, 34);
            Output2.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(81, 58);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 27);
            textBox5.TabIndex = 4;
            textBox5.Text = "Ввод сообщения";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.Location = new Point(440, 58);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(300, 27);
            textBox6.TabIndex = 5;
            textBox6.Text = "Ввод сообщения";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F);
            textBox7.Location = new Point(81, 268);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(300, 27);
            textBox7.TabIndex = 6;
            textBox7.Text = "Зашифрованное сообщение";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Control;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 12F);
            textBox8.Location = new Point(449, 268);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(300, 27);
            textBox8.TabIndex = 7;
            textBox8.Text = "Расшифрованное сообщение";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(135, 175);
            button1.Name = "button1";
            button1.Size = new Size(186, 55);
            button1.TabIndex = 8;
            button1.Text = "Шифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(502, 175);
            button2.Name = "button2";
            button2.Size = new Size(186, 55);
            button2.TabIndex = 9;
            button2.Text = "Дешифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // keyCode
            // 
            keyCode.Font = new Font("Segoe UI", 12F);
            keyCode.Location = new Point(852, 98);
            keyCode.Name = "keyCode";
            keyCode.Size = new Size(71, 34);
            keyCode.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(781, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 11;
            textBox2.Text = "Ключ шифрования";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 450);
            Controls.Add(textBox2);
            Controls.Add(keyCode);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(Output2);
            Controls.Add(Input2);
            Controls.Add(Output1);
            Controls.Add(Input1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input1;
        private TextBox Output1;
        private TextBox Input2;
        private TextBox Output2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
        private TextBox keyCode;
        private TextBox textBox2;
    }
}
