namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSummarize = new Button();
            btnClear = new Button();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtHours = new TextBox();
            lblFName = new Label();
            lblLName = new Label();
            lblHours = new Label();
            lblSummary = new Label();
            SuspendLayout();
            // 
            // btnSummarize
            // 
            btnSummarize.Location = new Point(82, 169);
            btnSummarize.Name = "btnSummarize";
            btnSummarize.Size = new Size(94, 29);
            btnSummarize.TabIndex = 6;
            btnSummarize.Text = "&Summarize";
            btnSummarize.UseVisualStyleBackColor = true;
            btnSummarize.Click += btnSummarize_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(182, 169);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(82, 68);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(125, 27);
            txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(213, 68);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(125, 27);
            txtLName.TabIndex = 3;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(344, 68);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(125, 27);
            txtHours.TabIndex = 5;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(82, 45);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(80, 20);
            lblFName.TabIndex = 0;
            lblFName.Text = "&First Name";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(213, 45);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(79, 20);
            lblLName.TabIndex = 2;
            lblLName.Text = "&Last Name";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(344, 45);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(103, 20);
            lblHours.TabIndex = 4;
            lblHours.Text = "&Hours Worked";
            // 
            // lblSummary
            // 
            lblSummary.BorderStyle = BorderStyle.FixedSingle;
            lblSummary.Location = new Point(82, 237);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(387, 76);
            lblSummary.TabIndex = 8;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 414);
            Controls.Add(lblSummary);
            Controls.Add(lblHours);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(txtHours);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(btnClear);
            Controls.Add(btnSummarize);
            Name = "Form1";
            Text = "Assignment 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSummarize;
        private Button btnClear;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtHours;
        private Label lblFName;
        private Label lblLName;
        private Label lblHours;
        private Label lblSummary;
    }
}
