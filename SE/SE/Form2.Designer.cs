namespace SE
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.userType_txt = new System.Windows.Forms.TextBox();
            this.phoneNo_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(217, 18);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(170, 22);
            this.name_txt.TabIndex = 6;
            // 
            // userType_txt
            // 
            this.userType_txt.Location = new System.Drawing.Point(217, 77);
            this.userType_txt.Name = "userType_txt";
            this.userType_txt.Size = new System.Drawing.Size(170, 22);
            this.userType_txt.TabIndex = 7;
            // 
            // phoneNo_txt
            // 
            this.phoneNo_txt.Location = new System.Drawing.Point(217, 130);
            this.phoneNo_txt.Name = "phoneNo_txt";
            this.phoneNo_txt.Size = new System.Drawing.Size(170, 22);
            this.phoneNo_txt.TabIndex = 8;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(217, 237);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(170, 22);
            this.email_txt.TabIndex = 9;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(217, 296);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(170, 22);
            this.password_txt.TabIndex = 10;
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(217, 178);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(170, 22);
            this.city_txt.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.city_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.email_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.phoneNo_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.userType_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(137, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 388);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "SIGN UP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Go To LOG-IN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Already Have An Account?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 491);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox userType_txt;
        private System.Windows.Forms.TextBox phoneNo_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}