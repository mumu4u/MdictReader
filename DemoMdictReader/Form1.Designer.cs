namespace DemoMdictReader
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
			this.btnGetValue = new System.Windows.Forms.Button();
			this.txtValue3 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtValue2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtValue1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.wbResult = new System.Windows.Forms.WebBrowser();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnInitialize = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtDictFile = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGetValue
			// 
			this.btnGetValue.Location = new System.Drawing.Point(412, 71);
			this.btnGetValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGetValue.Name = "btnGetValue";
			this.btnGetValue.Size = new System.Drawing.Size(93, 35);
			this.btnGetValue.TabIndex = 0;
			this.btnGetValue.Text = "Get value";
			this.btnGetValue.UseVisualStyleBackColor = true;
			this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
			// 
			// txtValue3
			// 
			this.txtValue3.Location = new System.Drawing.Point(86, 73);
			this.txtValue3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtValue3.Name = "txtValue3";
			this.txtValue3.Size = new System.Drawing.Size(314, 26);
			this.txtValue3.TabIndex = 2;
			this.txtValue3.Text = "afternoon";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtValue2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtValue1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.wbResult);
			this.groupBox1.Controls.Add(this.txtValue3);
			this.groupBox1.Controls.Add(this.btnGetValue);
			this.groupBox1.Location = new System.Drawing.Point(345, 197);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(739, 486);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Utility";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 131);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(431, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "(Value 1, Value 2 and Value 3 are got from IdxBlockInfoList)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 79);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Value 3";
			// 
			// txtValue2
			// 
			this.txtValue2.Location = new System.Drawing.Point(344, 28);
			this.txtValue2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtValue2.Name = "txtValue2";
			this.txtValue2.Size = new System.Drawing.Size(154, 26);
			this.txtValue2.TabIndex = 7;
			this.txtValue2.Text = "1181";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(274, 34);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Value 2";
			// 
			// txtValue1
			// 
			this.txtValue1.Location = new System.Drawing.Point(86, 28);
			this.txtValue1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtValue1.Name = "txtValue1";
			this.txtValue1.Size = new System.Drawing.Size(154, 26);
			this.txtValue1.TabIndex = 5;
			this.txtValue1.Text = "1643257";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 34);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Value 1";
			// 
			// wbResult
			// 
			this.wbResult.Location = new System.Drawing.Point(21, 173);
			this.wbResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.wbResult.MinimumSize = new System.Drawing.Size(30, 31);
			this.wbResult.Name = "wbResult";
			this.wbResult.Size = new System.Drawing.Size(686, 284);
			this.wbResult.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.btnInitialize);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.btnBrowse);
			this.groupBox2.Controls.Add(this.txtDictFile);
			this.groupBox2.Location = new System.Drawing.Point(18, 18);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(1053, 168);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Setup";
			// 
			// btnInitialize
			// 
			this.btnInitialize.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnInitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInitialize.Location = new System.Drawing.Point(424, 91);
			this.btnInitialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnInitialize.Name = "btnInitialize";
			this.btnInitialize.Size = new System.Drawing.Size(202, 49);
			this.btnInitialize.TabIndex = 3;
			this.btnInitialize.Text = "Initialize";
			this.btnInitialize.UseVisualStyleBackColor = false;
			this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dict file";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(916, 32);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(112, 35);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtDictFile
			// 
			this.txtDictFile.Location = new System.Drawing.Point(88, 35);
			this.txtDictFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDictFile.Name = "txtDictFile";
			this.txtDictFile.ReadOnly = true;
			this.txtDictFile.Size = new System.Drawing.Size(817, 26);
			this.txtDictFile.TabIndex = 0;
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Mdict files|*.mdx";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(25, 197);
			this.listBox1.Name = "listBox1";
			this.listBox1.ScrollAlwaysVisible = true;
			this.listBox1.Size = new System.Drawing.Size(320, 504);
			this.listBox1.TabIndex = 4;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(7, 114);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(291, 26);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "Search by word";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 697);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "FormMain";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetValue;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDictFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.WebBrowser wbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
	}
}

