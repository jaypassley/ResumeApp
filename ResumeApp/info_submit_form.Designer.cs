namespace ResumeApp
{
    partial class info_submit_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_adv_tech_heading
            // 
            this.lb_adv_tech_heading.AutoSize = true;
            this.lb_adv_tech_heading.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adv_tech_heading.ForeColor = System.Drawing.Color.Maroon;
            this.lb_adv_tech_heading.Location = new System.Drawing.Point(53, 9);
            this.lb_adv_tech_heading.Name = "lb_adv_tech_heading";
            this.lb_adv_tech_heading.Size = new System.Drawing.Size(616, 55);
            this.lb_adv_tech_heading.TabIndex = 1;
            this.lb_adv_tech_heading.Text = "Advance Technology Experts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name";
            // 
            // info_submit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_adv_tech_heading);
            this.Name = "info_submit_form";
            this.Text = "Info_Submission_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_adv_tech_heading;
        private System.Windows.Forms.Label label1;
    }
}