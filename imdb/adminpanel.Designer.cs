namespace imdb
{
    partial class adminpanel
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
            this.components = new System.ComponentModel.Container();
            this.tblusers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new imdb.databaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setadmins = new System.Windows.Forms.Button();
            this.actorstbl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblusers
            // 
            this.tblusers.Location = new System.Drawing.Point(77, 61);
            this.tblusers.Name = "tblusers";
            this.tblusers.Size = new System.Drawing.Size(107, 23);
            this.tblusers.TabIndex = 0;
            this.tblusers.Text = "Load users table";
            this.tblusers.UseVisualStyleBackColor = true;
            this.tblusers.Click += new System.EventHandler(this.tblusers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(927, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // setadmins
            // 
            this.setadmins.Location = new System.Drawing.Point(942, 61);
            this.setadmins.Name = "setadmins";
            this.setadmins.Size = new System.Drawing.Size(105, 23);
            this.setadmins.TabIndex = 2;
            this.setadmins.Text = "Edit admin rights";
            this.setadmins.UseVisualStyleBackColor = true;
            this.setadmins.Click += new System.EventHandler(this.setadmins_Click);
            // 
            // actorstbl
            // 
            this.actorstbl.Location = new System.Drawing.Point(208, 61);
            this.actorstbl.Name = "actorstbl";
            this.actorstbl.Size = new System.Drawing.Size(98, 23);
            this.actorstbl.TabIndex = 3;
            this.actorstbl.Text = "Load actors table";
            this.actorstbl.UseVisualStyleBackColor = true;
            this.actorstbl.Click += new System.EventHandler(this.actorstbl_Click);
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.actorstbl);
            this.Controls.Add(this.setadmins);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tblusers);
            this.Name = "adminpanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tblusers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.Button setadmins;
        private System.Windows.Forms.Button actorstbl;
    }
}