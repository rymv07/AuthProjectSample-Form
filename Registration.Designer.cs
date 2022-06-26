
namespace AuthProjectSample
{
    partial class Regfrm
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
            this.userlbl = new System.Windows.Forms.Label();
            this.pwdlbl = new System.Windows.Forms.Label();
            this.conlbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.confirmTxt = new System.Windows.Forms.TextBox();
            this.regSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.Location = new System.Drawing.Point(28, 36);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(177, 25);
            this.userlbl.TabIndex = 0;
            this.userlbl.Text = "Enter Username :";
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdlbl.Location = new System.Drawing.Point(28, 75);
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(171, 25);
            this.pwdlbl.TabIndex = 0;
            this.pwdlbl.Text = "Enter Password :";
            // 
            // conlbl
            // 
            this.conlbl.AutoSize = true;
            this.conlbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conlbl.Location = new System.Drawing.Point(28, 114);
            this.conlbl.Name = "conlbl";
            this.conlbl.Size = new System.Drawing.Size(195, 25);
            this.conlbl.TabIndex = 0;
            this.conlbl.Text = "Confirm Password :";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(235, 33);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(221, 33);
            this.usernameTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(235, 72);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(221, 33);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // confirmTxt
            // 
            this.confirmTxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTxt.Location = new System.Drawing.Point(235, 111);
            this.confirmTxt.Name = "confirmTxt";
            this.confirmTxt.PasswordChar = '*';
            this.confirmTxt.Size = new System.Drawing.Size(221, 33);
            this.confirmTxt.TabIndex = 3;
            this.confirmTxt.UseSystemPasswordChar = true;
            // 
            // regSubmit
            // 
            this.regSubmit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regSubmit.Location = new System.Drawing.Point(160, 170);
            this.regSubmit.Name = "regSubmit";
            this.regSubmit.Size = new System.Drawing.Size(166, 47);
            this.regSubmit.TabIndex = 4;
            this.regSubmit.Text = "Register";
            this.regSubmit.UseVisualStyleBackColor = true;
            this.regSubmit.Click += new System.EventHandler(this.regSubmit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(98, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Already have Account? Login.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Regfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regSubmit);
            this.Controls.Add(this.confirmTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.conlbl);
            this.Controls.Add(this.pwdlbl);
            this.Controls.Add(this.userlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Regfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Regfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label pwdlbl;
        private System.Windows.Forms.Label conlbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox confirmTxt;
        private System.Windows.Forms.Button regSubmit;
        private System.Windows.Forms.Button button1;
    }
}