namespace Prototype
{
    partial class SignIn
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
            this.UserLim_lbl = new System.Windows.Forms.Label();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.ReEnterInfo_lbl = new System.Windows.Forms.Label();
            this.PassLim_lbl = new System.Windows.Forms.Label();
            this.ReEnter_txt = new System.Windows.Forms.TextBox();
            this.ReEnter_lbl = new System.Windows.Forms.Label();
            this.Pass_lbl = new System.Windows.Forms.Label();
            this.User_lbl = new System.Windows.Forms.Label();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.User_txt = new System.Windows.Forms.TextBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLim_lbl
            // 
            this.UserLim_lbl.AutoSize = true;
            this.UserLim_lbl.Location = new System.Drawing.Point(161, 38);
            this.UserLim_lbl.Name = "UserLim_lbl";
            this.UserLim_lbl.Size = new System.Drawing.Size(93, 13);
            this.UserLim_lbl.TabIndex = 21;
            this.UserLim_lbl.Text = "4 to 15 characters";
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(101, 199);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(75, 23);
            this.Confirm_btn.TabIndex = 20;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // ReEnterInfo_lbl
            // 
            this.ReEnterInfo_lbl.AutoSize = true;
            this.ReEnterInfo_lbl.Location = new System.Drawing.Point(126, 141);
            this.ReEnterInfo_lbl.Name = "ReEnterInfo_lbl";
            this.ReEnterInfo_lbl.Size = new System.Drawing.Size(0, 13);
            this.ReEnterInfo_lbl.TabIndex = 19;
            // 
            // PassLim_lbl
            // 
            this.PassLim_lbl.AutoSize = true;
            this.PassLim_lbl.Location = new System.Drawing.Point(158, 93);
            this.PassLim_lbl.Name = "PassLim_lbl";
            this.PassLim_lbl.Size = new System.Drawing.Size(93, 13);
            this.PassLim_lbl.TabIndex = 18;
            this.PassLim_lbl.Text = "6 to 20 characters";
            // 
            // ReEnter_txt
            // 
            this.ReEnter_txt.Location = new System.Drawing.Point(129, 156);
            this.ReEnter_txt.Name = "ReEnter_txt";
            this.ReEnter_txt.Size = new System.Drawing.Size(146, 20);
            this.ReEnter_txt.TabIndex = 17;
            this.ReEnter_txt.TextChanged += new System.EventHandler(this.ReEnter_txt_TextChanged);
            // 
            // ReEnter_lbl
            // 
            this.ReEnter_lbl.AutoSize = true;
            this.ReEnter_lbl.Location = new System.Drawing.Point(9, 159);
            this.ReEnter_lbl.Name = "ReEnter_lbl";
            this.ReEnter_lbl.Size = new System.Drawing.Size(114, 13);
            this.ReEnter_lbl.TabIndex = 16;
            this.ReEnter_lbl.Text = "Enter Password Again:";
            // 
            // Pass_lbl
            // 
            this.Pass_lbl.AutoSize = true;
            this.Pass_lbl.Location = new System.Drawing.Point(65, 112);
            this.Pass_lbl.Name = "Pass_lbl";
            this.Pass_lbl.Size = new System.Drawing.Size(56, 13);
            this.Pass_lbl.TabIndex = 15;
            this.Pass_lbl.Text = "Password:";
            // 
            // User_lbl
            // 
            this.User_lbl.AutoSize = true;
            this.User_lbl.Location = new System.Drawing.Point(65, 60);
            this.User_lbl.Name = "User_lbl";
            this.User_lbl.Size = new System.Drawing.Size(58, 13);
            this.User_lbl.TabIndex = 14;
            this.User_lbl.Text = "Username:";
            // 
            // Pass_txt
            // 
            this.Pass_txt.Location = new System.Drawing.Point(129, 109);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.Size = new System.Drawing.Size(146, 20);
            this.Pass_txt.TabIndex = 13;
            // 
            // User_txt
            // 
            this.User_txt.Location = new System.Drawing.Point(129, 57);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(146, 20);
            this.User_txt.TabIndex = 12;
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(12, 13);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(75, 23);
            this.Back_btn.TabIndex = 22;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.UserLim_lbl);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.ReEnterInfo_lbl);
            this.Controls.Add(this.PassLim_lbl);
            this.Controls.Add(this.ReEnter_txt);
            this.Controls.Add(this.ReEnter_lbl);
            this.Controls.Add(this.Pass_lbl);
            this.Controls.Add(this.User_lbl);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.User_txt);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label UserLim_lbl;
        internal System.Windows.Forms.Button Confirm_btn;
        internal System.Windows.Forms.Label ReEnterInfo_lbl;
        internal System.Windows.Forms.Label PassLim_lbl;
        internal System.Windows.Forms.TextBox ReEnter_txt;
        internal System.Windows.Forms.Label ReEnter_lbl;
        internal System.Windows.Forms.Label Pass_lbl;
        internal System.Windows.Forms.Label User_lbl;
        internal System.Windows.Forms.TextBox Pass_txt;
        internal System.Windows.Forms.TextBox User_txt;
        private System.Windows.Forms.Button Back_btn;
    }
}