namespace Prototype
{
    partial class Login
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
            this.NewUser_btn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Pass_lbl = new System.Windows.Forms.Label();
            this.User_lbl = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewUser_btn
            // 
            this.NewUser_btn.Location = new System.Drawing.Point(99, 174);
            this.NewUser_btn.Name = "NewUser_btn";
            this.NewUser_btn.Size = new System.Drawing.Size(75, 23);
            this.NewUser_btn.TabIndex = 11;
            this.NewUser_btn.Text = "New User";
            this.NewUser_btn.UseVisualStyleBackColor = true;
            this.NewUser_btn.Click += new System.EventHandler(this.NewUser_btn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(99, 144);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Pass_lbl
            // 
            this.Pass_lbl.AutoSize = true;
            this.Pass_lbl.Location = new System.Drawing.Point(37, 121);
            this.Pass_lbl.Name = "Pass_lbl";
            this.Pass_lbl.Size = new System.Drawing.Size(56, 13);
            this.Pass_lbl.TabIndex = 9;
            this.Pass_lbl.Text = "Password:";
            // 
            // User_lbl
            // 
            this.User_lbl.AutoSize = true;
            this.User_lbl.Location = new System.Drawing.Point(35, 66);
            this.User_lbl.Name = "User_lbl";
            this.User_lbl.Size = new System.Drawing.Size(58, 13);
            this.User_lbl.TabIndex = 8;
            this.User_lbl.Text = "Username:";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(99, 118);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(150, 20);
            this.pass_txt.TabIndex = 7;
            this.pass_txt.UseSystemPasswordChar = true;
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(99, 63);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(150, 20);
            this.user_txt.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NewUser_btn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Pass_lbl);
            this.Controls.Add(this.User_lbl);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NewUser_btn;
        internal System.Windows.Forms.Button LoginBtn;
        internal System.Windows.Forms.Label Pass_lbl;
        internal System.Windows.Forms.Label User_lbl;
        internal System.Windows.Forms.TextBox pass_txt;
        internal System.Windows.Forms.TextBox user_txt;
    }
}

