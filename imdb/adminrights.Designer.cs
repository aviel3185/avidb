namespace imdb
{
    partial class adminrights
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toggler = new System.Windows.Forms.Button();
            this.progressl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter user\'s mail / ID to toggle rights:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // toggler
            // 
            this.toggler.Location = new System.Drawing.Point(123, 180);
            this.toggler.Name = "toggler";
            this.toggler.Size = new System.Drawing.Size(151, 23);
            this.toggler.TabIndex = 2;
            this.toggler.Text = "Click to toggle admin right!";
            this.toggler.UseVisualStyleBackColor = true;
            this.toggler.Click += new System.EventHandler(this.toggler_Click);
            // 
            // progressl
            // 
            this.progressl.AutoSize = true;
            this.progressl.Location = new System.Drawing.Point(154, 267);
            this.progressl.Name = "progressl";
            this.progressl.Size = new System.Drawing.Size(0, 13);
            this.progressl.TabIndex = 3;
            // 
            // adminrights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 355);
            this.Controls.Add(this.progressl);
            this.Controls.Add(this.toggler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "adminrights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminrights";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button toggler;
        private System.Windows.Forms.Label progressl;
    }
}