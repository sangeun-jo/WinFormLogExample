namespace WinFormLogExample
{
    partial class Form1
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
            this.writeLog = new System.Windows.Forms.Button();
            this.loadLog = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.logNo = new System.Windows.Forms.ColumnHeader();
            this.logContent = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // writeLog
            // 
            this.writeLog.Location = new System.Drawing.Point(27, 26);
            this.writeLog.Name = "writeLog";
            this.writeLog.Size = new System.Drawing.Size(126, 30);
            this.writeLog.TabIndex = 0;
            this.writeLog.Text = "로그 남기기...";
            this.writeLog.UseVisualStyleBackColor = true;
            this.writeLog.Click += new System.EventHandler(this.writeLog_Click);
            // 
            // loadLog
            // 
            this.loadLog.Location = new System.Drawing.Point(178, 26);
            this.loadLog.Name = "loadLog";
            this.loadLog.Size = new System.Drawing.Size(126, 30);
            this.loadLog.TabIndex = 1;
            this.loadLog.Text = "로그 불러오기...";
            this.loadLog.UseVisualStyleBackColor = true;
            this.loadLog.Click += new System.EventHandler(this.loadLog_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.logNo, this.logContent });
            this.listView1.Location = new System.Drawing.Point(27, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(748, 339);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // logNo
            // 
            this.logNo.Text = "No.";
            this.logNo.Width = 80;
            // 
            // logContent
            // 
            this.logContent.Text = "로그내용";
            this.logContent.Width = 860;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.loadLog);
            this.Controls.Add(this.writeLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ColumnHeader logNo;
        private System.Windows.Forms.ColumnHeader logContent;

        private System.Windows.Forms.Button writeLog;
        private System.Windows.Forms.Button loadLog;
        private System.Windows.Forms.ListView listView1;

        #endregion
    }
}