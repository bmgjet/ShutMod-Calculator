namespace ShuntCalculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(11, 77);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(285, 31);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = "350";
            this.toolTip1.SetToolTip(this.maskedTextBox1, "Enter your cards default power limit");
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maskedTextBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(500, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 29);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "3 Plug";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(359, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 29);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2 Plug";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(317, 162);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(226, 29);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Slot Shunt modded";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(317, 211);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(389, 29);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Shunts Replaced instead of stacked";
            this.toolTip1.SetToolTip(this.checkBox1, "Replacing the shunt instead of stacking them.");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "700";
            this.toolTip1.SetToolTip(this.label7, "New power limit with card on defaulk setting.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Power Limit:";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(16, 243);
            this.maskedTextBox4.Mask = "000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.PromptChar = ' ';
            this.maskedTextBox4.Size = new System.Drawing.Size(142, 31);
            this.maskedTextBox4.TabIndex = 7;
            this.maskedTextBox4.Text = "005";
            this.toolTip1.SetToolTip(this.maskedTextBox4, "Shunt value that is stacked or value of resistor replacing.");
            this.maskedTextBox4.TextChanged += new System.EventHandler(this.maskedTextBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Added Shunt";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(11, 162);
            this.maskedTextBox3.Mask = "000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.PromptChar = ' ';
            this.maskedTextBox3.Size = new System.Drawing.Size(142, 31);
            this.maskedTextBox3.TabIndex = 5;
            this.maskedTextBox3.Text = "005";
            this.toolTip1.SetToolTip(this.maskedTextBox3, "Default Shunt resistors found on gpu");
            this.maskedTextBox3.TextChanged += new System.EventHandler(this.maskedTextBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Default Shunt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cards Power Limit (W):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maths";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "            ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "               ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "         ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "              ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version:  0.3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ShuntMod Calculator by bmgjet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
    }
}

