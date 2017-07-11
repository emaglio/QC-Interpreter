namespace QC_Interpreter
{
    partial class GetLog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.todo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.open_file = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.openQCLog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.todo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.run, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 146);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // todo
            // 
            this.todo.AutoSize = true;
            this.todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todo.Location = new System.Drawing.Point(80, 5);
            this.todo.Margin = new System.Windows.Forms.Padding(80, 5, 3, 0);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(231, 20);
            this.todo.TabIndex = 0;
            this.todo.Text = "Select the QC file and click Run";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.open_file);
            this.flowLayoutPanel1.Controls.Add(this.filePath);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(411, 42);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(3, 3);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(75, 23);
            this.open_file.TabIndex = 0;
            this.open_file.Text = "Open File";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.Location = new System.Drawing.Point(82, 5);
            this.filePath.Margin = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(74, 17);
            this.filePath.TabIndex = 2;
            this.filePath.Text = "..file path..";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(150, 104);
            this.run.Margin = new System.Windows.Forms.Padding(150, 8, 3, 3);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(97, 39);
            this.run.TabIndex = 2;
            this.run.Text = "Run Interpreter";
            this.run.UseVisualStyleBackColor = true;
            // 
            // openQCLog
            // 
            this.openQCLog.FileName = "Pod QC log";
            this.openQCLog.Title = "Select QC log file";
            // 
            // GetLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 145);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetLog";
            this.Text = "QC Log Interpreter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label todo;
        private System.Windows.Forms.OpenFileDialog openQCLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Button run;
    }
}

