namespace SQLToNoSQLConverter
{
    partial class SQLToNoSQLConverterForm
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
            this.btnConvertAllTables = new System.Windows.Forms.Button();
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.lbConnectionString = new System.Windows.Forms.Label();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.lbTable = new System.Windows.Forms.Label();
            this.btnConvertTable = new System.Windows.Forms.Button();
            this.tbProgressLog = new System.Windows.Forms.TextBox();
            this.lbProgressLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvertAllTables
            // 
            this.btnConvertAllTables.Location = new System.Drawing.Point(395, 185);
            this.btnConvertAllTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvertAllTables.Name = "btnConvertAllTables";
            this.btnConvertAllTables.Size = new System.Drawing.Size(358, 28);
            this.btnConvertAllTables.TabIndex = 0;
            this.btnConvertAllTables.Text = "Convert all database tables to Mongodb collections";
            this.btnConvertAllTables.UseVisualStyleBackColor = true;
            this.btnConvertAllTables.Click += new System.EventHandler(this.btnConvertAllTables_Click);
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(207, 126);
            this.tbConnectionString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(817, 22);
            this.tbConnectionString.TabIndex = 1;
            // 
            // lbConnectionString
            // 
            this.lbConnectionString.AutoSize = true;
            this.lbConnectionString.Location = new System.Drawing.Point(16, 126);
            this.lbConnectionString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConnectionString.Name = "lbConnectionString";
            this.lbConnectionString.Size = new System.Drawing.Size(181, 17);
            this.lbConnectionString.TabIndex = 2;
            this.lbConnectionString.Text = "Database connection string";
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(207, 245);
            this.tbTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(817, 22);
            this.tbTable.TabIndex = 3;
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Location = new System.Drawing.Point(115, 245);
            this.lbTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(83, 17);
            this.lbTable.TabIndex = 4;
            this.lbTable.Text = "Table name";
            // 
            // btnConvertTable
            // 
            this.btnConvertTable.Location = new System.Drawing.Point(395, 302);
            this.btnConvertTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvertTable.Name = "btnConvertTable";
            this.btnConvertTable.Size = new System.Drawing.Size(358, 28);
            this.btnConvertTable.TabIndex = 5;
            this.btnConvertTable.Text = "Convert Sql Server table to Mongodb collection";
            this.btnConvertTable.UseVisualStyleBackColor = true;
            this.btnConvertTable.Click += new System.EventHandler(this.btnConvertTable_Click);
            // 
            // tbProgressLog
            // 
            this.tbProgressLog.Location = new System.Drawing.Point(207, 353);
            this.tbProgressLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProgressLog.Multiline = true;
            this.tbProgressLog.Name = "tbProgressLog";
            this.tbProgressLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProgressLog.Size = new System.Drawing.Size(817, 136);
            this.tbProgressLog.TabIndex = 6;
            // 
            // lbProgressLog
            // 
            this.lbProgressLog.AutoSize = true;
            this.lbProgressLog.Location = new System.Drawing.Point(112, 357);
            this.lbProgressLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProgressLog.Name = "lbProgressLog";
            this.lbProgressLog.Size = new System.Drawing.Size(88, 17);
            this.lbProgressLog.TabIndex = 7;
            this.lbProgressLog.Text = "Progress log";
            // 
            // SQLToNoSQLConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 522);
            this.Controls.Add(this.lbProgressLog);
            this.Controls.Add(this.tbProgressLog);
            this.Controls.Add(this.btnConvertTable);
            this.Controls.Add(this.lbTable);
            this.Controls.Add(this.tbTable);
            this.Controls.Add(this.lbConnectionString);
            this.Controls.Add(this.tbConnectionString);
            this.Controls.Add(this.btnConvertAllTables);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SQLToNoSQLConverterForm";
            this.Text = "Sql Server to Mongodb converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertAllTables;
        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Label lbConnectionString;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Button btnConvertTable;
        private System.Windows.Forms.TextBox tbProgressLog;
        private System.Windows.Forms.Label lbProgressLog;

    }
}

