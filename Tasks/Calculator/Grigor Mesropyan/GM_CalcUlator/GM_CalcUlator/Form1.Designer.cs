namespace GM_CalcUlator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c_1 = new System.Windows.Forms.Button();
            this.c_2 = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.c_5 = new System.Windows.Forms.Button();
            this.c_4 = new System.Windows.Forms.Button();
            this.c_6 = new System.Windows.Forms.Button();
            this.c_9 = new System.Windows.Forms.Button();
            this.c_7 = new System.Windows.Forms.Button();
            this.c_8 = new System.Windows.Forms.Button();
            this.c_0 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.even = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c_1
            // 
            this.c_1.BackColor = System.Drawing.SystemColors.Control;
            this.c_1.Location = new System.Drawing.Point(12, 58);
            this.c_1.Name = "c_1";
            this.c_1.Size = new System.Drawing.Size(75, 23);
            this.c_1.TabIndex = 0;
            this.c_1.Text = "1";
            this.c_1.UseVisualStyleBackColor = true;
            this.c_1.Click += new System.EventHandler(this.c_1_Click);
            // 
            // c_2
            // 
            this.c_2.Location = new System.Drawing.Point(106, 58);
            this.c_2.Name = "c_2";
            this.c_2.Size = new System.Drawing.Size(75, 23);
            this.c_2.TabIndex = 1;
            this.c_2.Text = "2";
            this.c_2.UseVisualStyleBackColor = true;
            this.c_2.Click += new System.EventHandler(this.c_2_Click);
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Screen.Location = new System.Drawing.Point(12, 12);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(170, 42);
            this.Screen.TabIndex = 2;
            this.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Screen.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(254, 102);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(39, 44);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(199, 45);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(94, 51);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(12, 87);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 23);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // c_5
            // 
            this.c_5.Location = new System.Drawing.Point(12, 116);
            this.c_5.Name = "c_5";
            this.c_5.Size = new System.Drawing.Size(75, 23);
            this.c_5.TabIndex = 6;
            this.c_5.Text = "5";
            this.c_5.UseVisualStyleBackColor = true;
            this.c_5.Click += new System.EventHandler(this.c_5_Click);
            // 
            // c_4
            // 
            this.c_4.Location = new System.Drawing.Point(107, 87);
            this.c_4.Name = "c_4";
            this.c_4.Size = new System.Drawing.Size(75, 23);
            this.c_4.TabIndex = 7;
            this.c_4.Text = "4";
            this.c_4.UseVisualStyleBackColor = true;
            this.c_4.Click += new System.EventHandler(this.c_4_Click);
            // 
            // c_6
            // 
            this.c_6.Location = new System.Drawing.Point(106, 115);
            this.c_6.Name = "c_6";
            this.c_6.Size = new System.Drawing.Size(75, 23);
            this.c_6.TabIndex = 8;
            this.c_6.Text = "6";
            this.c_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.c_6.UseVisualStyleBackColor = true;
            this.c_6.Click += new System.EventHandler(this.c_6_Click);
            // 
            // c_9
            // 
            this.c_9.Location = new System.Drawing.Point(12, 174);
            this.c_9.Name = "c_9";
            this.c_9.Size = new System.Drawing.Size(75, 23);
            this.c_9.TabIndex = 9;
            this.c_9.Text = "9";
            this.c_9.UseVisualStyleBackColor = true;
            this.c_9.Click += new System.EventHandler(this.c_9_Click);
            // 
            // c_7
            // 
            this.c_7.Location = new System.Drawing.Point(12, 146);
            this.c_7.Name = "c_7";
            this.c_7.Size = new System.Drawing.Size(75, 23);
            this.c_7.TabIndex = 10;
            this.c_7.Text = "7";
            this.c_7.UseVisualStyleBackColor = true;
            this.c_7.Click += new System.EventHandler(this.c_7_Click);
            // 
            // c_8
            // 
            this.c_8.Location = new System.Drawing.Point(106, 144);
            this.c_8.Name = "c_8";
            this.c_8.Size = new System.Drawing.Size(75, 23);
            this.c_8.TabIndex = 11;
            this.c_8.Text = "8";
            this.c_8.UseVisualStyleBackColor = true;
            this.c_8.Click += new System.EventHandler(this.c_8_Click);
            // 
            // c_0
            // 
            this.c_0.Location = new System.Drawing.Point(106, 174);
            this.c_0.Name = "c_0";
            this.c_0.Size = new System.Drawing.Size(75, 23);
            this.c_0.TabIndex = 12;
            this.c_0.Text = "0";
            this.c_0.UseVisualStyleBackColor = true;
            this.c_0.Click += new System.EventHandler(this.c_0_Click);
            // 
            // minus
            // 
            this.minus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minus.Cursor = System.Windows.Forms.Cursors.Default;
            this.minus.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(199, 153);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(39, 45);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // even
            // 
            this.even.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.even.Location = new System.Drawing.Point(199, 102);
            this.even.Name = "even";
            this.even.Size = new System.Drawing.Size(39, 45);
            this.even.TabIndex = 14;
            this.even.Text = "*";
            this.even.UseVisualStyleBackColor = true;
            this.even.Click += new System.EventHandler(this.even_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(254, 153);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(39, 44);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(199, 1);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 38);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(310, 227);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.even);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.c_0);
            this.Controls.Add(this.c_8);
            this.Controls.Add(this.c_7);
            this.Controls.Add(this.c_9);
            this.Controls.Add(this.c_6);
            this.Controls.Add(this.c_4);
            this.Controls.Add(this.c_5);
            this.Controls.Add(this.three);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.c_2);
            this.Controls.Add(this.c_1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator_v_1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c_1;
        private System.Windows.Forms.Button c_2;
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button c_5;
        private System.Windows.Forms.Button c_4;
        private System.Windows.Forms.Button c_6;
        private System.Windows.Forms.Button c_9;
        private System.Windows.Forms.Button c_7;
        private System.Windows.Forms.Button c_8;
        private System.Windows.Forms.Button c_0;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button even;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
    }
}

