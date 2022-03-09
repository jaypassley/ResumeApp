namespace ResumeApp
{
    partial class authentication_form
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
            this.lb_adv_tech_heading = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_adv_tech_heading
            // 
            this.lb_adv_tech_heading.AutoSize = true;
            this.lb_adv_tech_heading.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adv_tech_heading.ForeColor = System.Drawing.Color.Maroon;
            this.lb_adv_tech_heading.Location = new System.Drawing.Point(44, 9);
            this.lb_adv_tech_heading.Name = "lb_adv_tech_heading";
            this.lb_adv_tech_heading.Size = new System.Drawing.Size(616, 55);
            this.lb_adv_tech_heading.TabIndex = 0;
            this.lb_adv_tech_heading.Text = "Advance Technology Experts";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(115, 156);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(153, 26);
            this.tb_username.TabIndex = 1;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(84, 117);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(62, 24);
            this.lb_login.TabIndex = 2;
            this.lb_login.Text = "Login";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(39, 155);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(70, 19);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "Username";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(39, 193);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(69, 19);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(115, 190);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(153, 26);
            this.tb_password.TabIndex = 5;
            // 
            // authentication_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 424);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_adv_tech_heading);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "authentication_form";
            this.Text = "Authentication_Form";
            this.Load += new System.EventHandler(this.authentication_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_adv_tech_heading;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_password;
    }
}

