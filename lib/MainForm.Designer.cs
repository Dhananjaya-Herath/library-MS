namespace lib
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.returnbook_btn = new System.Windows.Forms.Button();
            this.issuebook_btn = new System.Windows.Forms.Button();
            this.addbook_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard1 = new lib.dashboard();
            this.addBooks1 = new lib.AddBooks();
            this.issueBooks1 = new lib.IssueBooks();
            this.returnBooks1 = new lib.ReturnBooks();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 30);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1055, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "library management system";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.logout_btn);
            this.panel3.Controls.Add(this.returnbook_btn);
            this.panel3.Controls.Add(this.issuebook_btn);
            this.panel3.Controls.Add(this.addbook_btn);
            this.panel3.Controls.Add(this.dashboard_btn);
            this.panel3.Controls.Add(this.greet_label);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 570);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOG OUT";
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::lib.Properties.Resources.icons8_logout_rounded_up_filled_20px;
            this.logout_btn.Location = new System.Drawing.Point(12, 507);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(30, 30);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // returnbook_btn
            // 
            this.returnbook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbook_btn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbook_btn.ForeColor = System.Drawing.Color.White;
            this.returnbook_btn.Image = global::lib.Properties.Resources.icons8_return_32px_3;
            this.returnbook_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnbook_btn.Location = new System.Drawing.Point(10, 345);
            this.returnbook_btn.Name = "returnbook_btn";
            this.returnbook_btn.Size = new System.Drawing.Size(200, 45);
            this.returnbook_btn.TabIndex = 5;
            this.returnbook_btn.Text = "RETURN BOOKS";
            this.returnbook_btn.UseVisualStyleBackColor = true;
            this.returnbook_btn.Click += new System.EventHandler(this.returnbook_btn_Click);
            // 
            // issuebook_btn
            // 
            this.issuebook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuebook_btn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuebook_btn.ForeColor = System.Drawing.Color.White;
            this.issuebook_btn.Image = global::lib.Properties.Resources.icons8_book_32px_1;
            this.issuebook_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issuebook_btn.Location = new System.Drawing.Point(11, 292);
            this.issuebook_btn.Name = "issuebook_btn";
            this.issuebook_btn.Size = new System.Drawing.Size(200, 45);
            this.issuebook_btn.TabIndex = 4;
            this.issuebook_btn.Text = "ISSUE BOOKS";
            this.issuebook_btn.UseVisualStyleBackColor = true;
            this.issuebook_btn.Click += new System.EventHandler(this.issuebook_btn_Click);
            // 
            // addbook_btn
            // 
            this.addbook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbook_btn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbook_btn.ForeColor = System.Drawing.Color.White;
            this.addbook_btn.Image = global::lib.Properties.Resources.icons8_book_32px;
            this.addbook_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbook_btn.Location = new System.Drawing.Point(10, 235);
            this.addbook_btn.Name = "addbook_btn";
            this.addbook_btn.Size = new System.Drawing.Size(200, 45);
            this.addbook_btn.TabIndex = 3;
            this.addbook_btn.Text = "ADD BOOKS";
            this.addbook_btn.UseVisualStyleBackColor = true;
            this.addbook_btn.Click += new System.EventHandler(this.addbook_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(10, 170);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(200, 45);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(34, 121);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(134, 18);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Wellcome Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::lib.Properties.Resources.icons8_library_100px;
            this.pictureBox1.Location = new System.Drawing.Point(49, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Controls.Add(this.addBooks1);
            this.panel2.Controls.Add(this.issueBooks1);
            this.panel2.Controls.Add(this.returnBooks1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 570);
            this.panel2.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, -1);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(880, 565);
            this.dashboard1.TabIndex = 3;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, -1);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(880, 565);
            this.addBooks1.TabIndex = 2;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(880, 565);
            this.issueBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(880, 565);
            this.returnBooks1.TabIndex = 0;
            this.returnBooks1.Load += new System.EventHandler(this.returnBooks1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.Button addbook_btn;
        private System.Windows.Forms.Button issuebook_btn;
        private System.Windows.Forms.Button returnbook_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private ReturnBooks returnBooks1;
        private IssueBooks issueBooks1;
        private AddBooks addBooks1;
        private dashboard dashboard1;
    }
}