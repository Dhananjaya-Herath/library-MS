namespace lib
{
    partial class AddBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Addbook_importbtn = new System.Windows.Forms.Button();
            this.addBooks_clearbtn = new System.Windows.Forms.Button();
            this.addBooks_deletebtn = new System.Windows.Forms.Button();
            this.addBooks_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBooks_published = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.addBooks_updatebtn = new System.Windows.Forms.Button();
            this.addBooks_addbtn = new System.Windows.Forms.Button();
            this.addBooks_Author = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBooks_picture = new System.Windows.Forms.PictureBox();
            this.addBooks_bookTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(291, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 540);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 471);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Issued Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Addbook_importbtn);
            this.panel1.Controls.Add(this.addBooks_clearbtn);
            this.panel1.Controls.Add(this.addBooks_deletebtn);
            this.panel1.Controls.Add(this.addBooks_status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addBooks_published);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addBooks_updatebtn);
            this.panel1.Controls.Add(this.addBooks_addbtn);
            this.panel1.Controls.Add(this.addBooks_Author);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addBooks_picture);
            this.panel1.Controls.Add(this.addBooks_bookTitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 540);
            this.panel1.TabIndex = 2;
            // 
            // Addbook_importbtn
            // 
            this.Addbook_importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.Addbook_importbtn.ForeColor = System.Drawing.Color.White;
            this.Addbook_importbtn.Location = new System.Drawing.Point(83, 143);
            this.Addbook_importbtn.Name = "Addbook_importbtn";
            this.Addbook_importbtn.Size = new System.Drawing.Size(100, 30);
            this.Addbook_importbtn.TabIndex = 23;
            this.Addbook_importbtn.Text = "Import";
            this.Addbook_importbtn.UseVisualStyleBackColor = false;
            this.Addbook_importbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBooks_clearbtn
            // 
            this.addBooks_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_clearbtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_clearbtn.Location = new System.Drawing.Point(132, 416);
            this.addBooks_clearbtn.Name = "addBooks_clearbtn";
            this.addBooks_clearbtn.Size = new System.Drawing.Size(99, 41);
            this.addBooks_clearbtn.TabIndex = 22;
            this.addBooks_clearbtn.Text = "CLEAR";
            this.addBooks_clearbtn.UseVisualStyleBackColor = false;
            this.addBooks_clearbtn.Click += new System.EventHandler(this.addBooks_clearbtn_Click);
            // 
            // addBooks_deletebtn
            // 
            this.addBooks_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_deletebtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_deletebtn.Location = new System.Drawing.Point(7, 416);
            this.addBooks_deletebtn.Name = "addBooks_deletebtn";
            this.addBooks_deletebtn.Size = new System.Drawing.Size(99, 41);
            this.addBooks_deletebtn.TabIndex = 21;
            this.addBooks_deletebtn.Text = "DELETE";
            this.addBooks_deletebtn.UseVisualStyleBackColor = false;
            this.addBooks_deletebtn.Click += new System.EventHandler(this.addBooks_deletebtn_Click);
            // 
            // addBooks_status
            // 
            this.addBooks_status.FormattingEnabled = true;
            this.addBooks_status.Items.AddRange(new object[] {
            "good",
            "bad"});
            this.addBooks_status.Location = new System.Drawing.Point(93, 305);
            this.addBooks_status.Name = "addBooks_status";
            this.addBooks_status.Size = new System.Drawing.Size(150, 24);
            this.addBooks_status.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status";
            // 
            // addBooks_published
            // 
            this.addBooks_published.Location = new System.Drawing.Point(93, 268);
            this.addBooks_published.Name = "addBooks_published";
            this.addBooks_published.Size = new System.Drawing.Size(152, 22);
            this.addBooks_published.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Published";
            // 
            // addBooks_updatebtn
            // 
            this.addBooks_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_updatebtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_updatebtn.Location = new System.Drawing.Point(132, 369);
            this.addBooks_updatebtn.Name = "addBooks_updatebtn";
            this.addBooks_updatebtn.Size = new System.Drawing.Size(99, 41);
            this.addBooks_updatebtn.TabIndex = 16;
            this.addBooks_updatebtn.Text = "UPDATE";
            this.addBooks_updatebtn.UseVisualStyleBackColor = false;
            this.addBooks_updatebtn.Click += new System.EventHandler(this.addBooks_updatebtn_Click);
            // 
            // addBooks_addbtn
            // 
            this.addBooks_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_addbtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_addbtn.Location = new System.Drawing.Point(7, 369);
            this.addBooks_addbtn.Name = "addBooks_addbtn";
            this.addBooks_addbtn.Size = new System.Drawing.Size(99, 41);
            this.addBooks_addbtn.TabIndex = 15;
            this.addBooks_addbtn.Text = "ADD";
            this.addBooks_addbtn.UseVisualStyleBackColor = false;
            this.addBooks_addbtn.Click += new System.EventHandler(this.addBooks_addbtn_Click);
            // 
            // addBooks_Author
            // 
            this.addBooks_Author.Location = new System.Drawing.Point(94, 227);
            this.addBooks_Author.Name = "addBooks_Author";
            this.addBooks_Author.Size = new System.Drawing.Size(150, 22);
            this.addBooks_Author.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Author";
            // 
            // addBooks_picture
            // 
            this.addBooks_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addBooks_picture.Location = new System.Drawing.Point(83, 46);
            this.addBooks_picture.Name = "addBooks_picture";
            this.addBooks_picture.Size = new System.Drawing.Size(100, 100);
            this.addBooks_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addBooks_picture.TabIndex = 10;
            this.addBooks_picture.TabStop = false;
            // 
            // addBooks_bookTitle
            // 
            this.addBooks_bookTitle.Location = new System.Drawing.Point(95, 188);
            this.addBooks_bookTitle.Name = "addBooks_bookTitle";
            this.addBooks_bookTitle.Size = new System.Drawing.Size(150, 22);
            this.addBooks_bookTitle.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Book Title";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBooks";
            this.Size = new System.Drawing.Size(1079, 565);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addBooks_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBooks_updatebtn;
        private System.Windows.Forms.Button addBooks_addbtn;
        private System.Windows.Forms.TextBox addBooks_Author;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox addBooks_picture;
        private System.Windows.Forms.TextBox addBooks_bookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addBooks_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker addBooks_published;
        private System.Windows.Forms.Button addBooks_clearbtn;
        private System.Windows.Forms.Button addBooks_deletebtn;
        private System.Windows.Forms.Button Addbook_importbtn;
    }
}
