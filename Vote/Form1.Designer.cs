namespace Vote
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtSessionId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVoteId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCandidateId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(103, 16);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(867, 28);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://1048762540.tt.ylwlb.com/Home/index.php?m=Index&a=vote&vid={0}&id={1}&tp=";
            // 
            // txtSessionId
            // 
            this.txtSessionId.Location = new System.Drawing.Point(177, 232);
            this.txtSessionId.Name = "txtSessionId";
            this.txtSessionId.Size = new System.Drawing.Size(793, 28);
            this.txtSessionId.TabIndex = 4;
            this.txtSessionId.Text = "5a94217019e4e940e2c9c44e42299af3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "SessionId:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "VoteId:";
            // 
            // txtVoteId
            // 
            this.txtVoteId.Location = new System.Drawing.Point(177, 71);
            this.txtVoteId.Name = "txtVoteId";
            this.txtVoteId.Size = new System.Drawing.Size(793, 28);
            this.txtVoteId.TabIndex = 7;
            this.txtVoteId.Text = "317017338";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "CandidateId:";
            // 
            // txtCandidateId
            // 
            this.txtCandidateId.Location = new System.Drawing.Point(177, 116);
            this.txtCandidateId.Name = "txtCandidateId";
            this.txtCandidateId.Size = new System.Drawing.Size(793, 28);
            this.txtCandidateId.TabIndex = 9;
            this.txtCandidateId.Text = "94780";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vote";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(177, 278);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 28);
            this.txtNumber.TabIndex = 11;
            this.txtNumber.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "time(s)";
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(654, 275);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(316, 30);
            this.btnVote.TabIndex = 12;
            this.btnVote.Text = "Vote!!!";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Token:";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(177, 168);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(793, 28);
            this.txtToken.TabIndex = 14;
            this.txtToken.Text = "gh_588a44061b10";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(48, 356);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(922, 247);
            this.txtLog.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 615);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCandidateId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVoteId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSessionId);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtSessionId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVoteId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCandidateId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtLog;
    }
}

