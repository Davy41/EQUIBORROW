namespace EQUIBORROW
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.equiBorrowDataSet = new EQUIBORROW.EquiBorrowDataSet();
            this.equiBorrowDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiBorrowDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiBorrowDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(693, 596);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(147, 47);
            this.RegisterBtn.TabIndex = 28;
            this.RegisterBtn.Text = "Login";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // pwdBox
            // 
            this.pwdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdBox.Location = new System.Drawing.Point(679, 414);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '-';
            this.pwdBox.Size = new System.Drawing.Size(568, 44);
            this.pwdBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(679, 303);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(568, 44);
            this.emailBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(790, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 52);
            this.label1.TabIndex = 19;
            this.label1.Text = "Login Form";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(860, 596);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(288, 29);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New User? Register Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 723);
            this.panel1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(556, 53);
            this.label5.TabIndex = 1;
            this.label5.Text = "Borrow with EQQUIBORROW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Still stressed to have an equipment? ";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Client"});
            this.comboBox1.Location = new System.Drawing.Point(821, 490);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 28);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(708, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "I AM A";
            // 
            // equiBorrowDataSet
            // 
            this.equiBorrowDataSet.DataSetName = "EquiBorrowDataSet";
            this.equiBorrowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiBorrowDataSetBindingSource
            // 
            this.equiBorrowDataSetBindingSource.DataSource = this.equiBorrowDataSet;
            this.equiBorrowDataSetBindingSource.Position = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(211, 375);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 48);
            this.panel7.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(-82, 410);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 48);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(152, 438);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 48);
            this.panel5.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(169, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 48);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(-129, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 48);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(-11, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 48);
            this.panel4.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Location = new System.Drawing.Point(67, 215);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 48);
            this.panel8.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(444, 661);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 48);
            this.panel9.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Location = new System.Drawing.Point(151, 696);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 48);
            this.panel10.TabIndex = 14;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Location = new System.Drawing.Point(385, 724);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 48);
            this.panel11.TabIndex = 15;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Silver;
            this.panel12.Location = new System.Drawing.Point(402, 574);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 48);
            this.panel12.TabIndex = 16;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.LightGray;
            this.panel13.Location = new System.Drawing.Point(104, 561);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 48);
            this.panel13.TabIndex = 17;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkGray;
            this.panel14.Location = new System.Drawing.Point(222, 628);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 48);
            this.panel14.TabIndex = 18;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gainsboro;
            this.panel15.Location = new System.Drawing.Point(300, 501);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 48);
            this.panel15.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 734);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiBorrowDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiBorrowDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource equiBorrowDataSetBindingSource;
        private EquiBorrowDataSet equiBorrowDataSet;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
    }
}

