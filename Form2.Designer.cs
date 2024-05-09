namespace _69003_Yuliya_Yafimava_T6
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPaperBook = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbEBook = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbAudioBook = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbNarrator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.gbPaperBook.SuspendLayout();
            this.gbEBook.SuspendLayout();
            this.gbAudioBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(313, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(313, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type:";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(143, 105);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(121, 27);
            this.tbTitle.TabIndex = 4;
            // 
            // tbCategory
            // 
            this.tbCategory.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.tbCategory.Location = new System.Drawing.Point(426, 106);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(121, 27);
            this.tbCategory.TabIndex = 5;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.tbAuthor.Location = new System.Drawing.Point(143, 167);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(121, 27);
            this.tbAuthor.TabIndex = 6;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F);
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Paper Book",
            "E-Book",
            "Audio Book"});
            this.cbType.Location = new System.Drawing.Point(426, 166);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 26);
            this.cbType.TabIndex = 7;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(242, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add Book";
            // 
            // gbPaperBook
            // 
            this.gbPaperBook.BackColor = System.Drawing.Color.LightBlue;
            this.gbPaperBook.Controls.Add(this.button1);
            this.gbPaperBook.Controls.Add(this.tbPages);
            this.gbPaperBook.Controls.Add(this.tbISBN);
            this.gbPaperBook.Controls.Add(this.label7);
            this.gbPaperBook.Controls.Add(this.label6);
            this.gbPaperBook.Font = new System.Drawing.Font("Constantia", 9F);
            this.gbPaperBook.Location = new System.Drawing.Point(68, 236);
            this.gbPaperBook.Name = "gbPaperBook";
            this.gbPaperBook.Size = new System.Drawing.Size(479, 100);
            this.gbPaperBook.TabIndex = 9;
            this.gbPaperBook.TabStop = false;
            this.gbPaperBook.Text = "Paper Book";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(358, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPages
            // 
            this.tbPages.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.tbPages.Location = new System.Drawing.Point(196, 62);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(100, 25);
            this.tbPages.TabIndex = 3;
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN.Location = new System.Drawing.Point(26, 62);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(100, 25);
            this.tbISBN.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pages:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ISBN:";
            // 
            // gbEBook
            // 
            this.gbEBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbEBook.Controls.Add(this.button2);
            this.gbEBook.Controls.Add(this.tbSize);
            this.gbEBook.Controls.Add(this.tbFormat);
            this.gbEBook.Controls.Add(this.label9);
            this.gbEBook.Controls.Add(this.label8);
            this.gbEBook.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEBook.Location = new System.Drawing.Point(68, 377);
            this.gbEBook.Name = "gbEBook";
            this.gbEBook.Size = new System.Drawing.Size(479, 100);
            this.gbEBook.TabIndex = 10;
            this.gbEBook.TabStop = false;
            this.gbEBook.Text = "E-Book";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(358, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.tbSize.Location = new System.Drawing.Point(196, 60);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 25);
            this.tbSize.TabIndex = 5;
            // 
            // tbFormat
            // 
            this.tbFormat.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.tbFormat.Location = new System.Drawing.Point(26, 61);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(100, 25);
            this.tbFormat.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "File Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Format";
            // 
            // gbAudioBook
            // 
            this.gbAudioBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbAudioBook.Controls.Add(this.button3);
            this.gbAudioBook.Controls.Add(this.tbDuration);
            this.gbAudioBook.Controls.Add(this.tbNarrator);
            this.gbAudioBook.Controls.Add(this.label11);
            this.gbAudioBook.Controls.Add(this.label10);
            this.gbAudioBook.Font = new System.Drawing.Font("Constantia", 9F);
            this.gbAudioBook.Location = new System.Drawing.Point(68, 520);
            this.gbAudioBook.Name = "gbAudioBook";
            this.gbAudioBook.Size = new System.Drawing.Size(479, 100);
            this.gbAudioBook.TabIndex = 11;
            this.gbAudioBook.TabStop = false;
            this.gbAudioBook.Text = "Audio Book";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(358, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbDuration
            // 
            this.tbDuration.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.tbDuration.Location = new System.Drawing.Point(196, 59);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(100, 25);
            this.tbDuration.TabIndex = 15;
            // 
            // tbNarrator
            // 
            this.tbNarrator.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.tbNarrator.Location = new System.Drawing.Point(19, 59);
            this.tbNarrator.Name = "tbNarrator";
            this.tbNarrator.Size = new System.Drawing.Size(100, 25);
            this.tbNarrator.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(204, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Duration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Narrator";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(68, 657);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(479, 38);
            this.button4.TabIndex = 12;
            this.button4.Text = "Back to Menu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(626, 735);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gbAudioBook);
            this.Controls.Add(this.gbEBook);
            this.Controls.Add(this.gbPaperBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbPaperBook.ResumeLayout(false);
            this.gbPaperBook.PerformLayout();
            this.gbEBook.ResumeLayout(false);
            this.gbEBook.PerformLayout();
            this.gbAudioBook.ResumeLayout(false);
            this.gbAudioBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPaperBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbEBook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbAudioBook;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbNarrator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
    }
}