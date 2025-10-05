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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableEquipmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowedItemView)).BeginInit();
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
            this.BorrowBtn.Location = new System.Drawing.Point(373, 422);
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
            this.LogOutBtn.Location = new System.Drawing.Point(839, 578);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(147, 47);
            this.LogOutBtn.TabIndex = 52;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(988, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 54;
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 651);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}