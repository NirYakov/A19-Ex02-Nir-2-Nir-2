namespace WinFormUI
{
    partial class FormPostSummary
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
            System.Windows.Forms.LinkLabel linkToPostOnFB;
            this.lableStatus = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumOfLikes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            linkToPostOnFB = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkToPostOnFB
            // 
            linkToPostOnFB.AutoSize = true;
            linkToPostOnFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkToPostOnFB.Location = new System.Drawing.Point(12, 345);
            linkToPostOnFB.Name = "linkToPostOnFB";
            linkToPostOnFB.Size = new System.Drawing.Size(251, 25);
            linkToPostOnFB.TabIndex = 1;
            linkToPostOnFB.TabStop = true;
            linkToPostOnFB.Text = "Show in Facebook Website";
            linkToPostOnFB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToPostOnFB_LinkClicked);
            // 
            // lableStatus
            // 
            this.lableStatus.AutoSize = true;
            this.lableStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lableStatus.Location = new System.Drawing.Point(0, 0);
            this.lableStatus.Name = "lableStatus";
            this.lableStatus.Size = new System.Drawing.Size(35, 36);
            this.lableStatus.TabIndex = 0;
            this.lableStatus.Text = "--";
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 20;
            this.listBoxComments.Location = new System.Drawing.Point(351, 194);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(690, 144);
            this.listBoxComments.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Likes : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comments:";
            // 
            // labelNumOfLikes
            // 
            this.labelNumOfLikes.AutoSize = true;
            this.labelNumOfLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfLikes.Location = new System.Drawing.Point(539, 64);
            this.labelNumOfLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumOfLikes.Name = "labelNumOfLikes";
            this.labelNumOfLikes.Size = new System.Drawing.Size(106, 113);
            this.labelNumOfLikes.TabIndex = 6;
            this.labelNumOfLikes.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date added:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(698, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // FormPostSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 378);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNumOfLikes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(linkToPostOnFB);
            this.Controls.Add(this.lableStatus);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "FormPostSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPostSummary";
            this.Load += new System.EventHandler(this.FormPostSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableStatus;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumOfLikes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}