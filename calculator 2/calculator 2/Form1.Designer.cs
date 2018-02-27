namespace calculator_2
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.result = new System.Windows.Forms.RichTextBox();
            this.op_1 = new System.Windows.Forms.Button();
            this.op_5 = new System.Windows.Forms.Button();
            this.op_6 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.op_2 = new System.Windows.Forms.Button();
            this.op_3 = new System.Windows.Forms.Button();
            this.op_4 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(49, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(186, 34);
            this.result.TabIndex = 61;
            this.result.Text = "0";
            // 
            // op_1
            // 
            this.op_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_1.Location = new System.Drawing.Point(193, 216);
            this.op_1.Name = "op_1";
            this.op_1.Size = new System.Drawing.Size(42, 37);
            this.op_1.TabIndex = 60;
            this.op_1.Text = "+";
            this.op_1.UseVisualStyleBackColor = true;
            this.op_1.Click += new System.EventHandler(this.opr_click);
            // 
            // op_5
            // 
            this.op_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_5.Location = new System.Drawing.Point(145, 216);
            this.op_5.Name = "op_5";
            this.op_5.Size = new System.Drawing.Size(42, 37);
            this.op_5.TabIndex = 59;
            this.op_5.Text = "=";
            this.op_5.UseVisualStyleBackColor = true;
            this.op_5.Click += new System.EventHandler(this.op_5_Click);
            // 
            // op_6
            // 
            this.op_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_6.Location = new System.Drawing.Point(49, 216);
            this.op_6.Name = "op_6";
            this.op_6.Size = new System.Drawing.Size(42, 37);
            this.op_6.TabIndex = 58;
            this.op_6.Text = ".";
            this.op_6.UseVisualStyleBackColor = true;
            this.op_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(49, 50);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(42, 34);
            this.button17.TabIndex = 57;
            this.button17.Text = "Clear";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // op_2
            // 
            this.op_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_2.Location = new System.Drawing.Point(193, 173);
            this.op_2.Name = "op_2";
            this.op_2.Size = new System.Drawing.Size(42, 37);
            this.op_2.TabIndex = 53;
            this.op_2.Text = "-";
            this.op_2.UseVisualStyleBackColor = true;
            this.op_2.Click += new System.EventHandler(this.opr_click);
            // 
            // op_3
            // 
            this.op_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_3.Location = new System.Drawing.Point(193, 133);
            this.op_3.Name = "op_3";
            this.op_3.Size = new System.Drawing.Size(42, 37);
            this.op_3.TabIndex = 52;
            this.op_3.Text = "*";
            this.op_3.UseVisualStyleBackColor = true;
            this.op_3.Click += new System.EventHandler(this.opr_click);
            // 
            // op_4
            // 
            this.op_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_4.Location = new System.Drawing.Point(193, 90);
            this.op_4.Name = "op_4";
            this.op_4.Size = new System.Drawing.Size(42, 37);
            this.op_4.TabIndex = 51;
            this.op_4.Text = "/";
            this.op_4.UseVisualStyleBackColor = true;
            this.op_4.Click += new System.EventHandler(this.opr_click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(97, 216);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(42, 37);
            this.btn.TabIndex = 50;
            this.btn.Text = "0";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(97, 90);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 37);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(145, 90);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 37);
            this.btn9.TabIndex = 48;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(49, 133);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 37);
            this.btn4.TabIndex = 47;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(97, 133);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 37);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(145, 133);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 37);
            this.btn6.TabIndex = 45;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(49, 173);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 37);
            this.btn1.TabIndex = 44;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(97, 173);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 37);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(145, 173);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 37);
            this.btn3.TabIndex = 42;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(49, 90);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 37);
            this.btn7.TabIndex = 41;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 62;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.opr_click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.op_1);
            this.Controls.Add(this.op_5);
            this.Controls.Add(this.op_6);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.op_2);
            this.Controls.Add(this.op_3);
            this.Controls.Add(this.op_4);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button op_1;
        private System.Windows.Forms.Button op_5;
        private System.Windows.Forms.Button op_6;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button op_2;
        private System.Windows.Forms.Button op_3;
        private System.Windows.Forms.Button op_4;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button button1;
    }
}

