namespace _07LabExer1
{
    partial class FrmUpdateMember
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
            this.lblStudNo1 = new System.Windows.Forms.Label();
            this.cbStudNum = new System.Windows.Forms.ComboBox();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.lblLastN = new System.Windows.Forms.Label();
            this.txtFirstN = new System.Windows.Forms.TextBox();
            this.lblFirstN = new System.Windows.Forms.Label();
            this.txtMDL = new System.Windows.Forms.TextBox();
            this.lblMDL = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbProg = new System.Windows.Forms.ComboBox();
            this.lblProg2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudNo1
            // 
            this.lblStudNo1.AutoSize = true;
            this.lblStudNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStudNo1.Location = new System.Drawing.Point(9, 9);
            this.lblStudNo1.Name = "lblStudNo1";
            this.lblStudNo1.Size = new System.Drawing.Size(83, 17);
            this.lblStudNo1.TabIndex = 50;
            this.lblStudNo1.Text = "Student No:";
            // 
            // cbStudNum
            // 
            this.cbStudNum.FormattingEnabled = true;
            this.cbStudNum.Location = new System.Drawing.Point(13, 30);
            this.cbStudNum.Name = "cbStudNum";
            this.cbStudNum.Size = new System.Drawing.Size(246, 21);
            this.cbStudNum.TabIndex = 51;
            // 
            // txtLastN
            // 
            this.txtLastN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLastN.Location = new System.Drawing.Point(13, 91);
            this.txtLastN.Multiline = true;
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.Size = new System.Drawing.Size(246, 30);
            this.txtLastN.TabIndex = 53;
            // 
            // lblLastN
            // 
            this.lblLastN.AutoSize = true;
            this.lblLastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLastN.Location = new System.Drawing.Point(13, 71);
            this.lblLastN.Name = "lblLastN";
            this.lblLastN.Size = new System.Drawing.Size(80, 17);
            this.lblLastN.TabIndex = 52;
            this.lblLastN.Text = "Last Name:";
            // 
            // txtFirstN
            // 
            this.txtFirstN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFirstN.Location = new System.Drawing.Point(16, 157);
            this.txtFirstN.Multiline = true;
            this.txtFirstN.Name = "txtFirstN";
            this.txtFirstN.Size = new System.Drawing.Size(243, 30);
            this.txtFirstN.TabIndex = 57;
            // 
            // lblFirstN
            // 
            this.lblFirstN.AutoSize = true;
            this.lblFirstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFirstN.Location = new System.Drawing.Point(13, 136);
            this.lblFirstN.Name = "lblFirstN";
            this.lblFirstN.Size = new System.Drawing.Size(80, 17);
            this.lblFirstN.TabIndex = 56;
            this.lblFirstN.Text = "First Name:";
            // 
            // txtMDL
            // 
            this.txtMDL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMDL.Location = new System.Drawing.Point(16, 232);
            this.txtMDL.Multiline = true;
            this.txtMDL.Name = "txtMDL";
            this.txtMDL.Size = new System.Drawing.Size(243, 30);
            this.txtMDL.TabIndex = 59;
            // 
            // lblMDL
            // 
            this.lblMDL.AutoSize = true;
            this.lblMDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMDL.Location = new System.Drawing.Point(13, 211);
            this.lblMDL.Name = "lblMDL";
            this.lblMDL.Size = new System.Drawing.Size(94, 17);
            this.lblMDL.TabIndex = 58;
            this.lblMDL.Text = "Middle Name:";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAge.Location = new System.Drawing.Point(20, 297);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(239, 36);
            this.txtAge.TabIndex = 61;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAge.Location = new System.Drawing.Point(17, 277);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 17);
            this.lblAge.TabIndex = 60;
            this.lblAge.Text = "Age:";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(20, 369);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(239, 21);
            this.cbGender.TabIndex = 63;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGender.Location = new System.Drawing.Point(17, 349);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 62;
            this.lblGender.Text = "Gender:";
            // 
            // cbProg
            // 
            this.cbProg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbProg.FormattingEnabled = true;
            this.cbProg.Location = new System.Drawing.Point(16, 423);
            this.cbProg.Name = "cbProg";
            this.cbProg.Size = new System.Drawing.Size(243, 21);
            this.cbProg.TabIndex = 66;
            this.cbProg.SelectedIndexChanged += new System.EventHandler(this.cbProg_SelectedIndexChanged);
            // 
            // lblProg2
            // 
            this.lblProg2.AutoSize = true;
            this.lblProg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProg2.Location = new System.Drawing.Point(17, 403);
            this.lblProg2.Name = "lblProg2";
            this.lblProg2.Size = new System.Drawing.Size(66, 17);
            this.lblProg2.TabIndex = 64;
            this.lblProg2.Text = "Program:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(109, 463);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 38);
            this.btnConfirm.TabIndex = 67;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 513);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbProg);
            this.Controls.Add(this.lblProg2);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtMDL);
            this.Controls.Add(this.lblMDL);
            this.Controls.Add(this.txtFirstN);
            this.Controls.Add(this.lblFirstN);
            this.Controls.Add(this.txtLastN);
            this.Controls.Add(this.lblLastN);
            this.Controls.Add(this.cbStudNum);
            this.Controls.Add(this.lblStudNo1);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudNo1;
        private System.Windows.Forms.ComboBox cbStudNum;
        private System.Windows.Forms.TextBox txtLastN;
        private System.Windows.Forms.Label lblLastN;
        private System.Windows.Forms.TextBox txtFirstN;
        private System.Windows.Forms.Label lblFirstN;
        private System.Windows.Forms.TextBox txtMDL;
        private System.Windows.Forms.Label lblMDL;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbProg;
        private System.Windows.Forms.Label lblProg2;
        private System.Windows.Forms.Button btnConfirm;
    }
}