namespace Fire_Range_Automation_System
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.displayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.soldierNoTextBox = new System.Windows.Forms.TextBox();
            this.soldierNameTextBox = new System.Windows.Forms.TextBox();
            this.target1ScoreTextBox = new System.Windows.Forms.TextBox();
            this.target2ScoreTextBox = new System.Windows.Forms.TextBox();
            this.target3ScoreTextBox = new System.Windows.Forms.TextBox();
            this.target4ScoreTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.soldierNoRadioButton = new System.Windows.Forms.RadioButton();
            this.soldierNameRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.topAverageScorer = new System.Windows.Forms.TextBox();
            this.topTotalScorer = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(45, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Controls.Add(this.target4ScoreTextBox);
            this.groupBox2.Controls.Add(this.target3ScoreTextBox);
            this.groupBox2.Controls.Add(this.target2ScoreTextBox);
            this.groupBox2.Controls.Add(this.target1ScoreTextBox);
            this.groupBox2.Controls.Add(this.soldierNameTextBox);
            this.groupBox2.Controls.Add(this.soldierNoTextBox);
            this.groupBox2.Location = new System.Drawing.Point(45, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 383);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soldier Score Register";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.topTotalScorer);
            this.groupBox3.Controls.Add(this.topAverageScorer);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.show);
            this.groupBox3.Controls.Add(this.displayRichTextBox);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(423, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 505);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Soldier Information";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.soldierNameRadioButton);
            this.groupBox4.Controls.Add(this.soldierNoRadioButton);
            this.groupBox4.Controls.Add(this.search);
            this.groupBox4.Controls.Add(this.searchTextBox);
            this.groupBox4.Location = new System.Drawing.Point(13, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 106);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Criteria";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // displayRichTextBox
            // 
            this.displayRichTextBox.Location = new System.Drawing.Point(21, 172);
            this.displayRichTextBox.Name = "displayRichTextBox";
            this.displayRichTextBox.Size = new System.Drawing.Size(451, 256);
            this.displayRichTextBox.TabIndex = 1;
            this.displayRichTextBox.Text = "";
            // 
            // soldierNoTextBox
            // 
            this.soldierNoTextBox.Location = new System.Drawing.Point(99, 20);
            this.soldierNoTextBox.Name = "soldierNoTextBox";
            this.soldierNoTextBox.Size = new System.Drawing.Size(174, 20);
            this.soldierNoTextBox.TabIndex = 0;
            // 
            // soldierNameTextBox
            // 
            this.soldierNameTextBox.Location = new System.Drawing.Point(99, 58);
            this.soldierNameTextBox.Name = "soldierNameTextBox";
            this.soldierNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.soldierNameTextBox.TabIndex = 0;
            // 
            // target1ScoreTextBox
            // 
            this.target1ScoreTextBox.Location = new System.Drawing.Point(106, 96);
            this.target1ScoreTextBox.Name = "target1ScoreTextBox";
            this.target1ScoreTextBox.Size = new System.Drawing.Size(138, 20);
            this.target1ScoreTextBox.TabIndex = 0;
            // 
            // target2ScoreTextBox
            // 
            this.target2ScoreTextBox.Location = new System.Drawing.Point(106, 135);
            this.target2ScoreTextBox.Name = "target2ScoreTextBox";
            this.target2ScoreTextBox.Size = new System.Drawing.Size(138, 20);
            this.target2ScoreTextBox.TabIndex = 0;
            // 
            // target3ScoreTextBox
            // 
            this.target3ScoreTextBox.Location = new System.Drawing.Point(106, 172);
            this.target3ScoreTextBox.Name = "target3ScoreTextBox";
            this.target3ScoreTextBox.Size = new System.Drawing.Size(138, 20);
            this.target3ScoreTextBox.TabIndex = 0;
            // 
            // target4ScoreTextBox
            // 
            this.target4ScoreTextBox.Location = new System.Drawing.Point(106, 207);
            this.target4ScoreTextBox.Name = "target4ScoreTextBox";
            this.target4ScoreTextBox.Size = new System.Drawing.Size(138, 20);
            this.target4ScoreTextBox.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(92, 56);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(138, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(134, 255);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 37);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(236, 55);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(316, 146);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 0;
            this.show.Text = "Show all";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soldier No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soldier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target 1 Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Target 2 Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Target 3 Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Target 4 Score";
            // 
            // soldierNoRadioButton
            // 
            this.soldierNoRadioButton.AutoSize = true;
            this.soldierNoRadioButton.Location = new System.Drawing.Point(92, 27);
            this.soldierNoRadioButton.Name = "soldierNoRadioButton";
            this.soldierNoRadioButton.Size = new System.Drawing.Size(74, 17);
            this.soldierNoRadioButton.TabIndex = 2;
            this.soldierNoRadioButton.TabStop = true;
            this.soldierNoRadioButton.Text = "Soldier No";
            this.soldierNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // soldierNameRadioButton
            // 
            this.soldierNameRadioButton.AutoSize = true;
            this.soldierNameRadioButton.Location = new System.Drawing.Point(170, 27);
            this.soldierNameRadioButton.Name = "soldierNameRadioButton";
            this.soldierNameRadioButton.Size = new System.Drawing.Size(88, 17);
            this.soldierNameRadioButton.TabIndex = 3;
            this.soldierNameRadioButton.TabStop = true;
            this.soldierNameRadioButton.Text = "Soldier Name";
            this.soldierNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Search By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Top Average Scorer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Top Total Scorer";
            // 
            // topAverageScorer
            // 
            this.topAverageScorer.Location = new System.Drawing.Point(169, 443);
            this.topAverageScorer.Name = "topAverageScorer";
            this.topAverageScorer.Size = new System.Drawing.Size(218, 20);
            this.topAverageScorer.TabIndex = 3;
            // 
            // topTotalScorer
            // 
            this.topTotalScorer.Location = new System.Drawing.Point(169, 479);
            this.topTotalScorer.Name = "topTotalScorer";
            this.topTotalScorer.Size = new System.Drawing.Size(218, 20);
            this.topTotalScorer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Fire Range Automation System";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox target4ScoreTextBox;
        private System.Windows.Forms.TextBox target3ScoreTextBox;
        private System.Windows.Forms.TextBox target2ScoreTextBox;
        private System.Windows.Forms.TextBox target1ScoreTextBox;
        private System.Windows.Forms.TextBox soldierNameTextBox;
        private System.Windows.Forms.TextBox soldierNoTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.RichTextBox displayRichTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox topTotalScorer;
        private System.Windows.Forms.TextBox topAverageScorer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton soldierNameRadioButton;
        private System.Windows.Forms.RadioButton soldierNoRadioButton;
    }
}

