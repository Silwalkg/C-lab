namespace labsheet5.partB
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
            this.HomePage = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.emaillable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomePage
            // 
            this.HomePage.AutoSize = true;
            this.HomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePage.Location = new System.Drawing.Point(292, 49);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(135, 29);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "HomePage";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(67, 139);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "label1";
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(67, 185);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(44, 16);
            this.UserNameLable.TabIndex = 2;
            this.UserNameLable.Text = "label2";
            // 
            // emaillable
            // 
            this.emaillable.AutoSize = true;
            this.emaillable.Location = new System.Drawing.Point(67, 234);
            this.emaillable.Name = "emaillable";
            this.emaillable.Size = new System.Drawing.Size(44, 16);
            this.emaillable.TabIndex = 3;
            this.emaillable.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emaillable);
            this.Controls.Add(this.UserNameLable);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.HomePage);
            this.Name = "Form2";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomePage;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.Label emaillable;
    }
}