namespace EQUIBORROW
{
    partial class ClientPage
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.AvailableEquipmentView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrowedItemView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableEquipmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowedItemView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(351, 68);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(147, 47);
            this.SearchBtn.TabIndex = 46;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Silver;
            this.searchBox.Location = new System.Drawing.Point(25, 68);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(303, 47);
            this.searchBox.TabIndex = 45;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.Location = new System.Drawing.Point(371, 367);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(147, 47);
            this.BorrowBtn.TabIndex = 42;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = true;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click_1);
            // 
            // AvailableEquipmentView
            // 
            this.AvailableEquipmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableEquipmentView.Location = new System.Drawing.Point(25, 140);
            this.AvailableEquipmentView.Name = "AvailableEquipmentView";
            this.AvailableEquipmentView.RowHeadersWidth = 62;
            this.AvailableEquipmentView.RowTemplate.Height = 28;
            this.AvailableEquipmentView.Size = new System.Drawing.Size(473, 178);
            this.AvailableEquipmentView.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 52);
            this.label1.TabIndex = 40;
            this.label1.Text = "Equipment Borrow Form";
            // 
            // BorrowedItemView
            // 
            this.BorrowedItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowedItemView.Location = new System.Drawing.Point(601, 140);
            this.BorrowedItemView.Name = "BorrowedItemView";
            this.BorrowedItemView.RowHeadersWidth = 62;
            this.BorrowedItemView.RowTemplate.Height = 28;
            this.BorrowedItemView.Size = new System.Drawing.Size(473, 178);
            this.BorrowedItemView.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Items you Borrowed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(940, 576);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(147, 47);
            this.LogOutBtn.TabIndex = 52;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(988, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 54;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(651, 367);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(147, 47);
            this.ReturnBtn.TabIndex = 55;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(318, 591);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 48);
            this.panel7.TabIndex = 62;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(19, 629);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 48);
            this.panel6.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(253, 657);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 48);
            this.panel5.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(278, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 48);
            this.panel2.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Location = new System.Drawing.Point(-28, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 48);
            this.panel3.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(90, 561);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 48);
            this.panel4.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(168, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 48);
            this.panel1.TabIndex = 56;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(196, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 48);
            this.panel8.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Location = new System.Drawing.Point(518, 561);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 48);
            this.panel9.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(752, 507);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 48);
            this.panel10.TabIndex = 15;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Silver;
            this.panel11.Location = new System.Drawing.Point(724, 591);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 48);
            this.panel11.TabIndex = 16;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Location = new System.Drawing.Point(402, 426);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 48);
            this.panel12.TabIndex = 17;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkGray;
            this.panel13.Location = new System.Drawing.Point(476, 480);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 48);
            this.panel13.TabIndex = 18;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gainsboro;
            this.panel14.Location = new System.Drawing.Point(672, 434);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 48);
            this.panel14.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(921, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Hello>>>";
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 651);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BorrowedItemView);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.BorrowBtn);
            this.Controls.Add(this.AvailableEquipmentView);
            this.Controls.Add(this.label1);
            this.Name = "ClientPage";
            this.Text = "ClientPage";
            this.Load += new System.EventHandler(this.ClientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableEquipmentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowedItemView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.DataGridView AvailableEquipmentView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BorrowedItemView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label3;
    }
}